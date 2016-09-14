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
    public partial class SommaireCategoriesArtiste : Form
    {
        Controleur.Sommaires.SommaireCategorieArtiste conSommaireCatArtiste;
        public SommaireCategoriesArtiste()
        {
            InitializeComponent();
            conSommaireCatArtiste = new Controleur.Sommaires.SommaireCategorieArtiste();
            dgvCategorie.AutoGenerateColumns = false;
            dgvCategorie.RowHeadersVisible = false;
            dgvCategorie.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvCategorie.AllowUserToResizeRows = false;
            dgvCategorie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorie.MultiSelect = false;
            dgvCategorie.AllowUserToAddRows = false;
            dgvCategorie.DataSource = conSommaireCatArtiste.Tout().ToSortableBindingList();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            var frmDetailCatArt = new DetailCategorieArtiste(((Modele.vueSomCatArtiste)dgvCategorie.SelectedRows[0].DataBoundItem).noCategorie);
            frmDetailCatArt.ShowDialog();
            dgvCategorie.DataSource = null;
            dgvCategorie.DataSource = conSommaireCatArtiste.Tout().ToSortableBindingList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var frmDetailCatArt = new DetailCategorieArtiste();
            frmDetailCatArt.ShowDialog();
            dgvCategorie.DataSource = null;
            dgvCategorie.DataSource = conSommaireCatArtiste.Tout().ToSortableBindingList();
        }
    }
}
