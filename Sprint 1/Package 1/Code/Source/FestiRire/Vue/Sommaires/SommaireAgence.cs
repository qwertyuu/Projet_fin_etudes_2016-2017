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
            var donnees = (from item in conSommaireAgence.Tout()
                          select new { noAgence = item.noAgence, nom = item.nom, ville = item.ville, tel = conSommaireAgence.FormatTelephone(item.telBureau ?? item.telCellulaire) }).ToList();
            dgvAgence.DataSource = donnees;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
        private void btnDetail_Click(object sender, EventArgs e)
        {


            var frmDetailAgence = new DetailAgence((dgvAgence.SelectedRows[0].Cells["noAgence"].Value.ToString()));
            frmDetailAgence.ShowDialog();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var frmDetailAgence = new DetailAgence();

            frmDetailAgence.ShowDialog();
        }
    }
}
