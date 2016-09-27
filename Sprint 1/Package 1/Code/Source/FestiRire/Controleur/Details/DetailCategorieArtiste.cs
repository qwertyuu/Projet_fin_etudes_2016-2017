using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Details
{
    class DetailCategorieArtiste : DetailBaseSimple
    {

        public List<Modele.tblCategorieArtiste> Tout()
        {
            return provider.ToutCatArtiste();
        }
        public Modele.tblCategorieArtiste LoadCatArtt(int id)
        {
            return provider.selectCatArt(id);
        }

        public bool EnregistrerCatArt(int idAcien ,string nom, string desc)
        {

            Modele.tblCategorieArtiste catArt = provider.selectCatArt(idAcien);

            if (catArt != null)
            {
                //l'élément exite on fait une mise à jour.
                catArt.nom = nom;
                catArt.description = desc;
                provider.Save();
                return false;
            }
            else //On fait ajoute si l'élément n'existe pas
            {
                var categorie = new Modele.tblCategorieArtiste { nom = SanitariserTexte(nom), description = SanitariserTexte(desc) };
                provider.InsertCatArtiste(categorie);
                return true;
            }

        }

        public void deleteCatArt(int no)
        {
            provider.SupprimerCatArtiste(no);
        }


        

        internal bool CatArtisteExiste(int id, out string nom)
        {
            var categorie = provider.selectCatArt(id);
            if (categorie != null)
            {
                nom = categorie.nom;
                return true;
            }
            nom = "";
            return false;
        }
    }
}
