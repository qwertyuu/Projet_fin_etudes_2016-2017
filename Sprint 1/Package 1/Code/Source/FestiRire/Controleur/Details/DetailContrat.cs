using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Details
{
    class DetailContrat : DetailBaseSimple
    {
        internal Modele.tblContrat SelectContrat(string idContrat)
        {
            return provider.SelectContrat(idContrat);
        }
    }
}
