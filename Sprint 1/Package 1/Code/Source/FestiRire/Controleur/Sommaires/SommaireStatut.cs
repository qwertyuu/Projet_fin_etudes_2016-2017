using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Sommaires
{
    class SommaireStatut : SommaireBase
    {
        public List<Modele.vueSomStatut> Tout()
        {
            
            return provider.ToutVueStatus();
        }
    }
}
