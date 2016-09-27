using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestiRire.Modele;

namespace FestiRire.Controleur.Details
{
    class DetailArtiste : DetailBaseSimple
    {

        public List<Modele.tblCategorieArtiste> ChargerListCatArtis(int idArtiste)
        {
            return provider.SelectArtiste(idArtiste).tblCategorieArtiste.ToList();
        }

        public List<Modele.tblContrat> ChargerContrat()
        {
            return provider.ToutContrat();
        }

        public List<Modele.tblArtiste> Tout()
        {
            return provider.ToutArtiste();
        }

        public int AjouterArtiste(string nomArt, List<Modele.tblCategorieArtiste> cat, string com)
        {
            var artiste = new Modele.tblArtiste { nom = nomArt, tblCategorieArtiste = cat, commentaire = com };
            provider.InsertArtiste(artiste);
            return artiste.noArtiste;
        }

        public void AjouterArtiste(int noArtiste, string nomArt, ICollection<Modele.tblCategorieArtiste> cat, string com)
        {
            var artiste = provider.SelectArtiste(noArtiste);
            artiste.nom = nomArt;
            artiste.tblCategorieArtiste = cat;
            artiste.commentaire = com;
        }

        internal List<Modele.tblFichierPersonnel> Fiches(int noArtiste)
        {
            return provider.ToutFichierPersonnel().Where(a => a.type == "Fiche" && a.noArtiste == noArtiste).ToList();
        }

        internal List<Modele.tblFichierPersonnel> Photos(int noArtiste)
        {
            return provider.PhotoOfficielArtiste(noArtiste).Select(a => a.tblFichierPersonnel).ToList();
        }

        internal List<Modele.tblFichierPersonnel> Fichiers(int noArtiste)
        {
            return provider.ToutFichierPersonnel().Where(a => a.type == "Fichier" && a.noArtiste == noArtiste && !Photos(noArtiste).Contains(a)).ToList();
        }

        internal Modele.tblArtiste SelectArtiste(int _idArtiste)
        {
            return provider.SelectArtiste(_idArtiste);
        }

        internal void Supprimer(int idartiste)
        {
            provider.SupprimerArtiste(idartiste);
        }

        internal List<Modele.tblFichierOfficiel> PhotoOfficielles(int _idArtiste)
        {
            return provider.PhotoOfficielArtiste(_idArtiste);
        }



        internal void AjouterFichier(tblFichierPersonnel item)
        {
            provider.InsertFichierPersonnel(item);
        }

        internal void AjouterFiche(tblFichierPersonnel item)
        {
            provider.InsertFichierPersonnel(item);
        }

        internal void AjouterPhoto(tblFichierPersonnel item)
        {
            provider.InsertFichierPersonnel(item);
            provider.Save();
        }

        internal void AjouterPhotoOfficielle(tblFichierOfficiel item)
        {
            provider.InsertFichierOfficiel(item);
        }
    }
}
