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
            dgvContrats.DataSource = conSommaireContrat.Tout().ToSortableBindingList();
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
    }
}
