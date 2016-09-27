using System;
using System.Collections.Generic;
using System.Linq;
using FestiRire.Modele;

namespace FestiRire.Controleur.Sommaires
{
    internal class SommaireEngagement : SommaireBase
    {

        public List<Modele.vueSomEngagement> ToutPourContrat(string idContrat)
        {
            return provider.ToutEngagement().Where(e => e.noContrat == idContrat).ToList();
        }

        public List<Modele.vueSomEngagement> Tout()
        {
            return provider.ToutEngagement();
        }

        internal void SupprimerBD(vueSomEngagement engagement)
        {
            provider.SupprimerBDEngagement(engagement);
        }
    }
}