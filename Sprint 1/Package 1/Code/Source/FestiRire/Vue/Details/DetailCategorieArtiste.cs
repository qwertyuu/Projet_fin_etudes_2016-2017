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

        //Gestion des styles reliés aux commentaires et description
        private void btnGrasCatArtiste_Click(object sender, EventArgs e)
        {
            DCA.TextGras(rtbDescriptionCategorie);
        }

        private void btnItalicCatArtiste_Click(object sender, EventArgs e)
        {
            DCA.TextItalic(rtbDescriptionCategorie);
        }

        private void btnUnderlineCatArtiste_Click(object sender, EventArgs e)
        {
            DCA.TextUderline(rtbDescriptionCategorie);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            DCA.SizeText(rtbDescriptionCategorie,numericUpDownCatArtiste.Value);
        }

        private void btnEnumCatArtiste_Click(object sender, EventArgs e)
        {
            DCA.EnumText(rtbDescriptionCategorie);
        }

    }
}
