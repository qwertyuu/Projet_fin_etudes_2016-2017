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
            var donnees = (from item in conSommaireStatut.Tout()
                           select new { noStatut = item.noStatut, nom = item.nomStatut, couleur = item.couleur, description = item.description }).ToList();
            dgvStatut.DataSource = donnees;
        }
    }
}
