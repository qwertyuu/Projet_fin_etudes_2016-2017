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
    public partial class DetailContrat : Form
    {
        Controleur.Details.DetailContrat contrat;
        public DetailContrat()
        {
            InitializeComponent();
            contrat = new Controleur.Details.DetailContrat();
            verifierStatut();
        }

        public DetailContrat(string noContrat)
        {
            InitializeComponent();
            //Faire loader les info de contrat ici
            verifierStatut();
        }

        //Gestion des styles reliés aux commentaires et description
        private void btnGrasCommentaire_Click(object sender, EventArgs e)
        {
            contrat.TextGras(rtbCommentaire);
        }

        private void btnItaliqueCommentaire_Click(object sender, EventArgs e)
        {
            contrat.TextItalic(rtbCommentaire);
        }

        private void btnSouslignerCommentaire_Click(object sender, EventArgs e)
        {
            contrat.TextUderline(rtbCommentaire);
        }

        private void numPoliceCommentaire_ValueChanged(object sender, EventArgs e)
        {
            contrat.SizeText(rtbCommentaire,numPoliceCommentaire.Value);
        }

        private void btnEnumCommentaire_Click(object sender, EventArgs e)
        {
            contrat.EnumText(rtbCommentaire);
        }


        private void btnGrasDescription_Click(object sender, EventArgs e)
        {
            contrat.TextGras(rtbDescriptionContrat);
        }

        private void btnItaliqueDescription_Click(object sender, EventArgs e)
        {
            contrat.TextItalic(rtbDescriptionContrat);
        }

        private void btnSouslignerDescription_Click(object sender, EventArgs e)
        {
            contrat.TextUderline(rtbDescriptionContrat);
        }

        private void numPoliceDescription_ValueChanged(object sender, EventArgs e)
        {
            contrat.SizeText(rtbDescriptionContrat,numPoliceDescription.Value);
        }

        private void btnEnumDescription_Click(object sender, EventArgs e)
        {
            contrat.EnumText(rtbDescriptionContrat);
        }

        private void btnStatut1_Click(object sender, EventArgs e)
        {
            if (btnStatut1.Text == "En négociation")
                lblStatutContrat.Text = "En négociation";
            else if (btnStatut1.Text == "En cours")
                lblStatutContrat.Text = "En cours";
            else if (btnStatut1.Text == "Terminé")
                lblStatutContrat.Text = "Terminé";

            verifierStatut();
        }

        private void btnStatut2_Click(object sender, EventArgs e)
        {
            if (btnStatut2.Text == "Supprimer")
                lblStatutContrat.Text = "Supprimer";
            else if (btnStatut2.Text == "Conttrat annulé")
                lblStatutContrat.Text = "Annulé";

            verifierStatut();
        }

        private void verifierStatut()
        {
            if (lblStatutContrat.Text == "")
            {
                btnStatut1.Text = "En négociation";
                btnStatut1.Visible = true;
            }
            else if (lblStatutContrat.Text == "En négociation")
            {
                btnStatut1.Text = "En cours";
                btnStatut1.Visible = true;
                btnStatut2.Text = "Supprimer";
                btnStatut2.Visible = true;
            }
            else if (lblStatutContrat.Text == "En cours")
            {
                btnStatut1.Text = "Terminé";
                btnStatut1.Visible = true;
                btnStatut2.Text = "Contrat annulé";
                btnStatut2.Visible = true;
            }
            else if (lblStatutContrat.Text == "Annulé" || lblStatutContrat.Text == "Supprimer" || lblStatutContrat.Text == "Terminé")
            {
                btnStatut1.Visible = false;
                btnStatut2.Visible = false;
            }
        }
    }
}
