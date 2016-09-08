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
    public partial class SommaireCategoriesArtiste : Form
    {
        Controleur.Sommaires.SommaireCategorieArtiste conSommaireCatArtiste;
        public SommaireCategoriesArtiste()
        {
            InitializeComponent();
            conSommaireCatArtiste = new Controleur.Sommaires.SommaireCategorieArtiste();
            dgvCategorie.AutoGenerateColumns = false;
            dgvCategorie.RowHeadersVisible = false;
            dgvCategorie.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvCategorie.AllowUserToResizeRows = false;
            dgvCategorie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorie.DataSource = conSommaireCatArtiste.Tout();
        }


    }
}
