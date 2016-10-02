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
            dgvCategorie.ReadOnly = true;
            dgvCategorie.AllowUserToDeleteRows = false;
            dgvCategorie.DataSource = conSommaireCatArtiste.Tout().ToSortableBindingList();
            txtRecherche.GotFocus += TxtRecherche_GotFocus;
            txtRecherche.LostFocus += TxtRecherche_LostFocus;
        }
        private void TxtRecherche_LostFocus(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "")
            {
                txtRecherche.Text = "Recherche rapide";
            }
        }

        private void TxtRecherche_GotFocus(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "Recherche rapide")
            {
                txtRecherche.Text = "";
            }
        }
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var dataGridView = dgvCategorie;
            var controlleur = conSommaireCatArtiste;
            var critere = txtRecherche.Text.ToUpper();
            if (string.IsNullOrEmpty(critere) || critere == "Recherche rapide".ToUpper())
            {
                dataGridView.DataSource = controlleur.Tout().ToSortableBindingList();
            }
            else
            {
                dataGridView.DataSource = controlleur.Tout().Where(a => (a.nom ?? "").ToUpper().Contains(critere) || (a.description ?? "").ToUpper().Contains(critere)).ToList().ToSortableBindingList();
            }
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
            frmDetailCatArt.DesactiverBtnSupp();
            frmDetailCatArt.ShowDialog();
            dgvCategorie.DataSource = null;
            dgvCategorie.DataSource = conSommaireCatArtiste.Tout().ToSortableBindingList();
        }
    }
}
