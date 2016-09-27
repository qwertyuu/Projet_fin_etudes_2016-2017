using System;
using FestiRire.Modele;

namespace FestiRire.Controleur.Details
{
    internal class DetailFichiers : DetailBaseSimple
    {
        internal void Supprimer(tblFichierPersonnel item)
        {
            provider.SupprimerFichier(item);
        }
    }
}