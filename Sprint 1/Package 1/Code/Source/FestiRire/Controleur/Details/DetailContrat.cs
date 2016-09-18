using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Details
{
    class DetailContrat : DetailBaseSimple
    {
        public Modele.tblContrat SelectContrat(string idContrat)
        {
            return provider.SelectContrat(idContrat);
        }

        public Modele.tblResponsable ResponsableAgence(string idContrat)
        {
            return provider.SelectResponsableAgence(idContrat);
        }

        public Modele.tblResponsable ResponsableDiffuseur(string idContrat)
        {
            return provider.SelectResponsableDiffuseur(idContrat);
        }
    }
}
