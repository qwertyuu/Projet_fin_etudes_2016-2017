using ECJ.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECJ.Web.Controllers
{
    public class DBProvider
    {
        private static PE2_OfficielEntities db;

        public DBProvider()
        {
            if (db == null)
            {
                db = new PE2_OfficielEntities();
            }
        }

        //Requête sur la table tblAppelOffre
        public List<tblSoumission> RetunSoumission(int? id)
        {
            if (id != null)
            {
               return (from soumi in db.tblSoumission
                                                join aoa in db.tblAppelOffreAgence
                                                on soumi.offreNoPublicite equals aoa.offreNoPublicite
                                                where aoa.noAppelOffre == id
                                                select soumi).ToList();
            }
            return null;

        }

        internal void InsertServiceRequis(int id, int serviceAAjouter)
        {
            db.tblSousEvenement.Find(id).tblService.Add(db.tblService.Find(serviceAAjouter));
            db.SaveChanges();
        }

        internal void SupprimerServiceRequis(int id, int serviceASupprimer)
        {
            db.tblSousEvenement.Find(id).tblService.Remove(db.tblService.Find(serviceASupprimer));
            db.SaveChanges();
        }

        internal void LierForfait(int id, int forfaitALier)
        {
            db.tblSousEvenement.Find(id).tblForfait.Add(db.tblForfait.Find(forfaitALier));
            db.SaveChanges();
        }

        internal void DelierForfait(int id, int forfaitASupprimer)
        {
            db.tblSousEvenement.Find(id).tblForfait.Remove(db.tblForfait.Find(forfaitASupprimer));
            db.SaveChanges();
        }

        internal List<tblService> ToutService()
        {
            return db.tblService.ToList();
        }

        internal void LierSalle(int id, int salle_id)
        {
            db.tblSousEvenement.Find(id).tblSalle = db.tblSalle.Find(salle_id);
            db.SaveChanges();
        }

        internal List<tblForfait> ToutForfait()
        {
            return db.tblForfait.ToList();
        }

        internal void DelierSalle(int id, int salle_id)
        {
            db.tblSousEvenement.Find(id).tblSalle = null;
            db.SaveChanges();
        }

        internal List<tblEngagement> ToutEngagement()
        {
            return db.tblEngagement.ToList();
        }

        internal void LierEngagement(int id, int engagement_id)
        {
            db.tblSousEvenement.Find(id).tblEngagement.Add(db.tblEngagement.Find(engagement_id));
            db.SaveChanges();
        }

        internal List<tblSalle> ToutSalle()
        {
            return db.tblSalle.ToList();
        }

        internal void DelierEngagement(int id, int engagement_id)
        {
            db.tblSousEvenement.Find(id).tblEngagement.Remove(db.tblEngagement.Find(engagement_id));
            db.SaveChanges();
        }

        public List<tblAgencePublicite> ReturnAgence(int? id)
        {
            if (id != null)
            {
               return  (from ag in db.tblAgencePublicite
                                       join aoa in db.tblAppelOffreAgence
                                       on ag.noAgencePub equals aoa.noAgencePub
                                       where aoa.noAppelOffre == id
                                       select ag).ToList();

            }
            else
            {
               return (from ag in db.tblAgencePublicite
                                       select ag).ToList();
            }

        }

        public void InsertSoumission(tblSoumission soumi)
        {
            db.tblSoumission.Add(soumi);
            db.SaveChanges();
        }

        public void InsertActivite(tblActivite _acti)
        {
            db.tblActivite.Add(_acti);
            db.SaveChanges();
        }
        public void InsertSousEvenement(tblSousEvenement _sousEvenement)
        {
            db.tblSousEvenement.Add(_sousEvenement);
            db.SaveChanges();
        }

        public tblSousEvenement FindSousEvenement(int id)
        {
            return db.tblSousEvenement.Find(id);
        }

    }
}