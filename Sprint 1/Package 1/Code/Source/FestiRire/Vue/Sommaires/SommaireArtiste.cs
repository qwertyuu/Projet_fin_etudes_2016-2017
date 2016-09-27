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
            dgvArtiste.ReadOnly = true;
            dgvArtiste.AllowUserToDeleteRows = false;
            dgvArtiste.DataSource = conSommaireArtiste.Tout().ToSortableBindingList();

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
            //formatte les catégories a afficher
            e.Value = String.Join(" / ", conDetailArtiste.Tout()
                .SingleOrDefault(artiste =>
                artiste.noArtiste == (dgvArtiste.Rows[e.RowIndex].DataBoundItem as Modele.vueSomArtiste).noArtiste
                ).tblCategorieArtiste.Select(catArt => catArt.nom));
        }
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var dataGridView = dgvArtiste;
            var controlleur = conSommaireArtiste;
            var critere = txtRecherche.Text.ToUpper();
            Dictionary<Modele.vueSomArtiste, string> categoriesLieesALartiste = new Dictionary<Modele.vueSomArtiste, string>();
            foreach (var item in controlleur.Tout())
            {
                //formatte les catégories a rechercher
                categoriesLieesALartiste[item] = String.Join(" / ", conDetailArtiste.Tout()
                                                                    .SingleOrDefault(artiste =>
                                                                    artiste.noArtiste == item.noArtiste
                                                                    ).tblCategorieArtiste.Select(catArt => catArt.nom));
            }
            if (string.IsNullOrEmpty(critere) || critere == "Recherche rapide".ToUpper())
            {
                dataGridView.DataSource = controlleur.Tout().ToSortableBindingList();
            }
            else
            {
                dataGridView.DataSource = controlleur.Tout().Where(a => a.nomAriste.ToUpper().Contains(critere) || categoriesLieesALartiste[a].ToUpper().Contains(critere)).ToList().ToSortableBindingList();
            }
        }
    }
}
