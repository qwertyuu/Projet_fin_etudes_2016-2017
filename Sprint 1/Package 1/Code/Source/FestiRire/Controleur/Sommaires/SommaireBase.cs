using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestiRire.Controleur.Sommaires
{
    abstract class SommaireBase
    {
        protected DBProvider provider;
        public SommaireBase()
        {
            provider = new DBProvider();
        }

    }
}
