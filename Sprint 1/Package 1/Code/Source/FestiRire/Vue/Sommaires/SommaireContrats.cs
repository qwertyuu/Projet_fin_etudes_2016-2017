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
    public partial class SommaireContrats : Form
    {
        Controleur.Sommaires.SommaireContrat conSommaireContrat;
        public SommaireContrats()
        {
            InitializeComponent();
            conSommaireContrat = new Controleur.Sommaires.SommaireContrat();

            dgvContrats.AutoGenerateColumns = false;
            dgvContrats.RowHeadersVisible = false;
            dgvContrats.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvContrats.AllowUserToResizeRows = false;
            dgvContrats.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContrats.MultiSelect = false;
            dgvContrats.AllowUserToAddRows = false;
            dgvContrats.ReadOnly = true;
            dgvContrats.AllowUserToDeleteRows = false;
            dgvContrats.DataSource = conSommaireContrat.Tout().ToSortableBindingList();
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

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            var frmDetailContrat = new DetailContrat(((Modele.vueSomContrat)dgvContrats.SelectedRows[0].DataBoundItem).noContrat);
            frmDetailContrat.ShowDialog();
            dgvContrats.DataSource = null;
            dgvContrats.DataSource = conSommaireContrat.Tout().ToSortableBindingList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var frmDetailContrat = new DetailContrat();
            frmDetailContrat.ShowDialog();
            dgvContrats.DataSource = null;
            dgvContrats.DataSource = conSommaireContrat.Tout().ToSortableBindingList();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var dataGridView = dgvContrats;
            var controlleur = conSommaireContrat;
            var critere = txtRecherche.Text.ToUpper();
            if (string.IsNullOrEmpty(critere) || critere == "Recherche rapide".ToUpper())
            {
                dataGridView.DataSource = controlleur.Tout().ToSortableBindingList();
            }
            else
            {
                dataGridView.DataSource = controlleur.Tout().Where(a => (a.lieu ?? "").ToUpper().Contains(critere) || (a.noContrat ?? "").ToUpper().Contains(critere) || (a.nom ?? "").ToUpper().Contains(critere) || (a.nomStatut ?? "").ToUpper().Contains(critere)).ToList().ToSortableBindingList();
            }
        }
    }
}