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

        public List<Modele.tblCategorieArtiste> ChargerListCatArtis()
        {
            return provider.ToutCatArtiste();
        }

        public List<Modele.tblContrat> ChargerContrat()
        {
            return provider.ToutContrat();
        }

        public List<Modele.tblArtiste> Tout()
        {
            return provider.ToutArtiste();
        }

        public void AjouterArtiste(string nomArt, string nomCat,string chemin,string com,string nomContrat)
        {
            var artiste = new Modele.tblArtiste { nom = nomArt, commentaire = com };

        }
    }
}
