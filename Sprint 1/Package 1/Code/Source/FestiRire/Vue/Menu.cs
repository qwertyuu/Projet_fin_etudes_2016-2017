using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestiRire.Vue
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnContrat_Click(object sender, EventArgs e)
        {
            SommaireContrats frmContrat = new SommaireContrats();
            frmContrat.ShowDialog();
        }

        private void btnStatut_Click(object sender, EventArgs e)
        {
            SommaireStatut frmStatut = new SommaireStatut();
            frmStatut.ShowDialog();
        }

        private void btnAgence_Click(object sender, EventArgs e)
        {
            SommaireAgence frmAgence = new SommaireAgence();
            frmAgence.ShowDialog();
        }

        private void btnArtiste_Click(object sender, EventArgs e)
        {
            SommaireArtiste frmAriste = new SommaireArtiste();
            frmAriste.ShowDialog();
        }

        private void btnCatArt_Click(object sender, EventArgs e)
        {
            SommaireCategoriesArtiste frmCatArt = new SommaireCategoriesArtiste();
            frmCatArt.ShowDialog();
        }
    }
}
