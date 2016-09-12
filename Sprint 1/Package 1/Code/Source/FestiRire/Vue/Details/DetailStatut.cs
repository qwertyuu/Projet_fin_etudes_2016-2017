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
    public partial class DetailStatut : Form
    {
        Controleur.Details.DetailStatut _statut = new Controleur.Details.DetailStatut();
        bool modeCreation;
        public DetailStatut()
        {
            InitializeComponent();
            modeCreation = true;
        }
        public DetailStatut(int id)
        {
            InitializeComponent();
            modeCreation = false;
            PeuplerInterface(_statut.LoadStatut(id));
        }
        private void PeuplerInterface(Modele.tblStatut _statut)
        {
            txtNom.Text = _statut.nomStatut;
            rtbDescriptionStatut.Text = _statut.description;
            pbApercuCouleur.BackColor = ColorTranslator.FromHtml(_statut.couleur);
        }
        public void ConfirmationClose()
        {
            DialogResult result;
            result = MessageBox.Show("Si vous fermez vous allez perdre les données déja saisies. Voulez-vous fermer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ConfirmationClose();
        }
        private void btnEnregistrerStatut_Click_1(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                MessageBox.Show("Veuiller donner un nom.");
            }
            else
            {
                _statut.AjouterStatut(txtNom.Text, rtbDescriptionStatut.Text, ColorTranslator.ToHtml(pbApercuCouleur.BackColor));
            }

        }
    }
}