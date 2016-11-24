using System;
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
using ECJ.Authorization;
using System.Web.Helpers;

namespace ECJ.Web.Controllers.AppelOffre
{
    [AbpMvcAuthorize(PermissionNames.ConsulterAppelOffre)]
    public class AppellOffreController : ECJControllerBase
    {
        private DBProvider provider;
        int CptSoumi = 0;
        DataSet ds = new DataSet();

        public AppellOffreController()
        {
            provider = new DBProvider();
            GetPermissions();
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

        private void CreateXsd(string pathXSD,XmlDocument doc)
        {
            string ContentXSD= "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                                "<xs:schema id=\"SoumissionAgence\" xmlns:xs=\"http://www.w3.org/2001/XMLSchema\">" +
                                 "<xs:element name=\"Soumission\">" +
                                    "<xs:complexType>" +
                                      "<xs:sequence>" +
                                        "<xs:element name=\"NoSoumission\" type=\"xs:int\"/>" +
                                        "<xs:element name=\"noSoumissionAgence\" type=\"xs:string\"/>" +
                                        "<xs:element name=\"Nom\" type=\"xs:string\"/>" +
                                        "<xs:element name=\"Prix\" type=\"xs:decimal\"/>" +
                                        "<xs:element name=\"noAgencePub\" type=\"xs:int\"/>" +
                                        "<xs:element name=\"noAppelOffre\" type=\"xs:int\"/>" +
                                        "<xs:element name=\"Statut\" type=\"xs:string\"/>" +
                                        "<xs:element name=\"Commentaire\" type=\"xs:string\"/>" +
                                     "</xs:sequence>" +
                                    "</xs:complexType>" +
                                  "</xs:element>" +
                                "</xs:schema>";
            try
            {
                StreamWriter xsd = new StreamWriter(pathXSD);
                xsd.WriteLine(ContentXSD);
                doc.Save(xsd);
                xsd.Close();
            }
            catch (IOException IOEx)
            {
                ViewBag.IO = IOEx.Message;
                LayoutController.erreur = IOEx;
            }


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
                LayoutController.erreur = IOEx;
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
                    StreamWriter fileLog = new StreamWriter("E:\\inetpub\\wwwroot\\Projet2016\\Equipe2\\logErreur.txt", true);
                    fileLog.WriteLine(e.ToString());
                    doc.Save(fileLog);
                    fileLog.Close();
                    return false;
                }
                catch (IOException IOEx)
                {
                    ViewBag.IO = IOEx.Message;
                    LayoutController.erreur = IOEx;
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
                LayoutController.erreur = IOEx;

            }

            return dr;
        }
        private void CreateSoumissionXml(tblSoumission soumi,tblAppelOffre appelOffre)
        {
            CptSoumi++;
            DirectoryInfo dr = null;
            XmlDocument doc = new XmlDocument();
            XmlNode Racine = doc.CreateNode(XmlNodeType.Element, "SoumissionAgence", "http://tempuri.org/SoumissionAgence.xsd");
            string pathAlle = "E:\\inetpub\\wwwroot\\Projet2016\\Equipe2\\Soumission_alle";
            string pathXml = "";
            dr = CreateDirectory(pathAlle);
            doc.AppendChild(Racine);
            Racine.AppendChild(CrerUneSoumissionXml(doc, soumi, appelOffre));
            try
            {
                if (dr != null)
                {
                    pathAlle = dr.FullName;
                }
                pathXml = pathAlle+"/soumission_" + CleanFileName(appelOffre.nom) + "_" + CleanFileName(provider.ReturnAgenceParSoumi(soumi).nom) + ".xml";
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
                LayoutController.erreur = IOEx;
            }
        }
        private static string CleanFileName(string fileName)
        {
            return Path.GetInvalidFileNameChars().Aggregate(fileName, (current, c) => current.Replace(c.ToString(), string.Empty));
        }

        private void RetournerSoumissionXml()
        {
            
            XmlDocument doc = new XmlDocument();
            DirectoryInfo dr = null;
            string pathXsd = "E:\\inetpub\\wwwroot\\Projet2016\\Equipe2\\SoumissionAgence.xsd";
            string pathRetour = "E:\\inetpub\\wwwroot\\Projet2016\\Equipe2\\Soumission_retour";
            dr = CreateDirectory(pathRetour);
            CreateXsd(pathXsd, doc);
            //On prcoure tous les xmls contenus dans le dossier
            try
            {

                if (dr != null)
                {
                    pathRetour = dr.FullName;
                }
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
            DirectoryInfo dr = null;
            string pathAlle = "E:\\inetpub\\wwwroot\\Projet2016\\Equipe2\\Soumission_alle";
            dr = CreateDirectory(pathAlle);
            //On prcoure tous les xmls contenus dans le dossier
            try
            {
                if (dr != null)
                {
                    pathAlle = dr.FullName;
                }
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
                        LayoutController.erreur = IOEx;
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

        private tblSoumission CreateSoumission(int noAgenP, int noApp)
        {
            //if (!PermissionChecker.IsGrantedAsync("CreerSoumission").Result)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            tblSoumission soumi = provider.SleclectSoumi(noApp, noAgenP);
            if (soumi!=null)//update soumission
            {
                try
                {
                    soumi.noAgencePub = noAgenP;
                    soumi.noAppelOffre = noApp;
                    soumi.statut = null;
                    provider.Save();
                }
                catch (Exception e)
                {
                    LayoutController.erreur = e;
                }
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
            ViewBag.PeutCreerAppelOffre = PermissionChecker.IsGrantedAsync(PermissionNames.CreerAppelOffre).Result;
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

        [AbpMvcAuthorize(PermissionNames.CreerAppelOffre)]
        // GET: AppellOffre/Create
        public ActionResult Create()
        {

            ViewBag.noEvenement = new SelectList(provider.ToutEvenement().Where(e => e.datefin >= DateTime.Now), "noEvenement", "nom");
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

        private void deleteSoumission(int[] NoAgence,tblAppelOffre appel)
        {
            List<tblSoumission> listSoumi = provider.RetunSoumission(appel.noAppelOffre);
            foreach (tblSoumission s in listSoumi)
            {
                if (!NoAgence.Contains(s.noAgencePub))
                {
                    provider.SupprimerSoumission(s);
                    string filename = "E:\\inetpub\\wwwroot\\Projet2016\\Equipe2/Soumission_alle\\soumission_" + CleanFileName( appel.nom ) + "_" + CleanFileName( s.tblAgencePublicite.nom ) + ".xml";
                    provider.UpdateSoumission(s);
                    DeleteXml(filename);
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
            if (id == null)
            { 
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewBag.AllAgence = provider.ToutAgencePublicite();
            ViewBag.AgenceParAppel = provider.ReturnAgence(id);
            tblAppelOffre tblAppelOffre = provider.returnAppel(id);
            if (tblAppelOffre == null)
            {
                return HttpNotFound();
            }
            ViewBag.noEvenement = new SelectList(provider.ToutEvenement(), "noEvenement", "nom", tblAppelOffre.noEvenement);
            ViewBag.noStatut = new SelectList(provider.ToutStatutAppel(), "noStatut", "nom", tblAppelOffre.noStatut);
            ViewBag.noMedia = new SelectList(provider.ToutMedia(), "noMedia", "nom", tblAppelOffre.noMedia);
            return View(tblAppelOffre);
        }

        // POST: AppellOffre/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "noAppelOffre,nom,dateRequis,dateEnvoi,description,dateSupprime,noEvenement,noMedia")] tblAppelOffre tblAppelOffre)
        {

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
                            string filename = "E:\\inetpub\\wwwroot\\Projet2016\\Equipe2/Soumission_alle\\soumission_" + CleanFileName(tblAppelOffre.nom) + "_" + CleanFileName(s.tblAgencePublicite.nom) + ".xml";
                            provider.UpdateSoumission(s);
                            DeleteXml(filename);
                        }
                    }
                    tblAppelOffre.noStatut = provider.ReturnNoStatut("En Création");
                    tblAppelOffre.dateEnvoi = AffecterTemps(tblAppelOffre.dateEnvoi, "heureEnvoi", "minEnvoi", "secondeEnvoi");
                    tblAppelOffre.dateRequis = AffecterTemps(tblAppelOffre.dateRequis, "heureRequise", "minRequise", "secondeRequise");
                    provider.UpdateAppelOffre(tblAppelOffre);
                    return RedirectToAction("Index");
                }
                //si l'Appel d'offre n'est pas en création il tombe à envoyé.
                tblAppelOffre.noStatut = provider.ReturnNoStatut("Envoyé");
                tblAppelOffre.dateEnvoi = AffecterTemps(tblAppelOffre.dateEnvoi, "heureEnvoi", "minEnvoi", "secondeEnvoi");
                tblAppelOffre.dateRequis = AffecterTemps(tblAppelOffre.dateRequis, "heureRequise", "minRequise", "secondeRequise");
                provider.UpdateAppelOffre(tblAppelOffre);

                if (Request.Form.AllKeys.Contains("noAgencePub"))
                {
                    int[] NoAgence = Request.Form.GetValues("noAgencePub").Select(no => int.Parse(no)).ToArray();
                    //On supprime les soumissions qui ne sont plus ratachées à l'appel d'offre.
                    deleteSoumission(NoAgence, tblAppelOffre);
                    //On créer les soumissions réliées à l'appel d'offre.
                    foreach (int no in NoAgence)
                    {
                        tblSoumission soumi = CreateSoumission(no, tblAppelOffre.noAppelOffre);
                        CreateSoumissionXml(soumi, tblAppelOffre);
                    }
                }

                provider.Save();
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
                provider.UpdateAppelOffre(tblAppelOffre);
                return RedirectToAction("Index");
            }

            //On supprime toutes les soumissions réliées à cet appel d'offre
            foreach (tblSoumission soumi in provider.RetunSoumission(tblAppelOffre.noAppelOffre))
            {
                soumi.dateSupprime = DateTime.Now;
                string filename = "E:\\inetpub\\wwwroot\\Projet2016\\Equipe2/Soumission_alle\\soumission_" + CleanFileName(tblAppelOffre.nom) + "_" + CleanFileName(soumi.tblAgencePublicite.nom) + ".xml";
                provider.UpdateSoumission(soumi);
                DeleteXml(filename);
            }
            provider.UpdateAppelOffre(tblAppelOffre);
            if (tblAppelOffre == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index");
        }
        public ActionResult GetChart()
        {
            ViewBag.chart = new Chart(600, 400,ChartTheme.Green)
                .AddTitle("Montant des dons par commanditaires")
                .AddSeries(
                    chartType: "column",
                    xValue: new[] { "Platine Comunication", "Mediative", "Agence Polka", "Zed Productions" },
                    yValues: new[] { "2000", "1800", "1200", "2100" });
            return View();
        }

    }
}
