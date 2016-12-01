using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;
using System.Data.Entity.SqlServer;

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

        private void U_SubreportComEvent(object sender, SubreportProcessingEventArgs e)
        {

            if(e.ReportPath=="ReportCommenditaire")
            {
                var com = db.CommenEvent(int.Parse(e.Parameters.First(param => param.Name == "noEvenement").Values[0])).Select(a => 
                new
                {
                    nomCommanditaire = a.nomCommanditaire,
                    textePresentation = a.textePresentation
                }).ToList();
                ReportDataSource datasource2 = new ReportDataSource("DataSetCom", com);
                e.DataSources.Add(datasource2);
            }
            else
            {
                if(e.ReportPath == "ReportDon")
                {
                    var don = (db.ToutDon().Where(d => d.noCommanditaire == int.Parse(e.Parameters.First(param => param.Name == "noCom").Values[0]))).Select(a =>
                    new { dateDon = a.dateDon,
                    montant = a.montant}).ToList();
                    ReportDataSource datasource2 = new ReportDataSource("DataSetDon", don);
                    e.DataSources.Add(datasource2);
                }
            }

        }

        //Rapport de l'appel d'offre
        public ActionResult RapportAppelOffre(int? Id)
        {

            var reportQueryAppel = (from a in db.ToutAppleOffre()
                                    select new
                                    {
                                        a.noAppelOffre,
                                        a.nom,
                                        a.dateEnvoi,
                                        a.dateRequis,
                                        a.description,
                                        a.noMedia,
                                        a.noStatut,
                                        a.noEvenement
                                    }).Where(ap => ap.noAppelOffre == Id);

            var reportQuerySoumi = (from s in db.RetunSoumission(Id)
                                    select new
                                    {
                                        s.prix,
                                        s.commentaire,
                                        s.statut,
                                        s.noAgencePub,
                                        s.noAppelOffre
                                    }).ToList();

            var reportQuerySoumiAgen = (from s in reportQuerySoumi
                                        select new
                                        {
                                            s.prix,
                                            s.statut,
                                            s.noAgencePub,
                                        }).ToList();
            var reportMedia = (from m in db.ToutMedia()
                                        select new
                                        {
                                          m.noMedia,
                                          m.nom,
                                          m.description
                                        }).ToList();
            var reportStatut = (from s in db.ToutStatutAppel()
                               select new
                               {
                                   s.noStatut,
                                   s.nom,
                                   s.description
                               }).ToList();
            var reportAgence = (from ag in db.ToutAgencePublicite()
                                select new
                                {
                                    ag.noAgencePub,
                                    ag.nom,
                                }).ToList();

            var reportEvent = (from e in db.ToutEvenement()
                                select new
                                {
                                    e.noEvenement,
                                    e.nom,
                                    SousEvent=e.tblSousEvenement.Select(se => se.nom).FirstOrDefault(),
                                    noAppelOffre = e.tblAppelOffre.Select(a => a.noAppelOffre).FirstOrDefault()
                                }).Where(ev=>ev.noAppelOffre==Id).ToList();

            var reportSousEvent= (from se in reportEvent
                                select new
                                {
                                 nom= se.SousEvent
                                }).ToList();

            LocalReport u = new LocalReport();
            u.ReportPath = "Rapport/RapportAppel.rdlc";
            u.DataSources.Clear();
            ReportDataSource datasourceAppel = new ReportDataSource("DataSetAppelOffre", reportQueryAppel);
            ReportDataSource datasourceSoumi = new ReportDataSource("DataSetSoumission", reportQuerySoumi);
            ReportDataSource datasourceAppelSoumi = new ReportDataSource("DataSetSoumission", reportQuerySoumiAgen);
            ReportDataSource datasourceMedia = new ReportDataSource("DataSetMedia", reportQueryAppel);
            var dataSourceStatut= new ReportDataSource("DataSetStatut", reportStatut);
            var dataSourceAgence = new ReportDataSource("DataSetAgence", reportAgence);
            var dataSourceEvent = new ReportDataSource("DataSetEvent", reportEvent);
            var dataSourceSousEvent = new ReportDataSource("DataSetSousEvent", reportSousEvent);

            u.DataSources.Add(datasourceAppel);
            // u.SubreportProcessing += U_SubreportSatut;
            u.DataSources.Add(datasourceSoumi);
            u.DataSources.Add(datasourceAppelSoumi);
            u.DataSources.Add(datasourceMedia);
            u.DataSources.Add(dataSourceStatut);
            u.DataSources.Add(dataSourceAgence);
            u.DataSources.Add(dataSourceEvent);
            u.DataSources.Add(dataSourceSousEvent);




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
                                      c.nomCommanditaire,
                                      c.noCommanditaire,
                                      c.textePresentation
                                  }).ToList();

            var reportQueryDon = db.ToutDon().Select(d => new
            {
                montant = d.montant,
                noCommanditaire = d.noCommanditaire
            }).ToList();

            LocalReport u = new LocalReport();
            u.ReportPath = "Rapport/ReportComendite_Event.rdlc";
            u.DataSources.Clear();
            ReportDataSource datasourceComSous = new ReportDataSource("DataSetEvent", reportQuery);
            ReportDataSource datasourceComDon = new ReportDataSource("DataSetCommenditaire", reportQueryCom);
            var dsDons = new ReportDataSource("DataSetDon", reportQueryDon);
            u.DataSources.Add(datasourceComSous);
            u.DataSources.Add(datasourceComDon);
            u.DataSources.Add(dsDons);
            u.SubreportProcessing += U_SubreportComEvent;
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
        public ActionResult RapportCalculateur()
        {
            var reportQueryCalculateur = (from s in db.ReturnListCalculateur().Where(c => c.noSousEvenement == 5)
                                    select new
                                    {
                                        s.noSousEvenement,
                                        s.billet,
                                        s.billetVIP,
                                        s.prixBillet,
                                        s.prixBilletVIP,
                                        s.souperSpectacle,
                                        s.prixSouper,
                                        s.jeunePourcent,
                                        s.adultePourcent,
                                        s.ainePourcent,
                                        s.jeuneRatio,
                                        s.adulteRatio,
                                        s.aineRatio,
                                        s.promo,
                                        s.prevente,
                                        s.customBillet1,
                                        s.customBillet2,
                                        s.customPrix1,
                                        s.customPrix2,
                                        s.customNom1,
                                        s.customNom2,
                                    }).ToList();

            var reportQuerySSEvent = (from s in db.ToutSousEvenement().Where(sse => sse.noSousEvenement == 5)
                                      select new
                                      {
                                          s.noSousEvenement,
                                          s.nom,
                                          s.description,
                                          s.noEvenement,
                                          s.noSalle
                                      }).ToList();

            var reportQuerySalle = (from s in db.ReturnListSalle().Where(a => a.noSalle == 1)
                                    select new
                                    {
                                        s.noSalle,
                                         s.nomSalle,
                                         s.prix,
                                         s.billet,
                                         s.billetVIP,
                                         s.photoSalle,
                                         s.dateSupprime,
                                         s.urlGoogleMap
                                    }).ToList();


            LocalReport u = new LocalReport();
            u.ReportPath = "Rapport/ReportCalculateur.rdlc";
            u.DataSources.Clear();
            ReportDataSource datasourceCalcul = new ReportDataSource("DataSetCalculateur", reportQueryCalculateur);
            ReportDataSource datasourceSSEvent = new ReportDataSource("DataSetSousEvent", reportQuerySSEvent);
            ReportDataSource datasourceSalle = new ReportDataSource("DataSetSalle", reportQuerySalle);
            u.DataSources.Add(datasourceCalcul);
            u.DataSources.Add(datasourceSSEvent);
            u.DataSources.Add(datasourceSalle);

            //ReportParameter p = new ReportParameter("DeptID", deptID.ToString());
            //u.SetParameters(new[] { p });

            var cd = new System.Net.Mime.ContentDisposition
            {
                // for example foo.bak
                FileName = "Rapport_Calculateur.pdf",

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

        //Rapport de sécurité
        public ActionResult RapportAcces()
        {
            /*
            var reportSecurite = (from us in db.ToutUtilisateurs()
                               select new
                               {
                                   us.UserName,
                                   us.Name,
                                   us.Surname,
                                   us.EmailAddress,
                                   us.Password,
                                   us.LastModificationTime,
                                   us.LastModifierUserId,
                                   us.CreationTime,
                                   us.CreatorUserId
                               }).ToList();

            LocalReport u = new LocalReport();
            u.ReportPath = "Rapport/ReportSecurite.rdlc";
            u.DataSources.Clear();
            ReportDataSource datasourceSecurite = new ReportDataSource("DataSetUser", reportSecurite);
            u.DataSources.Add(datasourceSecurite);
            //ReportParameter p = new ReportParameter("DeptID", deptID.ToString());
            //u.SetParameters(new[] { p });

            var cd = new System.Net.Mime.ContentDisposition
            {
                // for example foo.bak
                FileName = "Rapport_Securite.pdf",

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
            */
            var requete_logs = db.ToutLogs().AsQueryable();
            var date_debut = Request.Form["filtre_debut"];
            if (!string.IsNullOrWhiteSpace(date_debut))
            {
                DateTime date_debut_dt = DateTime.Parse(date_debut);
                requete_logs = requete_logs.Where(l => l.ExecutionTime >= date_debut_dt);
            }
            var date_fin = Request.Form["filtre_fin"];
            if (!string.IsNullOrWhiteSpace(date_fin))
            {
                DateTime date_fin_dt = DateTime.Parse(date_fin);
                requete_logs = requete_logs.Where(l => l.ExecutionTime <= date_fin_dt);
            }

            var filtre_periode = Request.Form["filtre_periode"];
            if (filtre_periode != "tous")
            {
                
                switch (filtre_periode)
                {
                    case "mois":
                        var groupByMois = requete_logs.GroupBy(l => l.ExecutionTime.Month).Select(l => new GroupByPeriode() { Date = l.Key, NombreAcces = l.Count(), MaxDate = l.Max(l1 => l1.ExecutionTime.Month) });
                        break;
                    case "semaine":
                        var groupBySemaine = (from c in requete_logs
                                        group c by new { SqlFunctions.DatePart("wk", c.ExecutionTime), 2 } into g
                                        let MaxDate = g.Max(c => SqlFunctions.DatePart("wk", c.ExecutionTime))
                                        let Count = g.Count()
                                        orderby MaxDate
                                        select new GroupByPeriode() { Date = g.Key.Value, MaxDate = MaxDate.Value, NombreAcces = Count }).AsQueryable();
                        break;
                    case "jour":
                        var groupByJour = requete_logs.GroupBy(l => l.ExecutionTime.Month).Select(l => new GroupByPeriode() { Date = l.Key, NombreAcces = l.Count(), MaxDate = l.Max(l1 => l1.ExecutionTime.Month) });
                        break;
                }
            }

            foreach (string item in Request.Form)
            {
                Response.Write(item + ":" + (Request.Form[item]) + "<br>");
            }
            return new EmptyResult();
        }
    }

    public class GroupByPeriode
    {
        public int Date { get; set; }
        public int MaxDate { get; set; }
        public int NombreAcces { get; set; }
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