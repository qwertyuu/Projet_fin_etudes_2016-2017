using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Details
{
    class DetailArtiste : DetailBaseSimple
    {

    	public DetailArtiste() : base()
    	{

    	}
        List<Modele.tblCategorieArtiste> ListCatArtis;
        List<Modele.tblContrat> listContrat;
        public List<Modele.tblCategorieArtiste>ListeCategorieArtiste
        {
            get
            {
                return ListCatArtis;
            }
        }

        public List<Modele.tblContrat> ListeContrat
        {
            get
            {
                return listContrat;
            }
        }

        public List<Modele.tblCategorieArtiste> ChargerListCatArtis()
        {
            ListCatArtis = new List<Modele.tblCategorieArtiste>();
            foreach(Modele.tblCategorieArtiste cat in provider.ReturnAllCatArtiste())
            {
                ListCatArtis.Add(cat);
            }
            return ListCatArtis;
        }

        public List<Modele.tblContrat> ChargerContrat()
        {
            listContrat = new List<Modele.tblContrat>();
            foreach (Modele.tblContrat con in provider.ToutContratTerminé())
            {
                listContrat.Add(con);
            }
            return listContrat;
        }
        public void AjouterArtiste(string nomArt, string nomCat,string chemin,string com,string nomContrat)
        {
            var artiste = new Modele.tblArtiste { nom = nomArt, commentaire = com };
            var fichier=new Modele.tblFichierPersonnel()
        }
    }
}
