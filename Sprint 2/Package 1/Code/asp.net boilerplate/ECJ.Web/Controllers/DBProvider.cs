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

        internal List<tblService> ToutService()
        {
            return db.tblService.ToList();
        }

        internal List<tblForfait> ToutForfait()
        {
            return db.tblForfait.ToList();
        }

        internal List<tblEngagement> ToutEngagement()
        {
            return db.tblEngagement.ToList();
        }

        internal List<tblSalle> ToutSalle()
        {
            return db.tblSalle.ToList();
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