using FestiRire.Modele;
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
    public partial class SommaireAgence : Form
    {
        Controleur.Sommaires.SommaireAgence conSommaireAgence;
        public SommaireAgence()
        {
            InitializeComponent();
            conSommaireAgence = new Controleur.Sommaires.SommaireAgence();
            dgvAgence.AutoGenerateColumns = false;
            dgvAgence.RowHeadersVisible = false;
            dgvAgence.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvAgence.AllowUserToResizeRows = false;
            dgvAgence.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgence.MultiSelect = false;
            dgvAgence.AllowUserToAddRows = false;

            var donnees = (from item in conSommaireAgence.Tout()
                          select new { noAgence = item.noAgence, nom = item.nom, ville = item.ville, tel = conSommaireAgence.FormatTelephone(item.telBureau ?? item.telCellulaire) }).ToList();
            dgvAgence.DataSource = donnees.ToSortableBindingList();

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
            var frmDetailAgence = new DetailAgence((dgvAgence.SelectedRows[0].Cells["noAgence"].Value.ToString()));
            frmDetailAgence.ShowDialog();
            var donnees = (from item in conSommaireAgence.Tout()
                           select new { noAgence = item.noAgence, nom = item.nom, ville = item.ville, tel = conSommaireAgence.FormatTelephone(item.telBureau ?? item.telCellulaire) }).ToList();
            dgvAgence.DataSource = null;
            dgvAgence.DataSource = donnees.ToSortableBindingList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var frmDetailAgence = new DetailAgence();
            frmDetailAgence.DesactiverBtnSupp();
            frmDetailAgence.ShowDialog();
            var donnees = (from item in conSommaireAgence.Tout()
                           select new { noAgence = item.noAgence, nom = item.nom, ville = item.ville, tel = conSommaireAgence.FormatTelephone(item.telBureau ?? item.telCellulaire) }).ToList();
            dgvAgence.DataSource = null;
            dgvAgence.DataSource = donnees.ToSortableBindingList();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var dataGridView = dgvAgence;
            var controlleur = conSommaireAgence;
            var critere = txtRecherche.Text.ToUpper();
            var donnees = (from item in conSommaireAgence.Tout()
                           select new { noAgence = item.noAgence, nom = item.nom, ville = item.ville, tel = conSommaireAgence.FormatTelephone(item.telBureau ?? item.telCellulaire) }).ToList();
            if (string.IsNullOrEmpty(critere) || critere == "Recherche rapide".ToUpper())
            {
                dataGridView.DataSource = donnees.ToSortableBindingList();
            }
            else
            {
                dataGridView.DataSource = donnees.Where(a => a.nom.ToUpper().Contains(critere) || a.ville.ToUpper().Contains(critere) || a.noAgence.ToUpper().Contains(critere) || a.tel.ToUpper().Contains(critere)).ToList().ToSortableBindingList();
            }
        }
    }
}
