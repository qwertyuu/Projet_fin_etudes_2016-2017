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

namespace ECJ.Web.Controllers.AppelOffre
{
    public class AppellOffreController : Controller
    {
        private PE2_OfficielEntities db = new PE2_OfficielEntities();
        private DBProvider provider = new DBProvider();
        DataSet ds = new DataSet();

        public AppellOffreController()
        {

        }

        //--Gestion de la création du xml d'une soumision.-----
        public XmlNode CrerUneSoumissionXml(XmlDocument doc, tblSoumission soumi)
        {
            XmlNode xmlnoSoumi = doc.CreateNode(XmlNodeType.Element, "NoSoumission", "");
            xmlnoSoumi.InnerText = soumi.noSoumission.ToString();
            XmlNode xmlNom = doc.CreateNode(XmlNodeType.Element, "Nom", "");
            xmlNom.InnerText = soumi.nom;
            XmlNode xmlNoSoumiAgence = doc.CreateNode(XmlNodeType.Element, "noSoumissionAgence", "");
            xmlNom.InnerText = soumi.noSoumissionAgence;
            XmlNode xmlPrix = doc.CreateNode(XmlNodeType.Element, "Prix", "");
            xmlPrix.InnerText = soumi.prix.ToString();
            XmlNode xmlnoAgencePub = doc.CreateNode(XmlNodeType.Element, "noAgencePub", "");
            xmlnoAgencePub.InnerText = soumi.noAgencePub.ToString();
            XmlNode xmlnoAppelOffre = doc.CreateNode(XmlNodeType.Element, "noAppelOffre", "");
            xmlnoAppelOffre.InnerText = soumi.noAppelOffre.ToString();
            XmlNode xmlStatut = doc.CreateNode(XmlNodeType.Element, "Statut", "");
            if(soumi.statut)
               xmlStatut.InnerText = "Acceptée";
            else
                xmlStatut.InnerText = "Réfusée";

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

        private void CreateSoumissionXml(tblSoumission soumi)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode Racine = doc.CreateNode(XmlNodeType.Element, "SoumissionAgence", "");
            doc.AppendChild(Racine);
            Racine.AppendChild(CrerUneSoumissionXml(doc, soumi));
            string filename = "//deptinfo420/P2016_Equipe2/soumission" + soumi.noSoumission + ".xml";
            doc.Save(filename);
        }

        private tblSoumission CreateSoumission(int noAgenP, int noApp, int noSat)
        {
            tblSoumission soumi = provider.SleclectSoumi(noApp, noAgenP);
            if (soumi!=null)//update soumission
            {
                soumi.noAgencePub = noAgenP;
                soumi.noAppelOffre = noApp;
                soumi.noStatut = noSat;
                provider.Save();
                return soumi;
            }
            else
            {
                var soumission = new tblSoumission { noAgencePub = noAgenP, noAppelOffre = noApp, noStatut = noSat };
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
                        (a.nomSoumission ?? "").ToString().ToUpper().Contains(SearchString) || 
                        (a.description ?? "").ToString().ToUpper().Contains(SearchString));
                }

            }
            appelOfrre = from q in appelOfrre
                         orderby q.noStatut
                         select q;

            var appelGoupBy = appelOfrre.GroupBy(aoa => new { aoa.noAppelOffre,aoa.nomAppelOffre,aoa.nomAgence,aoa.nomEvent,aoa.nomStatut,aoa.nomSoumission,aoa.description })
                         .Select(a => new {a.Key.nomAppelOffre,a.Key.nomAgence,a.Key.nomEvent,a.Key.nomStatut,a.Key.nomSoumission,a.Key.description});

            
            

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
        public ActionResult Create([Bind(Include = "noAppelOffre,nom,dateRequis,dateEnvoi,description,dateSupprime,noEvenement,noStatut,noMedia")] tblAppelOffre tblAppelOffre, int[] noAgencePub)
        {
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
                db.SaveChanges();
                //On créer les soumissions réliées à l'appel d'offre.
                foreach(int no in noAgencePub)
                {
                    tblSoumission souimi= CreateSoumission(no,tblAppelOffre.noAppelOffre,tblAppelOffre.noStatut);
                    CreateSoumissionXml(souimi);
                }
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
        public ActionResult Edit([Bind(Include = "noAppelOffre,nom,dateRequis,dateEnvoi,description,dateSupprime,noEvenement,noStatut,noMedia")] tblAppelOffre tblAppelOffre, int[] noAgencePub)
        {
          
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
                    CreateSoumission(no, tblAppelOffre.noAppelOffre, tblAppelOffre.noStatut);
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
            if (tblAppelOffre == null)
            {
                return HttpNotFound();
            }
            return View(tblAppelOffre);
        }

        // POST: AppellOffre/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblAppelOffre tblAppelOffre = db.tblAppelOffre.Find(id);
            tblAppelOffre.dateSupprime = DateTime.Now;
           // db.tblAppelOffre.Remove(tblAppelOffre);
            db.SaveChanges();
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
