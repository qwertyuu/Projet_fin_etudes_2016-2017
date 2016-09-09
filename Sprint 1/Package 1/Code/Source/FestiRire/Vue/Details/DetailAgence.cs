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
        bool modeCreation;
        public DetailAgence()
        {
            InitializeComponent();
            modeCreation = true;
            //var a = new Message();
        }

        private void btnEnregistrerAgence_Click(object sender, EventArgs e)
        {
            string nomAgence = "";
            if (modeCreation && agence.AgenceExiste(txtNo.Text, out nomAgence))
            {
                if (MessageBox.Show(String.Format("Vous avez entré un numéro d'agence existant.\nVoulez vous vraiment modifier l'agence {0}?", nomAgence), "Agence existe", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if(agence.EnregistrerAgence(txtNo.Text,txtNomAgence.Text, txtCourriel.Text, txtVille.Text, txtCodePostal.Text, rtbAdresse.Text, txtBureau.Text, txtTelCellulaire.Text, txtPosteBureau.Text, cmbProvince.Text, txtPays.Text))
            {
                MessageBox.Show("Agence Modifiée");
            }
            else
            {
                MessageBox.Show("Agence Ajoutée");
            }
            this.Close();

        }

        public DetailAgence(string idAgence)
        {
            InitializeComponent();
            modeCreation = false;
            //Ajouter le code de loading de la combo box avant!!
            PeuplerInterface(agence.LoadAgence(idAgence));
        }

        private void PeuplerInterface(Modele.tblAgence _agence)
        {
            txtNo.Text = _agence.noAgence;
            txtNomAgence.Text = _agence.nom;
            txtCourriel.Text = _agence.courriel;
            txtVille.Text = _agence.tblAdresse.ville;
            txtCodePostal.Text = _agence.tblAdresse.codepostal;
            rtbAdresse.Text = _agence.tblAdresse.adresse;
            txtBureau.Text = agence.FormatTelephone(_agence.tblAdresse.telBureau);
            txtTelCellulaire.Text = agence.FormatTelephone(_agence.tblAdresse.telCellulaire);
            txtPosteBureau.Text = _agence.tblAdresse.extension;
            txtPays.Text = _agence.tblAdresse.pays;

            // À CHANGER -- METTRE LE SELECTED INDEX APRES AVOIR POPULÉ LA COMBOBOX
            cmbProvince.Text = _agence.tblAdresse.province;
        }
    }
}
