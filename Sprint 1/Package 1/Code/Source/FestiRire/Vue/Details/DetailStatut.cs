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
        int? idStatut;
        public DetailStatut()
        {
            InitializeComponent();
        }
        public DetailStatut(int id)
        {
            InitializeComponent();
            idStatut = id;
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
        private void btnEnregistrerStatut_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "" || pbApercuCouleur.BackColor == Color.Transparent)
            {
                MessageBox.Show("Veuiller donner un nom et entrer une couleur.");
            }
            else
            {
                _statut.AjouterStatut(txtNom.Text, rtbDescriptionStatut.Text, ColorTranslator.ToHtml(pbApercuCouleur.BackColor));
            }

        }

        private void btnGrasDescription_Click(object sender, EventArgs e)
        {
            _statut.TextGras(rtbDescriptionStatut);
        }

        private void btnItaliqueDescription_Click(object sender, EventArgs e)
        {
            _statut.TextItalic(rtbDescriptionStatut);
        }

        private void btnSouslignerDescription_Click(object sender, EventArgs e)
        {
            _statut.TextUderline(rtbDescriptionStatut);
        }

        private void numPoliceDescription_ValueChanged(object sender, EventArgs e)
        {
            _statut.SizeText(rtbDescriptionStatut, numPoliceDescription.Value);
        }

        private void btnEnumDescription_Click(object sender, EventArgs e)
        {
            _statut.EnumText(rtbDescriptionStatut);
        }

        private void btnChoixCouleur_Click(object sender, EventArgs e)
        {
            DialogResult res = colorDialog1.ShowDialog();

            if (res == DialogResult.OK)
            {
                pbApercuCouleur.BackColor = colorDialog1.Color;
            }
        }
    }
}