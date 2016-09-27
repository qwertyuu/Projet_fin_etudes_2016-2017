using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Sommaires
{
    class SommaireCategorieArtiste : SommaireBase
    {
        public SommaireCategorieArtiste() : base()
        {
            
        }
        public List<Modele.vueSomCatArtiste> Tout()
        {
            return provider.ToutVueCategorieArtiste();
        }
    }

}
