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
        Controleur.Sommaires.SommaireStatut conSommaireStatut;
        public SommaireStatut()
        {
            InitializeComponent();
            conSommaireStatut = new Controleur.Sommaires.SommaireStatut();

            dgvStatut.AutoGenerateColumns = false;
            dgvStatut.RowHeadersVisible = false;
            dgvStatut.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvStatut.AllowUserToResizeRows = false;
            dgvStatut.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStatut.MultiSelect = false;
            dgvStatut.AllowUserToAddRows = false;
            dgvStatut.DataSource = conSommaireStatut.Tout().ToSortableBindingList();
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
            var frmDetailStatut = new DetailStatut(((Modele.vueSomStatut)dgvStatut.SelectedRows[0].DataBoundItem).noStatut);
            frmDetailStatut.ShowDialog();
            dgvStatut.DataSource = null;
            dgvStatut.DataSource = conSommaireStatut.Tout().ToSortableBindingList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var frmDetailStatut = new DetailStatut();
            frmDetailStatut.DesactiverBtnSupp();
            frmDetailStatut.ShowDialog();
            dgvStatut.DataSource = null;
            dgvStatut.DataSource = conSommaireStatut.Tout().ToSortableBindingList();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var dataGridView = dgvStatut;
            var critere = txtRecherche.Text.ToUpper();
            if (string.IsNullOrEmpty(critere) || critere == "Recherche rapide".ToUpper())
            {
                dataGridView.DataSource = conSommaireStatut.Tout().ToSortableBindingList();
            }
            else
            {
                dataGridView.DataSource = conSommaireStatut.Tout().Where(a => a.NomStatut.ToUpper().Contains(critere) || a.couleur.ToUpper().Contains(critere) || a.description.ToUpper().Contains(critere)).ToList().ToSortableBindingList();
            }
        }
    }
}
