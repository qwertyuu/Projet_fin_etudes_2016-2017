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

        public Modele.tblContrat SelectContrat(string idContrat)
        {
            return BD.tblContrat.SingleOrDefault(a => a.noContrat == idContrat);
        }

        internal tblResponsable SelectResponsableAgence(string idContrat)
        {
            var contrat = SelectContrat(idContrat);
            if (contrat == null || contrat.tblResponsable.Count == 0)
            {
                return null;
            }
            return contrat.tblResponsable.SingleOrDefault(a => a.noAgence != null && a.dateSupprime == null);
        }

        internal void SupprimerBDEngagement(vueSomEngagement engagement)
        {
            BD.tblEngagement.Remove(BD.tblEngagement.SingleOrDefault(e => e.noEngagement == engagement.noEngagement));
        }

        internal void SupprimerBDExigence(vueSomExigence exigence)
        {
            BD.tblExigence.Remove(BD.tblExigence.SingleOrDefault(e => e.noExigence == exigence.noExigence));
        }

        internal tblResponsable SelectResponsableDiffuseur(string idContrat)
        {
            var contrat = SelectContrat(idContrat);
            if (contrat == null)
            {
                return null;
            }
            return contrat.tblResponsable.SingleOrDefault(a => a.noDiffuseur != null && a.dateSupprime == null);
        }

        public tblStatut SelectStatut(string nom)
        {
            return BD.tblStatut.SingleOrDefault(s=>s.nomStatut == nom && s.dateSupprime == null && s.noStatut <= 6);
        }

        public List<Modele.vueSomStatut> ToutVueStatus()
        {
            return BD.vueSomStatut.AsNoTracking().ToList();
        }

        public DBProvider()
        {
            if(BD == null)
            {
                BD = new Modele.PE2_OfficielEntities();
            }
        }

        public tblArtiste SelectArtiste(int idArtiste)
        {
            return BD.tblArtiste.SingleOrDefault(a => a.noArtiste == idArtiste && a.dateSupprime == null);
        }

        public List<tblStatut> ToutStatut()
        {
            return BD.tblStatut.ToList();
        }

        public tblAgence SelectAgence(string _noAgence)
        {
            return BD.tblAgence.SingleOrDefault(a => a.noAgence == _noAgence);
        }

        public void InsertArtiste(tblArtiste artiste)
        {
            BD.tblArtiste.Add(artiste);
            BD.SaveChanges();
        }

        public void InsertCatArtiste(tblCategorieArtiste catArt)
        {
            BD.tblCategorieArtiste.Add(catArt);
            BD.SaveChanges();
        }
        public void InsertContrat(tblContrat contrat)
        {
            BD.tblContrat.Add(contrat);
            BD.SaveChanges();
        }

        public List<tblArtiste> ToutArtiste()
        {
            return BD.tblArtiste.ToList();
        }

        internal bool PhotoOfficielleExiste(tblFichierOfficiel i)
        {
            return BD.tblFichierOfficiel.Any(a => a.noArtiste == i.noArtiste && a.noContrat == i.noContrat && a.noFichier == i.noFichier);
        }

        public tblEngagement SelectEngagement(int idEngagement)
        {
            return BD.tblEngagement.SingleOrDefault(a => a.noEngagement == idEngagement && a.dateSupprime == null);
        }

        public List<Modele.tblFichierPersonnel> ToutFichierPersonnel()
        {
            return BD.tblFichierPersonnel.Where(a => a.dateSupprime == null).ToList();
        }

        public void SupprimerArtiste(int idartiste)
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

        public List<Modele.tblFichierOfficiel> PhotoOfficielArtiste(int noArtiste)
        {
            return BD.tblFichierOfficiel.Where(a => a.noArtiste == noArtiste && a.tblFichierPersonnel.dateSupprime == null).ToList();
        }

        public tblStatut SelectStatut(int idStatut)
        {
            return BD.tblStatut.SingleOrDefault(a => a.noStatut == idStatut);
        }

        public tblCategorieArtiste selectCatArt(int id)
        {
            return BD.tblCategorieArtiste.SingleOrDefault(catArt => catArt.noCategorie == id && catArt.dateSupprime==null);
        }



        public int ReturnNbreCat()
        {
            int nbre=0;
            var query = (from q in BD.tblCategorieArtiste
                        where q.dateSupprime==null
                        select q).ToList();

            foreach(var q in query)
            {
                nbre++;
            }

            return nbre;

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

        public void InsertFichierPersonnel(tblFichierPersonnel item)
        {
            BD.tblFichierPersonnel.Add(item);
        }

        //-----Requête sur la table Agence----
        public void InsertAgence(Modele.tblAgence agence)
        {
            BD.tblAgence.Add(agence);
            BD.SaveChanges();
        }
        public void InsertResponsable(Modele.tblResponsable respo)
        {
            BD.tblResponsable.Add(respo);
            BD.SaveChanges();
        }

        public tblExigence SelectExigence(int idExigence)
        {
            return BD.tblExigence.SingleOrDefault(a => a.noExigence == idExigence && a.dateSupprime == null);
        }

        public void InsertFichierOfficiel(tblFichierOfficiel item)
        {
            BD.tblFichierOfficiel.Add(item);
            BD.SaveChanges();
        }

        public void SupprimerExigence(int idExigence)
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
            BD.SaveChanges();
        }

        public void SupprimerEngagement(int idEngagement)
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


        public void SupprimerCatArtiste(int no)
        {
            var query = from q in BD.tblCategorieArtiste
                        where q.noCategorie == no
                        select q;
            if (query != null)
            {
                foreach (Modele.tblCategorieArtiste q in query)
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
            return (from item in BD.vueSomAgence.AsNoTracking()
                   select item).ToList();
        }

        public List<Modele.vueSomArtiste> ToutVueArtiste()
        {
            return BD.vueSomArtiste.AsNoTracking().GroupBy(a => a.noArtiste.ToString()).Select(grp => grp.FirstOrDefault()).ToList();
        }

        public List<Modele.vueSomCatArtiste> ToutVueCategorieArtiste()
        {
            return (from item in BD.vueSomCatArtiste.AsNoTracking()
                   select item).ToList();
        }

        public List<Modele.vueSomContrat> ToutVueContrats()
        {
            return (from item in BD.vueSomContrat.AsNoTracking()
                   select item).ToList();
        }

        public void SupprimerFichier(tblFichierPersonnel item)
        {
            item.dateSupprime = DateTime.Now;
            BD.SaveChanges();
        }

        internal List<Modele.vueSomEngagement> ToutEngagement()
        {
            return BD.vueSomEngagement.AsNoTracking().ToList();
        }

        internal List<Modele.vueSomExigence> ToutExigence()
        {
            return BD.vueSomExigence.AsNoTracking().ToList();
        }
    }
}
