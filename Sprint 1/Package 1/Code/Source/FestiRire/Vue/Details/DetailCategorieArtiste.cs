using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestiRire
{
    public partial class DetailCategorieArtiste : Form
    {
        Controleur.Details.DetailCategorieArtiste DCA;
        public DetailCategorieArtiste()
        {
            InitializeComponent();
            DCA = new Controleur.Details.DetailCategorieArtiste();
        }

        public DetailCategorieArtiste(int noCategorie)
        {
            InitializeComponent();
            DCA = new Controleur.Details.DetailCategorieArtiste();
            //Modele.tblCategorieArtiste categorie = DCA.LoadCategorieArtiste(noCategorie);
            
        }
    }
}
