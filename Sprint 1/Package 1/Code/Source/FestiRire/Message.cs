using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestiRire
{
    class Message
    {
        public Message()
        {
            //MessageBox.Show("Les nouvelles informations seront enregistrés définitivement. Voulez-vous vraiment enregistrer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //MessageBox.Show("Toutes les informations ont été enregistrées.", "Tout est en ordre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show("Le champ [nom du champ] ne doit pas être vide.", "Information manquante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //MessageBox.Show("Êtes-vous certain de vouloir supprimer [nom de l'élément]?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            MessageBox.Show("Le champ [nom du champ] n'est pas conforme.\nFormat recherché:[format du champ]", "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
