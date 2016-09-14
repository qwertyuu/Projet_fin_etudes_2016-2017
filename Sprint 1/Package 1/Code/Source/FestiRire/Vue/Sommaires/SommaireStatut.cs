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
            frmDetailStatut.ShowDialog();
            dgvStatut.DataSource = null;
            dgvStatut.DataSource = conSommaireStatut.Tout().ToSortableBindingList();
        }

    }
}
