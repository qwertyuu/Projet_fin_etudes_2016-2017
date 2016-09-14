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

        public tblArtiste SelectArtiste(int idArtiste)
        {
            return BD.tblArtiste.SingleOrDefault(a => a.noArtiste == idArtiste);
        }

        public List<tblStatut> ToutStatus()
        {
            return BD.tblStatut.ToList();
        }

        public tblAgence SelectAgence(string _noAgence)
        {
            return BD.tblAgence.SingleOrDefault(a => a.noAgence == _noAgence && a.dateSupprime == null);
        }

        internal void InsertArtiste(tblArtiste artiste)
        {
            BD.tblArtiste.Add(artiste);
            BD.SaveChanges();
        }

        internal List<tblArtiste> ToutArtiste()
        {
            return BD.tblArtiste.ToList();
        }

        public tblEngagement SelectEngagement(int idEngagement)
        {
            return BD.tblEngagement.SingleOrDefault(a => a.noEngagement == idEngagement && a.dateSupprime == null);
        }

        internal List<Modele.tblFichierPersonnel> ToutFichierPersonnel()
        {
            return BD.tblFichierPersonnel.Where(a => a.dateSupprime == null).ToList();
        }

        internal void SupprimerArtiste(int idartiste)
        {
            var query = from q in BD.tblArtiste
                        where q.noArtiste == idartiste
                        select q;
            if (query != null)
            {
                foreach (var q in query)
                {
                    q.dateSupprime = DateTime.Now;
                }
            }
            BD.SaveChanges();
        }

        internal List<Modele.tblFichierOfficiel> PhotoOfficielArtiste(int noArtiste)
        {
            return BD.tblFichierOfficiel.Where(a => a.noArtiste == noArtiste && a.tblFichierPersonnel.dateSupprime == null).ToList();
        }

        public tblStatut SelectStatut(int idStatut)
        {
            return BD.tblStatut.SingleOrDefault(a => a.noStatut == idStatut);
        }

        //--Requête sur le table utilisateur----
        public bool Authentifier(string id, string motPasse)
        {
            bool UserTrouver = false;
            var query = (from q in BD.tblUtilisateur
                         where q.IdUser == id && q.motPasse == motPasse
                         select q).ToList();

            if (query.Count == 1) //utlisateur trouvé
                UserTrouver = true;
            return UserTrouver;

        }
        
        internal void InsertFichierPersonnel(tblFichierPersonnel item)
        {
            BD.tblFichierPersonnel.Add(item);
        }

        //-----Requête sur la table Agence----
        public void InsertAgence(Modele.tblAgence agence)
        {
            BD.tblAgence.Add(agence);
            BD.SaveChanges();
        }

        internal tblExigence SelectExigence(int idExigence)
        {
            return BD.tblExigence.SingleOrDefault(a => a.noExigence == idExigence && a.dateSupprime == null);
        }

        internal void InsertFichierOfficiel(tblFichierOfficiel item)
        {
            BD.tblFichierOfficiel.Add(item);
            BD.SaveChanges();
        }

        internal void SupprimerExigence(int idExigence)
        {
            var query = from q in BD.tblExigence
                        where q.noExigence == idExigence
                        select q;
            if (query != null)
            {
                foreach (Modele.tblExigence q in query)
                {
                    q.dateSupprime = DateTime.Now;
                }
            }
        }

        internal void SupprimerEngagement(int idEngagement)
        {
            var query = from q in BD.tblEngagement
                        where q.noEngagement == idEngagement
                        select q;
            if (query != null)
            {
                foreach (var q in query)
                {
                    q.dateSupprime = DateTime.Now;
                }
            }
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
        public void SupprimerStatut(int no)
        {
            var query = from q in BD.tblStatut
                        where q.noStatut == no
                        select q;
            if (query != null)
            {
                foreach (Modele.tblStatut q in query)
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

        public void InsertExigence(tblExigence exigence)
        {
            BD.tblExigence.Add(exigence);
            BD.SaveChanges();

        }

        //-----Requête sur la table adresse----
        public void InsertAdresse(Modele.tblAdresse adresse)
        {
            BD.tblAdresse.Add(adresse);
            BD.SaveChanges();
        }

        //-----Requête sur la table Statut----
        public void InsertStatut(Modele.tblStatut statut)
        {
            BD.tblStatut.Add(statut);
            BD.SaveChanges();
        }

        public void Save()
        {
            BD.SaveChanges();
        }

        //---Requête sur la table Artiste----//
        //Retourne la liste des catégories d'artistes dans la bd.
        public List<Modele.tblCategorieArtiste> ToutCatArtiste()
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

        public List<Modele.tblContrat> ToutContrat()
        {

            return (from q in BD.tblContrat
                    where q.dateSupprime == null
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
            return BD.vueSomArtiste.GroupBy(a => a.noArtiste.ToString()).Select(grp => grp.FirstOrDefault()).ToList();
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

        internal void SupprimerFichier(tblFichierPersonnel item)
        {
            item.dateSupprime = DateTime.Now;
            BD.SaveChanges();
        }
    }
}
