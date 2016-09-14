using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur
{
    class Login: Details.DetailBaseSimple
    {

        public Login():base()
        {

        }

        public bool AuthentifierUser(string id,string motPasse)
        {
            bool UserTrouver = false;
            if (provider.Authentifier(SanitariserTexte(id), SanitariserTexte(motPasse)))
                UserTrouver=true;
            return UserTrouver;
               
        }

    }
}
