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
using Abp.Web.Mvc.Authorization;
using System.Globalization;

namespace ECJ.Web.Controllers.AppelOffre
{
    [AbpMvcAuthorize]
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
            xmlNoSoumiAgence.InnerText = soumi.noSoumissionAgence;
            XmlNode xmlPrix = doc.CreateNode(XmlNodeType.Element, "Prix", "");
            if(soumi.prix.ToString()=="")
            {
                xmlPrix.InnerText = prix.ToString();
            }
            else
                xmlPrix.InnerText = soumi.prix.ToString();

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
        public bool validerXML(String pathXml, XmlDocument doc, string pathXsd)
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
                return true;
            }
            catch (XmlSchemaValidationException e)
            {
                try
                {
                    //doc.Load("//deptinfo420/P2016_Equipe2/App_Data/logErreur.txt");
                    StreamWriter fileLog = new StreamWriter("//deptinfo420/P2016_Equipe2/App_Data/logErreur.txt", true);
                    fileLog.WriteLine(e.ToString());
                    doc.Save(fileLog);
                    fileLog.Close();
                    return false;
                }
                catch (IOException IOEx)
                {
                    ViewBag.IO = IOEx.Message;
                    return false;
                }

            }

        }

        private DirectoryInfo CreateDirectory(string path)
        {
            DirectoryInfo dr = null;
            try
            {
                if (!Directory.Exists(path))
                {
                     dr = Directory.CreateDirectory(path);

                }
              
            }
            catch (IOException IOEx)
            {
                ViewBag.IO = IOEx.Message;
                
            }

            return dr;
        }
        private void CreateSoumissionXml(tblSoumission soumi,tblAppelOffre appelOffre)
        {
            CptSoumi++;
            //DirectoryInfo dr = null;
            XmlDocument doc = new XmlDocument();
            XmlNode Racine = doc.CreateNode(XmlNodeType.Element, "SoumissionAgence", "http://tempuri.org/SoumissionAgence.xsd");
            string pathAlle = "//deptinfo420/P2016_Equipe2/App_Data/Soumission_alle";
            string pathXml = "";
            //dr = CreateDirectory(pathAlle);
            doc.AppendChild(Racine);
            Racine.AppendChild(CrerUneSoumissionXml(doc, soumi, appelOffre));
            try
            {
                //if(dr!=null)
                //{
                //    pathAlle =dr.FullName;
                //}
                pathXml = pathAlle+"/soumission_" + appelOffre.nom + "_" +provider.ReturnAgenceParSoumi(soumi).nom + ".xml";
                doc.Save(pathXml);
                string pathXsd = "//deptinfo420/P2016_Equipe2/App_Data/SoumissionAgence.xsd";
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
            //DirectoryInfo dr = null;
            string pathXsd = "//deptinfo420/P2016_Equipe2/App_Data/SoumissionAgence.xsd";
            string pathRetour = "//deptinfo420/P2016_Equipe2/App_Data/Soumission_retour";
            //dr = CreateDirectory(pathRetour);
            //On prcoure tous les xmls contenus dans le dossier
            try
            {

                //if (dr != null)
                //{
                //    pathRetour = dr.FullName;
                //}
                var files = from file in Directory.EnumerateFiles(pathRetour, "*.xml", SearchOption.AllDirectories)
                            select new
                            {
                                file
                            };

                foreach (var f in files)
                {
                    doc.Load(f.file);
                    XmlNode racine = doc.FirstChild; 
                    XmlNode soumission = racine.SelectSingleNode("Soumission");
                    tblSoumission soumi = provider.ReturnUneSoumi(Convert.ToInt32(soumission["NoSoumission"].InnerText));
                    if (!validerXML(f.file, doc, pathXsd))
                        return;
                        if (soumi != null)
                        {
                            soumi.noSoumissionAgence = soumission["noSoumissionAgence"].InnerText;
                            soumi.prix = Convert.ToDecimal(soumission["Prix"].InnerText,CultureInfo.InvariantCulture);
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
            //DirectoryInfo dr = null;
            string pathAlle = "//deptinfo420/P2016_Equipe2/App_Data/Soumission_alle";
            //dr = CreateDirectory(pathAlle);
            //On prcoure tous les xmls contenus dans le dossier
            try
            {
                //if (dr != null)
                //{
                //    pathAlle =dr.FullName;
                //}
                var files = from file in Directory.EnumerateFiles(pathAlle, "*.xml", SearchOption.AllDirectories)
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

            var appelOfrre = provider.ToutSomAppelOffre();
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
                        String.Format("{0:yyyy/MM/dd HH:mm:ss}", a.dateEnvoi).Contains(SearchString) ||
                        String.Format("{0:yyyy/MM/dd HH:mm:ss}", a.dateRequis).Contains(SearchString) ||
                        (a.description ?? "").ToString().ToUpper().Contains(SearchString)).ToList();
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
                             nomAgence = string.Join(",\n", provider.RetunSoumission(null).Where(s1 => a.Key.noAppelOffre == s1.noAppelOffre).Select(s => s.tblAgencePublicite.nom)),
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
            int second = 0;
            int hour = Convert.ToInt32(Request.Form.GetValues(nameHour)[0]);
            int min = Convert.ToInt32(Request.Form.GetValues(nameMin)[0]);
            if(Request.Form.GetValues(nameSecond)[0]!="")
            {
                second = Convert.ToInt32(Request.Form.GetValues(nameSecond)[0]);
            }
            DateTime d = new DateTime(date.Year,date.Month,date.Day,hour,min,second);
           return d;
        }

        private void deleteSoumission(string[] NoAgence,tblAppelOffre appel)
        {
            foreach (string no in NoAgence)
            {
                foreach (tblSoumission s in provider.RetunSoumission(appel.noAppelOffre))
                {
                    if (s.noAgencePub != int.Parse(no))
                    {
                        s.dateSupprime = DateTime.Now;
                        string filename = "//deptinfo420/P2016_Equipe2/App_Data/Soumission_alle\\soumission_" + appel.nom + "_" + s.tblAgencePublicite.nom + ".xml";
                        DeleteXml(filename);

                    }
                }
            }
        }
        // POST: AppellOffre/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "noAppelOffre,nom,dateRequis,dateEnvoi,description,dateSupprime,noEvenement,noMedia")] tblAppelOffre tblAppelOffre)
        {
            List<int> idSelect = new List<int>();
            string[] NoAgence = Request.Form.GetValues("noAgencePub");
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
                foreach (string no in NoAgence)
                {
                    tblSoumission souimi= CreateSoumission(int.Parse(no),tblAppelOffre.noAppelOffre);
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
            List<tblAgencePublicite> listAgencePub = provider.ReturnAgence(id);
            ViewBag.AllAgence = provider.ToutAgencePublicite();
            ViewBag.AgenceParAppel = provider.ReturnAgence(id);
            int[] noAgence = listAgencePub.Select(a => a.noAgencePub).ToArray();
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
            ViewBag.noAgencePub = new MultiSelectList(provider.ToutAgencePublicite(), "noAgencePub", "nom", listAgencePub.Select(a => a.noAgencePub));
            return View(tblAppelOffre);
        }

        // POST: AppellOffre/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "noAppelOffre,nom,dateRequis,dateEnvoi,description,dateSupprime,noEvenement,noMedia")] tblAppelOffre tblAppelOffre)
        {
            string[] NoAgence = Request.Form.GetValues("noAgencePub"); 
            if (ModelState.IsValid)
            {
                var statut = provider.ReturnStatAppel(tblAppelOffre);
                var evenement = provider.ReturnEvenAppel(tblAppelOffre);
                var media = provider.ReturnMediaAppel(tblAppelOffre);

                if (Request.Form.Get("save") == "Save")
                {
                    if(provider.RetunSoumission(tblAppelOffre.noAppelOffre).Count!=0)
                    {
                        foreach (tblSoumission s in provider.RetunSoumission(tblAppelOffre.noAppelOffre))
                        {
                            s.dateSupprime = DateTime.Now;
                            string filename = "//deptinfo420/P2016_Equipe2/Soumission_alle\\soumission_" + tblAppelOffre.nom + "_" + s.tblAgencePublicite.nom + ".xml";
                            DeleteXml(filename);
                        }
                    }
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
                deleteSoumission(NoAgence,tblAppelOffre); 
                //On créer les soumissions réliées à l'appel d'offre.
                foreach (string no in NoAgence)
                {                  
                   tblSoumission soumi= CreateSoumission(int.Parse(no), tblAppelOffre.noAppelOffre);
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
                provider.Save();
                return RedirectToAction("Index");

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
