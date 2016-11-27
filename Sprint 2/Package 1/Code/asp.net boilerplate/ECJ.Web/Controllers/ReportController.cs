using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;

namespace ECJ.Web.Controllers
{
    public class ReportController : Controller
    {
        DBProvider db = new DBProvider();
        // GET: Report
        public ActionResult Index()
        {
            var reportQuery = (from k in db.ToutEvenement()
                               select new
                               {
                                   k.noEvenement,
                                   k.nom,
                                   k.dateDebut,
                                   k.datefin,
                                   k.url
                               }).ToList();

            LocalReport u = new LocalReport();
            u.ReportPath = "Rapport/Report2.rdlc";
            u.DataSources.Clear();
            ReportDataSource datasource = new ReportDataSource("DataSet1", reportQuery);
            u.DataSources.Add(datasource);
            u.SubreportProcessing += U_SubreportProcessing;




            //ReportParameter p = new ReportParameter("DeptID", deptID.ToString());
            //u.SetParameters(new[] { p });

            var cd = new System.Net.Mime.ContentDisposition
            {
                // for example foo.bak
                FileName = "salut_bob.pdf",

                // always prompt the user for downloading, set to true if you want 
                // the browser to try to show the file inline
                Inline = true,
            };
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = u.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);


            Response.AppendHeader("Content-Disposition", cd.ToString());
            return File(bytes, "application/pdf");
        }

        private void U_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            var d = (db.ToutSousEvenement().Where(sse => sse.noEvenement == int.Parse(e.Parameters.First(param => param.Name == "noEvenement").Values[0])));
            ReportDataSource datasource2 = new ReportDataSource("DataSet1", d);
            e.DataSources.Add(datasource2);
        }

        private void U_SubreportComDon(object sender, SubreportProcessingEventArgs e)
        {

            var don = db.ToutDon().Where(d => d.noCommanditaire == (int.Parse(e.Parameters.First(param => param.Name == "noEvenement").Values[0])));
            ReportDataSource datasource2 = new ReportDataSource("DataSetDon", don);
            e.DataSources.Add(datasource2);
        }

        //Rapport de l'appel d'offre
        public ActionResult RapportAppelOffre()
        {
            var reportQueryAppel = (from a in db.ToutAppleOffre()
                                    select new
                                    {
                                        a.nom,
                                        a.dateEnvoi,
                                        a.dateRequis,
                                        a.description,
                                        a.noMedia,
                                        a.noStatut
                                    }).ToList();

            var reportQuerySoumi = (from s in db.RetunSoumission(null)
                                    select new
                                    {
                                        s.prix,
                                        s.commentaire,
                                        s.statut,
                                        s.noAgencePub,
                                        s.noAppelOffre
                                    }).ToList();

            var reportQuerySoumiAgen = (from s in db.RetunSoumission(null)
                                        select new
                                        {
                                            s.prix,
                                            s.statut,
                                            s.noAgencePub,
                                        }).ToList();


            LocalReport u = new LocalReport();
            u.ReportPath = "Rapport/RapportAppel.rdlc";
            u.DataSources.Clear();
            ReportDataSource datasourceAppel = new ReportDataSource("DataSetAppelOffre", reportQueryAppel);
            ReportDataSource datasourceSoumi = new ReportDataSource("DataSetSoumission", reportQuerySoumi);
            ReportDataSource datasourceAppelSoumi = new ReportDataSource("DataSetSoumission", reportQuerySoumiAgen);
            u.DataSources.Add(datasourceAppel);
            // u.SubreportProcessing += U_SubreportSatut;
            u.DataSources.Add(datasourceSoumi);
            u.DataSources.Add(datasourceAppelSoumi);


            //ReportParameter p = new ReportParameter("DeptID", deptID.ToString());
            //u.SetParameters(new[] { p });

            var cd = new System.Net.Mime.ContentDisposition
            {
                // for example foo.bak
                FileName = "Rapport_AppelOffre.pdf",

                // always prompt the user for downloading, set to true if you want 
                // the browser to try to show the file inline
                Inline = true,
            };
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = u.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);


            Response.AppendHeader("Content-Disposition", cd.ToString());
            return File(bytes, "application/pdf");
        }
        //Rapport Commenditaire
        public ActionResult RapportCommenditaire()
        {

            var reportQuery = (from k in db.ToutEvenement()
                               select new
                               {
                                   k.noEvenement,
                                   k.nom,
                                   k.dateDebut,
                                   k.datefin,
                                   k.url
                               }).ToList();


            var reportQueryCom = (from c in db.ToutCommenditaire()
                                  select new
                                  {
                                      c.noCommanditaire,
                                      c.textePresentation
                                  }).ToList();


            LocalReport u = new LocalReport();
            u.ReportPath = "Rapport/ReportComendite_Event.rdlc";
            u.DataSources.Clear();
            ReportDataSource datasourceComSous = new ReportDataSource("DataSetEvent", reportQuery);
            ReportDataSource datasourceComDon = new ReportDataSource("DataSetCommenditaire", reportQueryCom);
            u.DataSources.Add(datasourceComSous);
            u.DataSources.Add(datasourceComDon);
            u.SubreportProcessing += U_SubreportComDon;
            //ReportParameter p = new ReportParameter("DeptID", deptID.ToString());
            //u.SetParameters(new[] { p });

            var cd = new System.Net.Mime.ContentDisposition
            {
                // for example foo.bak
                FileName = "Rapport_Commenditaire.pdf",

                // always prompt the user for downloading, set to true if you want 
                // the browser to try to show the file inline
                Inline = true,
            };
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = u.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);


            Response.AppendHeader("Content-Disposition", cd.ToString());
            return File(bytes, "application/pdf");
        }
        public ActionResult RapportCalculateur(int id)
        {
            var reportQueryCalculateur = db.ReturnCalculateur(id);

            LocalReport u = new LocalReport();
            u.ReportPath = "Rapport/ReportCalculateur.rdlc";
            u.DataSources.Clear();
            ReportDataSource datasourceCalcul = new ReportDataSource("DataSetSoumission", reportQueryCalculateur);
            u.DataSources.Add(datasourceCalcul);

            //ReportParameter p = new ReportParameter("DeptID", deptID.ToString());
            //u.SetParameters(new[] { p });

            var cd = new System.Net.Mime.ContentDisposition
            {
                // for example foo.bak
                FileName = "Rapport_AppelOffre.pdf",

                // always prompt the user for downloading, set to true if you want 
                // the browser to try to show the file inline
                Inline = true,
            };
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = u.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);


            Response.AppendHeader("Content-Disposition", cd.ToString());
            return File(bytes, "application/pdf");
        }
    }

    public static class Ext
    {
        public static DataSet ToDataSet<T>(this IList<T> list)
        {
            Type elementType = typeof(T);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);

            //add a column to table for each public property on T
            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                t.Columns.Add(propInfo.Name, ColType);
            }

            //go through each property on T and add each value to the table
            foreach (T item in list)
            {
                DataRow row = t.NewRow();

                foreach (var propInfo in elementType.GetProperties())
                {
                    row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                }

                t.Rows.Add(row);
            }

            return ds;
        }
    }
}