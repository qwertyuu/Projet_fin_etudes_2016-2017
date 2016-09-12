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
    public partial class SommaireStatut : Form
    {
        Controleur.Sommaires.SommaireContrat conSommaireContrat;
        public SommaireStatut()
        {
            InitializeComponent();
            conSommaireContrat = new Controleur.Sommaires.SommaireContrat();

            dgvStatut.AutoGenerateColumns = false;
            dgvStatut.RowHeadersVisible = false;
            dgvStatut.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvStatut.AllowUserToResizeRows = false;
            dgvStatut.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStatut.MultiSelect = false;
            dgvStatut.DataSource = conSommaireContrat.Tout();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnDetail_Click(object sender, EventArgs e)
        {
            var frmDetailContrat = new DetailContrat(((Modele.vueSomContrat)dgvStatut.SelectedRows[0].DataBoundItem).noContrat);
            frmDetailContrat.ShowDialog();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var frmDetailContrat = new DetailContrat();

            frmDetailContrat.ShowDialog();
        }
    }
}
