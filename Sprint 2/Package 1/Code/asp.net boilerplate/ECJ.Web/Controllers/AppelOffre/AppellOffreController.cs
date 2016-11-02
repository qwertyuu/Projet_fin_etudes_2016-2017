using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ECJ.Web.Models;
using System.Xml.Serialization;
using System.Xml;
using System.Data.SqlClient;
using System.IO;

namespace ECJ.Web.Controllers.AppelOffre
{
    public class AppellOffreController : ECJControllerBase
    {
        private PE2_OfficielEntities db = new PE2_OfficielEntities();
        SqlConnection conn = new SqlConnection();
        private DBProvider provider = new DBProvider();
        int CptSoumi = 0;
        DataSet ds = new DataSet();

        public AppellOffreController()
        {

        }

       
        //--Gestion de la création du xml d'une soumision.-----
        public XmlNode CrerUneSoumissionXml(XmlDocument doc, tblSoumission soumi, tblAppelOffre appelOffre)
        {
            XmlNode xmlnoSoumi = doc.CreateNode(XmlNodeType.Element, "NoSoumission", "");
            xmlnoSoumi.InnerText = soumi.noSoumission.ToString();
            XmlNode xmlNom = doc.CreateNode(XmlNodeType.Element, "Nom", "");
            xmlNom.InnerText = appelOffre.nom;
            XmlNode xmlNoSoumiAgence = doc.CreateNode(XmlNodeType.Element, "noSoumissionAgence", "");
            xmlNom.InnerText = soumi.noSoumissionAgence;
            XmlNode xmlPrix = doc.CreateNode(XmlNodeType.Element, "Prix", "");
            xmlPrix.InnerText = soumi.prix.ToString();
            XmlNode xmlnoAgencePub = doc.CreateNode(XmlNodeType.Element, "noAgencePub", "");
            xmlnoAgencePub.InnerText = soumi.noAgencePub.ToString();
            XmlNode xmlnoAppelOffre = doc.CreateNode(XmlNodeType.Element, "noAppelOffre", "");
            xmlnoAppelOffre.InnerText = soumi.noAppelOffre.ToString();
            XmlNode xmlStatut = doc.CreateNode(XmlNodeType.Element, "Statut", "");     
             xmlStatut.InnerText = soumi.statut.ToString();
            XmlNode xmlCommentaire = doc.CreateNode(XmlNodeType.Element, "Commentaire", "");
            xmlCommentaire.InnerText = soumi.commentaire;
            XmlNode xmlSoumission = doc.CreateNode(XmlNodeType.Element, "Soumission", "http://tempuri.org/SoumissionAgence.xsd");

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

        private void CreateSoumissionXml(tblSoumission soumi,tblAppelOffre appelOffre)
        {
            CptSoumi++;
            XmlDocument doc = new XmlDocument();
            XmlNode Racine = doc.CreateNode(XmlNodeType.Element, "SoumissionAgence", "http://tempuri.org/SoumissionAgence.xsd");
            doc.AppendChild(Racine);
            Racine.AppendChild(CrerUneSoumissionXml(doc, soumi, appelOffre));
            try
            {
                string filename = "//deptinfo420/P2016_Equipe2/Soumission_alle/soumission" + appelOffre.nom + CptSoumi +".xml";
                doc.Save(filename);

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
                    XmlNode racine = doc.SelectSingleNode("SoumissionAgence");
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
            }





        }

        private tblSoumission CreateSoumission(string nomSoumi,int noAgenP, int noApp)
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
                var soumission = new tblSoumission { noAgencePub = noAgenP, noAppelOffre = noApp, statut=null, };
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

            //Retourner les soumission du xml vers la bad
            RetournerSoumissionXml();

            if(Request.Form.Get("nomAppellOffre")!=null)
            {
                appelGoupBy = appelGoupBy.OrderByDescending(a => a.nomAppelOffre);
            }
            
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
            tblAppelOffre tblAppelOffre = db.tblAppelOffre.Find(id);
            if (tblAppelOffre == null)
            {
                return HttpNotFound();
            }
            return View(tblAppelOffre);
        }

        // GET: AppellOffre/Create
        public ActionResult Create()
        {

            ViewBag.noEvenement = new SelectList(db.tblEvenement, "noEvenement", "nom");
            ViewBag.noStatut = new SelectList(db.tblStatutAppelOffre, "noStatut", "nom");
            ViewBag.noMedia = new SelectList(db.tblMedia, "noMedia", "nom");
            ViewBag.noAgencePub = new MultiSelectList(db.tblAgencePublicite, "noAgencePub", "nom");
            return View();
        }

        // POST: AppellOffre/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "noAppelOffre,nom,dateRequis,dateEnvoi,description,dateSupprime,noEvenement,noMedia")] tblAppelOffre tblAppelOffre, int[] noAgencePub)
        {
            string nomSoumoi = "";
            List<int> idSelect = new List<int>();
            ViewBag.noAgencePub = new MultiSelectList(db.tblAgencePublicite, "noAgencePub", "nom",idSelect);
            
            if (ModelState.IsValid)
            {
                var statut = (from q in db.tblStatutAppelOffre
                              where q.noStatut == tblAppelOffre.noStatut
                              select q).FirstOrDefault();
                var evenement = (from q in db.tblEvenement
                                 where q.noEvenement == tblAppelOffre.noEvenement
                                 select q).FirstOrDefault();
                var media = (from q in db.tblMedia
                                 where q.noMedia == tblAppelOffre.noMedia
                                 select q).FirstOrDefault();

                db.tblAppelOffre.Add(tblAppelOffre);
                if(Request.Form.Get("save")== "Save")
                {
                    tblAppelOffre.noStatut = db.tblStatutAppelOffre.Where(s => s.nom == "En Création").FirstOrDefault().noStatut;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                //si l'Appel d'offre n'est pas en création il tombe à envoyé.
                tblAppelOffre.noStatut = db.tblStatutAppelOffre.Where(s => s.nom == "Envoyé").FirstOrDefault().noStatut;
                db.SaveChanges();

                //On créer les soumissions réliées à l'appel d'offre.

                //On ouvre la connection
                //provider.ConnectionServer(conn);
                foreach (int no in noAgencePub)
                {
                    tblSoumission lastSoumi = db.tblSoumission.ToList().LastOrDefault();
                    nomSoumoi = "Soumission" + (lastSoumi.noSoumission + 1);
                    tblSoumission souimi= CreateSoumission(nomSoumoi, no,tblAppelOffre.noAppelOffre);
                    CreateSoumissionXml(souimi, tblAppelOffre);
                }
               // conn.Close(); //On ferme la connection.
                return RedirectToAction("Index");
            }

            ViewBag.noEvenement = new SelectList(db.tblEvenement, "noEvenement", "nom", tblAppelOffre.noEvenement);
            ViewBag.noStatut = new SelectList(db.tblStatutAppelOffre, "noStatut", "nom", tblAppelOffre.noStatut);
            ViewBag.noMedia = new SelectList(db.tblMedia, "noMedia", "nom",tblAppelOffre.noMedia);
            ViewBag.noAgencePub = new MultiSelectList(db.tblAgencePublicite, "noAgencePub", "nom");
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
            tblAppelOffre tblAppelOffre = db.tblAppelOffre.Find(id);
            if (tblAppelOffre == null)
            {
                return HttpNotFound();
            }
            ViewBag.noEvenement = new SelectList(db.tblEvenement, "noEvenement", "nom", tblAppelOffre.noEvenement);
            ViewBag.noStatut = new SelectList(db.tblStatutAppelOffre, "noStatut", "nom", tblAppelOffre.noStatut);
            ViewBag.noMedia = new SelectList(db.tblMedia, "noMedia", "nom", tblAppelOffre.noMedia);
            ViewBag.noAgencePub = new MultiSelectList(db.tblAgencePublicite, "noAgencePub", "nom", noAgence);
            return View(tblAppelOffre);
        }

        // POST: AppellOffre/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "noAppelOffre,nom,dateRequis,dateEnvoi,description,dateSupprime,noEvenement,noMedia")] tblAppelOffre tblAppelOffre, int[] noAgencePub)
        {
            string nomSoumi = "";
            if (ModelState.IsValid)
            {
                var statut =( from q in db.tblStatutAppelOffre
                              where q.noStatut == tblAppelOffre.noStatut
                             select q).FirstOrDefault();
                var evenement = (from q in db.tblEvenement
                              where q.noEvenement == tblAppelOffre.noEvenement
                              select q).FirstOrDefault();
                var media = (from q in db.tblMedia
                             where q.noMedia == tblAppelOffre.noMedia
                             select q).FirstOrDefault();
                db.Entry(tblAppelOffre).State = EntityState.Modified;
                db.SaveChanges();
                //On créer les soumissions réliées à l'appel d'offre.
                foreach (int no in noAgencePub)
                {
                    tblSoumission lastSoumi = db.tblSoumission.Last();
                    nomSoumi = "Soumission" + lastSoumi.noSoumission + 1;
                    CreateSoumission(nomSoumi,no, tblAppelOffre.noAppelOffre);
                }
                return RedirectToAction("Index");
            }
            ViewBag.noEvenement = new SelectList(db.tblEvenement, "noEvenement", "nom", tblAppelOffre.noEvenement);
            ViewBag.noStatut = new SelectList(db.tblStatutAppelOffre, "noStatut", "nom", tblAppelOffre.noStatut);
            ViewBag.noMedia = new SelectList(db.tblMedia, "noMedia", "nom", tblAppelOffre.noMedia);
            ViewBag.noAgencePub = new SelectList(db.tblAgencePublicite, "noAgencePub", "nom");
            return View(tblAppelOffre);
        }

        // GET: AppellOffre/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblAppelOffre tblAppelOffre = db.tblAppelOffre.Find(id);
            if(tblAppelOffre.noStatut== db.tblStatutAppelOffre.Where(s => s.nom == "En Création").FirstOrDefault().noStatut) //Statut en création on supprime l'appel d'offre.
            {
               tblAppelOffre.dateSupprime = DateTime.Now;
            }
            else
            {
                tblAppelOffre.noStatut = db.tblStatutAppelOffre.Where(s => s.nom == "Annulé").FirstOrDefault().noStatut;
            }

            //On supprime toutes les soumissions réliées à cet appel d'offre
            foreach (tblSoumission soumi in provider.RetunSoumission(tblAppelOffre.noAppelOffre))
            {
                soumi.dateSupprime = DateTime.Now;
            }
            db.SaveChanges();
            if (tblAppelOffre == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
