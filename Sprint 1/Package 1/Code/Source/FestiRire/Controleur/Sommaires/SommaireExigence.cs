using System;
using System.Collections.Generic;
using System.Linq;
using FestiRire.Modele;

namespace FestiRire.Controleur.Sommaires
{
    internal class SommaireExigence : SommaireBase
    {

        public List<Modele.vueSomExigence> ToutPourContrat(string idContrat)
        {
            return provider.ToutExigence().Where(e => e.noContrat == idContrat).ToList();
        }

        public List<Modele.vueSomExigence> Tout()
        {

            return provider.ToutExigence();
        }

        internal void SupprimerBD(vueSomExigence exigence)
        {
            provider.SupprimerBDExigence(exigence);
        }
    }
}