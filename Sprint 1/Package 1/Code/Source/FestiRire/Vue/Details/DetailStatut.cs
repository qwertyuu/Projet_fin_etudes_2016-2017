﻿using System;
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
            idStatut = 0;
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
            pbApercuCouleur.BackColor = ColorTranslator.FromHtml("#" + _statut.couleur);
            
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
            string mess = "";
            if (txtNom.Text == "" || pbApercuCouleur.BackColor == Color.Transparent)
            {
                MessageBox.Show("Veuiller donner un nom et entrer une couleur.");
            }
            else
            {
                if (!_statut.AjouterStatut((int)idStatut, txtNom.Text, rtbDescriptionStatut.Text, pbApercuCouleur.BackColor))
                    mess = "Le satut a été modifié avec succés.";
                else
                    mess = "Le satut à été enregistré avec succés." ;
                MessageBox.Show(mess);
                this.Close();
            }
           
        }

        private void btnChoixCouleur_Click(object sender, EventArgs e)
        {
            DialogResult res = colorDialog1.ShowDialog();

            if (res == DialogResult.OK)
            {
                pbApercuCouleur.BackColor = colorDialog1.Color;
            }
        }

        public void DesactiverBtnSupp()
        {
            btnSupprimerStatut.Enabled = false;
        }

        private void btnSupprimerStatut_Click(object sender, EventArgs e)
        {
            if (idStatut != 0)
            {
                DialogResult result = result = MessageBox.Show("Voulez-vous supprimer ce statut?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _statut.DeleteStatut((int)idStatut);
                    MessageBox.Show("Le statut a été supprimé avec succés.");
                    this.Close();
                }
            }
        }
    }
}