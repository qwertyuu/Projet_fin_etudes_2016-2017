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
        Controleur.Validation validation = new Controleur.Validation();
        string idAgenceOriginal;
        public DetailAgence()
        {
            InitializeComponent();
            
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




        private void btnEnregistrerAgence_Click(object sender, EventArgs e)
        {
            validation.verifierChampVide(txtNomAgence.Text, txtNo.Text, txtCourriel.Text, rtbAdresse.Text, txtVille.Text, cmbProvince.Text, txtPays.Text, txtCodePostal.Text);
            validation.verifierTel(agence.SanitariserTelephone(txtTelCellulaire.Text), agence.SanitariserTelephone(txtBureau.Text),  agence.SanitariserTelephone(txtPosteBureau.Text));
            if (validation.MessVide != "")//Siginifie que tous les champs n'ont pas été vérifié.
            {
                MessageBox.Show(validation.MessVide);
                return;
            }
            else
            {
                if (validation.MessTel != "")
                {
                    MessageBox.Show(validation.MessTel);
                    return;
                }
                else
                {
                    if (!validation.IsValidEmail(txtCourriel.Text))
                    {
                        MessageBox.Show("Veuillez entrer un courriel valide");
                        return;
                    }
                    else
                    {
                        if (!validation.IsValidCodePost(txtCodePostal.Text))
                        {
                            MessageBox.Show("Veuillez entrer un code postal valide");
                            return;
                        }
                        
                    }

                }

            }
			string nomAgence = "";
            if ((idAgenceOriginal == null) && agence.AgenceExiste(txtNo.Text, out nomAgence))
            {
                if (MessageBox.Show(String.Format("Vous avez entré un numéro d'agence existant.\nVoulez vous vraiment modifier l'agence {0}?", nomAgence), "Agence existe", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if(agence.EnregistrerAgence(idAgenceOriginal, txtNo.Text,txtNomAgence.Text, txtCourriel.Text, txtVille.Text, txtCodePostal.Text, rtbAdresse.Text, txtBureau.Text, txtTelCellulaire.Text, txtPosteBureau.Text, cmbProvince.Text, txtPays.Text))
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
            idAgenceOriginal = idAgence;
            txtNo.ReadOnly = true;
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
            cmbProvince.Text = _agence.tblAdresse.province;
        }

        private void btnSupprimerAgence_Click(object sender, EventArgs e)
        {
          
            if (!String.IsNullOrEmpty(txtNo.Text))
            {
                DialogResult result = result = MessageBox.Show("Voulez-vous supprimer cette agence?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    agence.DeleteAgence(txtNo.Text);
                    MessageBox.Show("Agence supprimée avec succès");
                }

            }
                     
                else
                   MessageBox.Show("Veuillez entrer le numéro de l'agence que vous voulez supprimer.");
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ConfirmationClose();
        }
    }
}
