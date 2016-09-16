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
    public partial class SommaireArtiste : Form
    {
        Controleur.Sommaires.SommaireArtiste conSommaireArtiste;
        Controleur.Details.DetailArtiste conDetailArtiste;
        Controleur.Sommaires.SommaireCategorieArtiste conCatArt;

        public SommaireArtiste()
        {
            InitializeComponent();
            conSommaireArtiste = new Controleur.Sommaires.SommaireArtiste();
            conDetailArtiste = new Controleur.Details.DetailArtiste();
            conCatArt = new Controleur.Sommaires.SommaireCategorieArtiste();
            dgvArtiste.AutoGenerateColumns = false;
            dgvArtiste.RowHeadersVisible = false;
            dgvArtiste.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvArtiste.AllowUserToResizeRows = false;
            dgvArtiste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArtiste.MultiSelect = false;
            dgvArtiste.AllowUserToAddRows = false;
            dgvArtiste.DataSource = conSommaireArtiste.Tout().ToSortableBindingList();
           
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnDetail_Click(object sender, EventArgs e)
        {
            var frmDetailArtiste = new DetailArtiste(((Modele.vueSomArtiste)dgvArtiste.SelectedRows[0].DataBoundItem).noArtiste);
            frmDetailArtiste.ShowDialog();
            dgvArtiste.DataSource = null;
            dgvArtiste.DataSource = conSommaireArtiste.Tout().ToSortableBindingList();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var frmDetailArtiste = new DetailArtiste();
            frmDetailArtiste.DesactiverBtnSupp();
            frmDetailArtiste.ShowDialog();
            dgvArtiste.DataSource = null;
            dgvArtiste.DataSource = conSommaireArtiste.Tout().ToSortableBindingList();
        }

        private void dgvArtiste_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = (dgvArtiste.Rows[e.RowIndex].DataBoundItem as Modele.vueSomArtiste).nomAriste;
                return;
            }
            var CategoriesLieesALartiste = (from m in conDetailArtiste.Tout()
                                            where m.noArtiste == (dgvArtiste.Rows[e.RowIndex].DataBoundItem as Modele.vueSomArtiste).noArtiste
                                            select m.tblCategorieArtiste).ToList();
            string affichage = "";
            foreach (var item in CategoriesLieesALartiste)
            {
                foreach (var cat in item)
                {
                    affichage += cat.nom + " / ";
                }
            }
            e.Value = affichage.Substring(0, affichage.Length - 3);
            //dgvArtiste.Rows[e.RowIndex].Cells["categories"].Value = affichage.Substring(0, affichage.Length - 3);
        }
    }
}
