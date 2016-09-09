using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Details
{
    abstract class DetailBaseSimple
    {
        protected string SanitariserTexte(string s)
        {
            return s.Trim();
        }

        protected string NullSiVide(string v)
        {
            if (v == "")
            {
                return null;
            }
            return v;
        }

        protected string SanitariserTelephone(string tel)
        {
            StringBuilder noTelFinal = new StringBuilder();
            char[] caracteresAccepte = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            foreach (var c in tel)
            {
                if (caracteresAccepte.Contains(c))
                {
                    noTelFinal.Append(c);
                }
            }
            return noTelFinal.ToString();
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

        protected string SanitariserCourriel(string courr)
        {
            return SanitariserTexte(courr);
        }
    }
}
