using ECJ.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECJ.Web.Controllers
{
    public class DBProvider
    {
        private static PE2_OfficielEntities db = new PE2_OfficielEntities();

        //Requête sur la table tblAppelOffre
        public List<tblSoumission> RetunSoumission(int? id)
        {
            if (id != null)
            {
               return (from soumi in db.tblSoumission
                                                join aoa in db.tblAppelOffreAgence
                                                on soumi.noSoumission equals aoa.noSoumission
                                                where aoa.noAppelOffre == id
                                                select soumi).ToList();
            }
            return null;

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


    }
}