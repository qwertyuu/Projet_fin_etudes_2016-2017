using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Modele
{
    abstract class ModeleElement
    {
        public bool Enregistrer()
        {
            if (this.Existe())
            {
                return this.Update();
            }
            else
            {
                return this.Create();
            }
        }

        abstract protected bool Existe();

        abstract protected bool Update();

        abstract protected bool Create();
        abstract public bool Supprimer();
    }
}
