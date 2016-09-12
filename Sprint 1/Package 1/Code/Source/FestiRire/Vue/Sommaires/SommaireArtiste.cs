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
            var artistesVue = conSommaireArtiste.Tout();
            dgvArtiste.DataSource = artistesVue;
            var final = (from m in artistesVue
                        join s in conDetailArtiste.Tout() on m.noArtiste equals s.noArtiste
                        select s).ToList();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnDetail_Click(object sender, EventArgs e)
        {
            var frmDetailArtiste = new DetailArtiste(((Modele.vueSomArtiste)dgvArtiste.SelectedRows[0].DataBoundItem).noArtiste);
            frmDetailArtiste.ShowDialog();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var frmDetailArtiste = new DetailArtiste();
            frmDetailArtiste.ShowDialog();
        }

        private void dgvArtiste_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvArtiste.Rows[e.RowIndex].Cells["categories"].Value = (e.Value as Modele.vueSomArtiste).nomCat;
        }
    }
}
