using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Sommaires
{
    class SommaireArtiste : SommaireBase
    {

        public List<Modele.vueSomArtiste> Tout()
        {
            return provider.ToutVueArtiste();
        }
    }
}
