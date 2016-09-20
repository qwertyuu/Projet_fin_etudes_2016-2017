using System;
using System.Collections.Generic;
using System.Linq;

namespace FestiRire.Controleur.Sommaires
{
    internal class SommaireExigence : SommaireBase
    {

        public List<Modele.vueSomExigence> ToutPourContrat(string idContrat)
        {
            return provider.ToutExigence().Where(e => e.noContrat == idContrat).ToList();
        }
    }
}