﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Sommaires
{
    class SommaireContrat : SommaireBase
    {
        public SommaireContrat() : base()
        {

        }

        public List<Modele.vueSomContrat> Tout()
        {
            return provider.ToutVueContrats();
        }
    }
}
