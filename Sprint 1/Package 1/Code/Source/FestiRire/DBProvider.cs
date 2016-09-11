using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using FestiRire.Modele;

namespace FestiRire
{
    class DBProvider
    {
        private static Modele.PE2_OfficielEntities BD;
        public DBProvider()
        {
            if(BD == null)
            {
                BD = new Modele.PE2_OfficielEntities();
            }
        }

        public List<tblStatut> ToutStatus()
        {
            return BD.tblStatut.ToList();
        }

        public tblAgence SelectAgence(string _noAgence)
        {
            return BD.tblAgence.SingleOrDefault(a => a.noAgence == _noAgence && a.dateSupprime == null);
        }

        public tblEngagement SelectEngagement(int idEngagement)
        {
            return BD.tblEngagement.SingleOrDefault(a => a.noEngagement == idEngagement && a.dateSupprime == null);
        }


        //-----Requête sur la table Agence----
        public void InsertAgence(Modele.tblAgence agence)
        {
            BD.tblAgence.Add(agence);
            BD.SaveChanges();
        }


        public void SupprimerAgence(string no)
        {
            var query = from q in BD.tblAgence
                        where q.noAgence == no
                        select q;
            if (query != null)
            {
                foreach (Modele.tblAgence q in query)
                {
                    q.dateSupprime = DateTime.Now;
                }
            }

            BD.SaveChanges();
        }


        public void InsertEngagement(tblEngagement tE)
        {
            BD.tblEngagement.Add(tE);
            BD.SaveChanges();

        }

        //-----Requête sur la table adresse----
        public void InsertAdresse(Modele.tblAdresse adresse)
        {
            BD.tblAdresse.Add(adresse);
            BD.SaveChanges();
        }

        public void Save()
        {
            BD.SaveChanges();
        }

        //---Requête sur la table Artiste----//
        //Retourne la liste des catégories d'artistes dans la bd.
        public List<Modele.tblCategorieArtiste> ReturnAllCatArtiste()
        {

            return (from q in BD.tblCategorieArtiste
                    where q.dateSupprime == null
                    select q
                    ).ToList();

        }

        //---Requête sur la table Contrat----//

        public List<Modele.tblContrat> ToutContratTerminé()
        {

            return (from q in BD.tblContrat
                    where q.dateSupprime == null && q.tblStatut.nomStatut=="Terminé"
                    select q
                    ).ToList();

        }

        public List<Modele.vueSomAgence> ToutVueAgence()
        {
            return (from item in BD.vueSomAgence
                   select item).ToList();
        }

        public List<Modele.vueSomArtiste> ToutVueArtiste()
        {
            return (from item in BD.vueSomArtiste
                   select item).ToList();
        }

        public List<Modele.vueSomCatArtiste> ToutVueCategorieArtiste()
        {
            return (from item in BD.vueSomCatArtiste
                   select item).ToList();
        }

        public List<Modele.vueSomContrat> ToutVueContrats()
        {
            return (from item in BD.vueSomContrat
                   select item).ToList();
        }
    }
}
