﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ECJ.Web.Models;
using System.Xml;
using System.Xml.Schema;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;

namespace ECJ.Web.Controllers.AppelOffre
{
    public class AppellOffreController : ECJControllerBase
    {
        private PE2_OfficielEntities db = new PE2_OfficielEntities();
        private DBProvider provider;
        int CptSoumi = 0;
        DataSet ds = new DataSet();

        public AppellOffreController()
        {
            provider = new DBProvider();
        }


        //--Gestion de la création du xml d'une soumision.-----
        public XmlNode CrerUneSoumissionXml(XmlDocument doc, tblSoumission soumi, tblAppelOffre appelOffre)
        {
            double prix = 0.00;
            XmlNode xmlnoSoumi = doc.CreateNode(XmlNodeType.Element, "NoSoumission", "");
            xmlnoSoumi.InnerText = soumi.noSoumission.ToString();
            XmlNode xmlNom = doc.CreateNode(XmlNodeType.Element, "Nom", "");
            xmlNom.InnerText = appelOffre.nom;
            XmlNode xmlNoSoumiAgence = doc.CreateNode(XmlNodeType.Element, "noSoumissionAgence", "");
            xmlNom.InnerText = soumi.noSoumissionAgence;
            XmlNode xmlPrix = doc.CreateNode(XmlNodeType.Element, "Prix", "");
            if(soumi.prix.ToString()=="")
            {
                xmlPrix.InnerText = prix.ToString();
            }
            else
                xmlPrix.InnerText = prix.ToString();

            XmlNode xmlnoAgencePub = doc.CreateNode(XmlNodeType.Element, "noAgencePub", "");
            xmlnoAgencePub.InnerText = soumi.noAgencePub.ToString();
            XmlNode xmlnoAppelOffre = doc.CreateNode(XmlNodeType.Element, "noAppelOffre", "");
            xmlnoAppelOffre.InnerText = soumi.noAppelOffre.ToString();
            XmlNode xmlStatut = doc.CreateNode(XmlNodeType.Element, "Statut", "");   
            xmlStatut.InnerText = soumi.statut.ToString();
            XmlNode xmlCommentaire = doc.CreateNode(XmlNodeType.Element, "Commentaire", "");
            xmlCommentaire.InnerText = soumi.commentaire;
            XmlNode xmlSoumission = doc.CreateNode(XmlNodeType.Element, "Soumission", "");

            //On ajoute une soumision.
            xmlSoumission.AppendChild(xmlnoSoumi);
            xmlSoumission.AppendChild(xmlNoSoumiAgence);
            xmlSoumission.AppendChild(xmlNom);
            xmlSoumission.AppendChild(xmlPrix);
            xmlSoumission.AppendChild(xmlnoAgencePub);
            xmlSoumission.AppendChild(xmlnoAppelOffre);
            xmlSoumission.AppendChild(xmlStatut);
            xmlSoumission.AppendChild(xmlCommentaire);

            return xmlSoumission;

        }

        //Valider le xml de la soumision.
        public void validerXML(String pathXml, XmlDocument doc, string pathXsd)
        {
            try
            {
                doc.Load(pathXml);
                doc.Schemas.Add(null, pathXsd);
            }
            catch (IOException IOEx)
            {
                ViewBag.IO = IOEx.Message;
            }


            try
            {
                doc.Validate(null);
            }
            catch (XmlSchemaValidationException e)
            {
                try
                {
                    StreamWriter fileLog = new StreamWriter("//deptinfo420/P2016_Equipe2/logErreur.txt", true);
                    fileLog.WriteLine(e.ToString());
                    doc.Save(fileLog);
                    fileLog.Close();
                }
                catch (IOException IOEx)
                {
                    ViewBag.IO = IOEx.Message;
                }

            }

        }


        private void CreateSoumissionXml(tblSoumission soumi,tblAppelOffre appelOffre)
        {
            CptSoumi++;
            XmlDocument doc = new XmlDocument();
            XmlNode Racine = doc.CreateNode(XmlNodeType.Element, "SoumissionAgence", "http://tempuri.org/SoumissionAgence.xsd");
            doc.AppendChild(Racine);
            Racine.AppendChild(CrerUneSoumissionXml(doc, soumi, appelOffre));
            try
            {
                string pathXml = "//deptinfo420/P2016_Equipe2/Soumission_alle/soumission_" + appelOffre.nom+"_"+soumi.tblAgencePublicite.nom+".xml";
                doc.Save(pathXml);
                string pathXsd = "//deptinfo420/P2016_Equipe2/Soumission_alle/SoumissionAgence.xsd";
                validerXML(pathXml, doc, pathXsd);
  

            }
            catch (UnauthorizedAccessException UAEx)
            {
                ViewBag.Autorisation = UAEx.Message;
            }
            catch (PathTooLongException PathEx)
            {

                ViewBag.PathLong = PathEx.Message;
            }
            catch (IOException IOEx)
            {
                ViewBag.IO = IOEx.Message;
            }
        }

        private void RetournerSoumissionXml()
        {
            
            XmlDocument doc = new XmlDocument();
            //On prcoure tous les xmls contenus dans le dossier
            try
            {
                var files = from file in Directory.EnumerateFiles("//deptinfo420/P2016_Equipe2/Soumission_retour", "*.xml", SearchOption.AllDirectories)
                            select new
                            {
                                file
                            };
               foreach(var f in files)
                {
                    doc.Load(f.file);
                    XmlNode racine = doc.FirstChild; 
                    XmlNode soumission = racine.SelectSingleNode("Soumission");
                        tblSoumission soumi = provider.ReturnUneSoumi(Convert.ToInt32(soumission["NoSoumission"].InnerText));
                        if (soumi != null)
                        {
                            soumi.noSoumissionAgence = soumission["noSoumissionAgence"].InnerText;
                            soumi.prix = Convert.ToDecimal(soumission["Prix"].InnerText);
                            //soumi.noAgencePub = Convert.ToInt32(soumission["noAgencePub"].InnerText);
                            //soumi.noAppelOffre = Convert.ToInt32(soumission["noAppelOffre"].InnerText);
                            //soumi.statut = Convert.ToByte(soumission["Statut"].InnerText);
                            soumi.commentaire = soumission["Commentaire"].InnerText;
                            provider.Save();
                        }
                }                   
                
            }
            catch (UnauthorizedAccessException UAEx)
            {
                ViewBag.Autorisation = UAEx.Message;
            }
            catch (PathTooLongException PathEx)
            {

                ViewBag.PathLong = PathEx.Message;
            }
            catch (IOException IOEx)
            {
                ViewBag.IO = IOEx.Message;
                LayoutController.erreur = IOEx;
            }
        }

        private void DeleteXml(string nameXml)
        {
            XmlDocument doc = new XmlDocument();
            //On prcoure tous les xmls contenus dans le dossier
            try
            {
                var files = from file in Directory.EnumerateFiles("//deptinfo420/P2016_Equipe2/Soumission_alle", "*.xml", SearchOption.AllDirectories)
                            select new
                            {
                                file
                            };
                foreach (var f in files)
                {
                    try
                    {
                        doc.Load(f.file);
                        if (f.file.Equals(nameXml))
                        {
                            System.IO.File.Delete(f.file);
                        }
                    }
                    catch (IOException IOEx)
                    {
                        ViewBag.IO = IOEx.Message;
                    }
                                      
                }

            }
            catch (UnauthorizedAccessException UAEx)
            {
                ViewBag.Autorisation = UAEx.Message;
            }
            catch (PathTooLongException PathEx)
            {

                ViewBag.PathLong = PathEx.Message;
            }
            catch (IOException IOEx)
            {
                ViewBag.IO = IOEx.Message;
            }
        }

        private tblSoumission CreateSoumission(int noAgenP, int noApp)
        {
            tblSoumission soumi = provider.SleclectSoumi(noApp, noAgenP);
            if (soumi!=null)//update soumission
            {
                soumi.noAgencePub = noAgenP;
                soumi.noAppelOffre = noApp;
                soumi.statut = null;
                provider.Save();
                return soumi;
            }
            else
            {
                var soumission = new tblSoumission { noAgencePub = noAgenP, noAppelOffre = noApp, statut=null};
                provider.InsertSoumission(soumission);
                return soumission;

            }

        }


        // GET: AppellOffre
        public ActionResult Index(string SearchString)
        {
            //var  = db.tblAppelOffre.Include(t => t.tblEvenement).Include(t => t.tblStatutAppelOffre);

            var appelOfrre = from q in db.vueSomAppelOffre
                             select q;
            if (!String.IsNullOrEmpty(SearchString))
            {
                SearchString = SearchString.Trim().ToUpper();
                if (SearchString=="")
                    return RedirectToAction("Index");
                else
                {
                    appelOfrre = appelOfrre.Where(
                        a => (a.nomAppelOffre ?? "").ToString().ToUpper().Contains(SearchString) ||
                        (a.nomStatut ?? "").ToString().ToUpper().Contains(SearchString) || 
                        (a.nomEvent ?? "").ToString().ToUpper().Contains(SearchString) || 
                        (a.nomAgence ?? "").ToString().ToUpper().Contains(SearchString) ||                       
                        (a.description ?? "").ToString().ToUpper().Contains(SearchString));
                }

            }

            var appelGoupBy = appelOfrre.GroupBy(aoa => new { aoa.noAppelOffre, aoa.nomAppelOffre, aoa.nomEvent, aoa.noStatut, aoa.description, aoa.dateEnvoi, aoa.dateRequis, aoa.couleur }).ToList()
                         .Select(a => new vueSomAppelOffre
                         {
                             noAppelOffre = a.Key.noAppelOffre,
                             nomAppelOffre = a.Key.nomAppelOffre,
                             nomEvent = a.Key.nomEvent,
                             noStatut = a.Key.noStatut,
                             description = a.Key.description,
                             nomAgence = string.Join(",\n", db.vueSomAppelOffre.Where(j => j.noAppelOffre == a.Key.noAppelOffre).Select(i => i.nomAgence)),
                             dateRequis = a.Key.dateRequis,
                             dateEnvoi = a.Key.dateEnvoi,
                             couleur = a.Key.couleur
                         }).OrderBy(a => a.noStatut);

            //Retourner les soumission du xml vers la bd
            RetournerSoumissionXml();
            
            return View(appelGoupBy.ToList());
        }


        // GET: AppellOffre/Details/5
        public ActionResult Details(int? id)
        {
            //On retourne les soumissions associées à l'appel d'offre
            ViewBag.soumission= provider.RetunSoumission(id);
            //On retourne les agences de publicités associées à l'appel d'offre
            ViewBag.agencePub = provider.ReturnAgence(id);
            //ViewBag.Media = provider.RetunrMedia();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblAppelOffre tblAppelOffre =provider.returnAppel(id);
            if (tblAppelOffre == null)
            {
                return HttpNotFound();
            }
            return View(tblAppelOffre);
        }

        // GET: AppellOffre/Create
        public ActionResult Create()
        {

            ViewBag.noEvenement = new SelectList(provider.ToutEvenement(), "noEvenement", "nom");
            ViewBag.noStatut = new SelectList(provider.ToutStatutAppel(), "noStatut", "nom");
            ViewBag.noMedia = new SelectList(provider.ToutMedia(), "noMedia", "nom");
            ViewBag.noAgencePub = new MultiSelectList(provider.ToutAgencePublicite(), "noAgencePub", "nom");
            return View();
        }

        private DateTime AffecterTemps(DateTime date, string nameHour, string nameMin, string nameSecond)
        {
            int hour = Convert.ToInt32(Request.Form.GetValues(nameHour)[0]);
            int min = Convert.ToInt32(Request.Form.GetValues(nameMin)[0]);
            int second=Convert.ToInt32(Request.Form.GetValues(nameSecond)[0]);
            DateTime d = new DateTime(date.Year,date.Month,date.Day,hour,min,second);
           return d;
        }
        // POST: AppellOffre/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "noAppelOffre,nom,dateRequis,dateEnvoi,description,dateSupprime,noEvenement,noMedia")] tblAppelOffre tblAppelOffre, int[] noAgencePub)
        {
            List<int> idSelect = new List<int>();
            ViewBag.noAgencePub = new MultiSelectList(provider.ToutAgencePublicite(), "noAgencePub", "nom",idSelect);
            
            if (ModelState.IsValid)
            {
               // var statut = provider.ReturnStatAppel(tblAppelOffre);
                var evenement = provider.ReturnEvenAppel(tblAppelOffre);
                var media = provider.ReturnMediaAppel(tblAppelOffre);

                provider.AjoutAppelOffre(tblAppelOffre);
                if(Request.Form.Get("save")== "Save")
                {
                    tblAppelOffre.noStatut = provider.ReturnNoStatut("En Création");
                    tblAppelOffre.dateEnvoi = AffecterTemps(tblAppelOffre.dateEnvoi, "heureEnvoi", "minEnvoi", "secondeEnvoi");
                    tblAppelOffre.dateRequis = AffecterTemps(tblAppelOffre.dateRequis, "heureRequise", "minRequise", "secondeRequise");
                    provider.Save();
                    return RedirectToAction("Index");
                }
                //si l'Appel d'offre n'est pas en création il tombe à envoyé.
                tblAppelOffre.noStatut = provider.ReturnNoStatut("Envoyé");
                tblAppelOffre.dateEnvoi = AffecterTemps(tblAppelOffre.dateEnvoi, "heureEnvoi", "minEnvoi", "secondeEnvoi");
                tblAppelOffre.dateRequis = AffecterTemps(tblAppelOffre.dateRequis, "heureRequise", "minRequise", "secondeRequise");
                provider.Save();

                //On créer les soumissions réliées à l'appel d'offre.
                foreach (int no in noAgencePub)
                {
                    tblSoumission souimi= CreateSoumission(no,tblAppelOffre.noAppelOffre);
                    CreateSoumissionXml(souimi, tblAppelOffre);
                }
               // conn.Close(); //On ferme la connection.
                return RedirectToAction("Index");
            }

            ViewBag.noEvenement = new SelectList(provider.ToutEvenement(), "noEvenement", "nom", tblAppelOffre.noEvenement);
            ViewBag.noStatut = new SelectList(provider.ToutStatutAppel(), "noStatut", "nom", tblAppelOffre.noStatut);
            ViewBag.noMedia = new SelectList(provider.ToutMedia(), "noMedia", "nom",tblAppelOffre.noMedia);
            ViewBag.noAgencePub = new MultiSelectList(provider.ToutAgencePublicite(), "noAgencePub", "nom");
            return View(tblAppelOffre);
        }

        // GET: AppellOffre/Edit/5
        public ActionResult Edit(int? id)
        {
            int no = 0;
            List<tblAgencePublicite> listAgencePub = provider.ReturnAgence(id);
            int[] noAgence = new int[listAgencePub.Count];
            foreach (var agence in listAgencePub)
            {
                noAgence[no] = agence.noAgencePub;
                no++;
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblAppelOffre tblAppelOffre = provider.returnAppel(id);
            if (tblAppelOffre == null)
            {
                return HttpNotFound();
            }
            ViewBag.noEvenement = new SelectList(provider.ToutEvenement(), "noEvenement", "nom", tblAppelOffre.noEvenement);
            ViewBag.noStatut = new SelectList(provider.ToutStatutAppel(), "noStatut", "nom", tblAppelOffre.noStatut);
            ViewBag.noMedia = new SelectList(provider.ToutMedia(), "noMedia", "nom", tblAppelOffre.noMedia);
            ViewBag.noAgencePub = new MultiSelectList(provider.ToutAgencePublicite(), "noAgencePub", "nom", noAgence);
            return View(tblAppelOffre);
        }

        // POST: AppellOffre/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "noAppelOffre,nom,dateRequis,dateEnvoi,description,dateSupprime,noEvenement,noMedia")] tblAppelOffre tblAppelOffre, int[] noAgencePub)
        {
            if (ModelState.IsValid)
            {
                var statut = provider.ReturnStatAppel(tblAppelOffre);
                var evenement = provider.ReturnEvenAppel(tblAppelOffre);
                var media = provider.ReturnMediaAppel(tblAppelOffre);

                if (Request.Form.Get("save") == "Save")
                {
                    tblAppelOffre.noStatut = provider.ReturnNoStatut("En Création");
                    tblAppelOffre.dateEnvoi = AffecterTemps(tblAppelOffre.dateEnvoi, "heureEnvoi", "minEnvoi", "secondeEnvoi");
                    tblAppelOffre.dateRequis = AffecterTemps(tblAppelOffre.dateRequis, "heureRequise", "minRequise", "secondeRequise");
                    provider.Save();
                    return RedirectToAction("Index");
                }
                //si l'Appel d'offre n'est pas en création il tombe à envoyé.
                tblAppelOffre.noStatut = provider.ReturnNoStatut("Envoyé");
                tblAppelOffre.dateEnvoi = AffecterTemps(tblAppelOffre.dateEnvoi, "heureEnvoi", "minEnvoi", "secondeEnvoi");
                tblAppelOffre.dateRequis = AffecterTemps(tblAppelOffre.dateRequis, "heureRequise", "minRequise", "secondeRequise");
                provider.UpdateAppelOffre(tblAppelOffre);

                //On supprime les soumissions qui ne sont plus ratachées à l'appel d'offre.
                foreach(int no in noAgencePub)
                {
                    foreach (tblSoumission s in provider.RetunSoumission(tblAppelOffre.noAppelOffre))
                    {
                        if(s.noAgencePub!=no)
                        {
                            s.dateSupprime = DateTime.Now;
                            string filename = "//deptinfo420/P2016_Equipe2/Soumission_alle\\soumission_" + tblAppelOffre.nom+"_"+s.tblAgencePublicite.nom+".xml";
                            DeleteXml(filename);

                        }
                    }
                }
  
                //On créer les soumissions réliées à l'appel d'offre.
                foreach (int no in noAgencePub)
                {                  
                   tblSoumission soumi= CreateSoumission(no, tblAppelOffre.noAppelOffre);
                    CreateSoumissionXml(soumi, tblAppelOffre);
                }
                return RedirectToAction("Index");
            }
            ViewBag.noEvenement = new SelectList(provider.ToutEvenement(), "noEvenement", "nom", tblAppelOffre.noEvenement);
            ViewBag.noStatut = new SelectList(provider.ToutStatutAppel(), "noStatut", "nom", tblAppelOffre.noStatut);
            ViewBag.noMedia = new SelectList(provider.ToutMedia(), "noMedia", "nom", tblAppelOffre.noMedia);
            ViewBag.noAgencePub = new SelectList(provider.ToutAgencePublicite(), "noAgencePub", "nom");
            return View(tblAppelOffre);
        }

        // GET: AppellOffre/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblAppelOffre tblAppelOffre = provider.returnAppel(id);
            if(tblAppelOffre.noStatut== provider.ReturnNoStatut("En Création")) //Statut en création on supprime l'appel d'offre.
            {
               tblAppelOffre.dateSupprime = DateTime.Now;
            }
            else
            {
                tblAppelOffre.noStatut = provider.ReturnNoStatut("Annulé");
            }

            //On supprime toutes les soumissions réliées à cet appel d'offre
            foreach (tblSoumission soumi in provider.RetunSoumission(tblAppelOffre.noAppelOffre))
            {
                soumi.dateSupprime = DateTime.Now;
            }
            provider.Save();
            if (tblAppelOffre == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index");
        }
    }
}
