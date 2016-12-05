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
    public class ReportController : ECJControllerBase
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
        private void U_SubreportAppelOffre(object sender, SubreportProcessingEventArgs e)
        {
         
                if (e.ReportPath == "ReportSoumission")
                {

                var soumi = (db.RetunSoumission(null).Where(s => s.noSoumission == int.Parse(e.Parameters.First(param => param.Name == "noSoumi").Values[0]))).Select(ss =>
                                      new {
                                          ss.noAppelOffre,
                                          ss.noAgencePub,
                                          ss.noSoumission,
                                          ss.prix,
                                          ss.statut,
                                          ss.commentaire,
                                          ss.noSoumissionAgence
                                      }).ToList();

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
                                        }).ToList();

                var reportAgence = (from ag in db.ToutAgencePublicite()
                                    select new
                                    {
                                        ag.noAgencePub,
                                        ag.nom,
                                    }).ToList();

                    ReportDataSource datasource2 = new ReportDataSource("DataSetSoumission", soumi);
                    var dataSourceAgence = new ReportDataSource("DataSetAgence", reportAgence);
                     ReportDataSource datasourceAppel = new ReportDataSource("DataSetAppelOffre", reportQueryAppel);
                    e.DataSources.Add(dataSourceAgence);
                    e.DataSources.Add(datasource2);
                    e.DataSources.Add(datasourceAppel);


            }

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
                                        a.noEvenement,
                                        a.tblEvenement                                       
                                    }).Where(ap => ap.noAppelOffre == Id);

            var reportQuerySoumi = (from s in db.RetunSoumission(Id)
                                    select new
                                    {
                                        s.prix,
                                        s.commentaire,
                                        s.statut,
                                        s.noAgencePub,
                                        s.noAppelOffre,
                                        s.noSoumission,
                                        s.noSoumissionAgence
                                    }).ToList();
            var reportMedia = db.ToutMedia().Where(me => me.noMedia == reportQueryAppel.First().noMedia);

            var reportStatut = db.ToutStatutAppel().Where(s => s.noStatut == reportQueryAppel.First().noStatut);

            var reportAgence = (from ag in db.ToutAgencePublicite()
                                select new
                                {
                                    ag.noAgencePub,
                                    ag.nom,
                                    noAppelOffre = ag.tblSoumission.Select(s => s.noAppelOffre).FirstOrDefault()
                                }).Where(age=>age.noAppelOffre==Id).ToList();

            var reportEvent = db.ToutEvenement().Where(e => e.noEvenement == reportQueryAppel.First().noEvenement);

            LocalReport u = new LocalReport();
            u.ReportPath = "Rapport/RapportAppel.rdlc";
            u.DataSources.Clear();
            ReportDataSource datasourceAppel = new ReportDataSource("DataSetAppelOffre", reportQueryAppel);
            ReportDataSource datasourceSoumi = new ReportDataSource("DataSetSoumission", reportQuerySoumi);
            ReportDataSource datasourceMedia = new ReportDataSource("DataSetMedia", reportMedia);
            var dataSourceStatut= new ReportDataSource("DataSetStatut", reportStatut);
            var dataSourceAgence = new ReportDataSource("DataSetAgence", reportAgence);
            var dataSourceEvent = new ReportDataSource("DataSetEvent", reportEvent);

            u.DataSources.Add(datasourceAppel);
            u.SubreportProcessing += U_SubreportAppelOffre;
            u.DataSources.Add(datasourceSoumi);        
            u.DataSources.Add(datasourceSoumi);
            u.DataSources.Add(datasourceMedia);
            u.DataSources.Add(dataSourceStatut);
            u.DataSources.Add(dataSourceAgence);
            u.DataSources.Add(dataSourceEvent);




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
            LocalReport rapport_acces = new LocalReport();
            rapport_acces.SubreportProcessing += Rapport_acces_SubreportProcessing;
            rapport_acces.ReportPath = "Rapport/RapportAcces.rdlc";
            var requete_logs = db.ToutLogs().Where(l => l.UserId != null).AsQueryable();
            var date_debut = Request.QueryString["filtre_debut"];
            if (!string.IsNullOrWhiteSpace(date_debut))
            {
                DateTime date_debut_dt = DateTime.Parse(date_debut);
                rapport_acces.SetParameters(new ReportParameter("date_debut", date_debut_dt.ToString("yyyy-MM-dd")));
                requete_logs = requete_logs.Where(l => l.ExecutionTime >= date_debut_dt);
            }
            var date_fin = Request.QueryString["filtre_fin"];
            if (!string.IsNullOrWhiteSpace(date_fin))
            {
                DateTime date_fin_dt = DateTime.Parse(date_fin);
                rapport_acces.SetParameters(new ReportParameter("date_fin", date_fin_dt.ToString("yyyy-MM-dd")));
                requete_logs = requete_logs.Where(l => l.ExecutionTime <= date_fin_dt);
            }

            var filtre_periode = Request.QueryString["filtre_periode"];

            var filtre_profil = Request.QueryString["filtre_profil"];
            if (filtre_profil != "tous")
            {
                requete_logs = requete_logs.Where(r => db.GetRoleUtilisateur(db.ReturnUtilisateur(r.UserId.Value)) == filtre_profil);
            }
            var groupByProfil = GroupByProfil(requete_logs);

            var filtre_utilisateur = Request.QueryString["filtre_utilisateur"];
            if (filtre_utilisateur != "tous")
            {
                requete_logs = requete_logs.Where(r => r.UserId.Value.ToString() == filtre_utilisateur);
            }
            var total_jour = requete_logs.GroupBy(r => r.ExecutionTime.ToShortDateString());
            rapport_acces.SetParameters(new ReportParameter("periode", filtre_periode));
            rapport_acces.SetParameters(new ReportParameter("profil_nom", filtre_profil));
            rapport_acces.SetParameters(new ReportParameter("role_id", "1"));
            rapport_acces.SetParameters(new ReportParameter("total_jours", total_jour.Count().ToString()));
            rapport_acces.SetParameters(new ReportParameter("auteur", db.ReturnUtilisateur(AbpSession.UserId.Value).UserName));
            rapport_acces.DataSources.Clear();
            rapport_acces.DataSources.Add(new ReportDataSource("Users", db.ToutUtilisateurs()));
            rapport_acces.DataSources.Add(new ReportDataSource("Logs", requete_logs));
            rapport_acces.DataSources.Add(new ReportDataSource("ToutLogs", db.ToutLogs().Where(l => l.UserId != null)));
            rapport_acces.DataSources.Add(new ReportDataSource("UserRoles", db.ToutRoleUtilisateur()));
            rapport_acces.DataSources.Add(new ReportDataSource("Roles", db.ToutRoles()));
            var cd = new System.Net.Mime.ContentDisposition
            {
                // for example foo.bak
                FileName = "Rapport_Securite.pdf",

                // always prompt the user for downloading, set to true if you want 
                // the browser to try to show the file inline
                Inline = true,
            };

            byte[] bytes = rapport_acces.Render("PDF");


            Response.AppendHeader("Content-Disposition", cd.ToString());
            return File(bytes, "application/pdf");
        }

        private void Rapport_acces_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Add(new ReportDataSource("Roles", db.ToutRoles()));
        }

        public static int GetISOWeek(DateTime day)
        {
            return System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(day, System.Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public IQueryable<string> GroupByProfil(IQueryable<ECJ.Web.Models.AbpAuditLogs> requete_logs)
        {
            return (from r in requete_logs
                    group r by db.GetRoleUtilisateur(db.ReturnUtilisateur((long)r.UserId))
                    into g
                    select g.Key
                );
        }
    }

    public class GroupByPeriode
    {
        public long MinDate { get; set; }
        public long MaxDate { get; set; }
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