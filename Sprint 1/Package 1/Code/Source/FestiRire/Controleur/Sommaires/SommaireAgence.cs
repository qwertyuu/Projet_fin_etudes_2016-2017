using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FestiRire.Controleur.Sommaires
{
    class SommaireAgence : SommaireBase
    {
        public SommaireAgence() : base()
        {
            
        }

        public List<Modele.vueSomAgence> Tout()
        {
            return provider.ToutVueAgence();
        }

        public string FormatTelephone(string tel)
        {
            StringBuilder sB = new StringBuilder();
            sB.Append("(");
            sB.Append(tel.Substring(0, 3));
            sB.Append(") ");
            sB.Append(tel.Substring(3, 3));
            sB.Append("-");
            sB.Append(tel.Substring(6));
            return sB.ToString();
        }



    }
}