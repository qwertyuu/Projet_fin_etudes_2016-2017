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
    public partial class DetailAgence : Form
    {
        Controleur.Details.DetailAgence agence = new Controleur.Details.DetailAgence();
        public DetailAgence()
        {
            InitializeComponent();
            //var a = new Message();
        }

        private void btnEnregistrerAgence_Click(object sender, EventArgs e)
        {
            agence.AjouterAgence(txtNo.Text,txtNomAgence.Text, txtCourriel.Text, txtVille.Text, txtCodePostal.Text, rtbAdresse.Text, txtCellulaire.Text, txtTelCellulaire.Text, txtPosteBureau.Text, cmbProvince.Text, txtPays.Text);
            MessageBox.Show("Agence Ajouté");
        }
    }
}
