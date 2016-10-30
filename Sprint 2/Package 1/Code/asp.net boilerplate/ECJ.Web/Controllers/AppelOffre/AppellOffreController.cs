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

namespace ECJ.Web.Controllers.AppelOffre
{
    public class AppellOffreController : Controller
    {
        private PE2_OfficielEntities db = new PE2_OfficielEntities();
        SqlConnection conn = new SqlConnection();
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
            string filename = "//deptinfo420/P2016_Equipe2/Soumission_alle/soumission" + soumi.noSoumission + ".xml";
            doc.Save(filename);
        }

        private void RetournerSoumissionXml(string nomSoumiXml)
        {
            List<tblSoumission> list = new List<tblSoumission>();
            
            XmlDocument doc = new XmlDocument();
            doc.Load(nomSoumiXml);
            XmlTextReader reader = new XmlTextReader(nomSoumiXml);
            while(reader.Read())
            {
                tblSoumission soumi = new tblSoumission
                {
                    noSoumission = Convert.ToInt32(reader.Value),
                    noSoumissionAgence = reader.Value,
                    nom = reader.Value,
                    statut = Convert.ToBoolean(reader.Value),
                    noAgencePub = Convert.ToInt32(reader.Value)
                };
            }



        }

        private tblSoumission CreateSoumission(string nomSoumi,int noAgenP, int noApp, int noSat)
        {
            tblSoumission soumi = provider.SleclectSoumi(noApp, noAgenP);
            if (soumi!=null)//update soumission
            {
                soumi.noAgencePub = noAgenP;
                soumi.noAppelOffre = noApp;
                soumi.noStatut = noSat;
                soumi.nom = nomSoumi;
                provider.Save();
                return soumi;
            }
            else
            {
                var soumission = new tblSoumission {nom=nomSoumi, noAgencePub = noAgenP, noAppelOffre = noApp, noStatut = noSat };
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

            var appelGoupBy = appelOfrre.GroupBy(aoa => new { aoa.noAppelOffre, aoa.nomAppelOffre, aoa.nomEvent, aoa.noStatut, aoa.description, aoa.dateEnvoi, aoa.dateRequis, aoa.couleur }).ToList()
                         .Select(a => new vueSomAppelOffre
                         {
                             noAppelOffre = a.Key.noAppelOffre,
                             nomAppelOffre = a.Key.nomAppelOffre,
                             nomEvent = a.Key.nomEvent,
                             noStatut = a.Key.noStatut,
                             nomSoumission = string.Join(",\n", db.vueSomAppelOffre.Where(j => j.noAppelOffre == a.Key.noAppelOffre).Select(i => i.nomSoumission)),
                             description = a.Key.description,
                             nomAgence = string.Join(",\n", db.vueSomAppelOffre.Where(j => j.noAppelOffre == a.Key.noAppelOffre).Select(i => i.nomAgence)),
                             dateRequis = a.Key.dateRequis,
                             dateEnvoi = a.Key.dateEnvoi,
                             couleur = a.Key.couleur
                         }).OrderBy(a => a.noStatut);
            
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
        [mult]
        public ActionResult Create([Bind(Include = "noAppelOffre,nom,dateRequis,dateEnvoi,description,dateSupprime,noEvenement,noMedia")] tblAppelOffre tblAppelOffre, int[] noAgencePub, FormCollection form)
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
                if(form["Sauvegarder"] !=null)
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
                    tblSoumission souimi= CreateSoumission(nomSoumoi, no,tblAppelOffre.noAppelOffre,tblAppelOffre.noStatut);
                    CreateSoumissionXml(souimi);
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
                    CreateSoumission(nomSoumi,no, tblAppelOffre.noAppelOffre, tblAppelOffre.noStatut);
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
