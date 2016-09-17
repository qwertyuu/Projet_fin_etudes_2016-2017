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
        Controleur.Details.DetailContrat conContrat;
        Controleur.Sommaires.SommaireAgence conSomAgence;
        Controleur.Details.DetailArtiste conArtiste;
        private string idContrat;

        public DetailContrat()
        {
            InitializeComponent();
            conContrat = new Controleur.Details.DetailContrat();
            conSomAgence = new Controleur.Sommaires.SommaireAgence();
            conArtiste = new Controleur.Details.DetailArtiste();
            idContrat = null;
            PeuplerListes();
            verifierStatut();
        }

        public DetailContrat(string noContrat)
        {
            InitializeComponent();
            conContrat = new Controleur.Details.DetailContrat();
            conSomAgence = new Controleur.Sommaires.SommaireAgence();
            conArtiste = new Controleur.Details.DetailArtiste();
            idContrat = noContrat;
            PeuplerListes();
            PeuplerInterface();
            verifierStatut();
        }

        private void PeuplerInterface()
        {
            var contratDuMoment = conContrat.SelectContrat(idContrat);
            txtNumeroContrat.Text = contratDuMoment.noContrat;
            txtNomContrat.Text = contratDuMoment.nom;
            txtLieuContrat.Text = contratDuMoment.lieu;
            
        }

        private void PeuplerListes()
        {
            cmbNomAgence.DataSource = conSomAgence.Tout();
            lstArtiste.DataSource = conArtiste.Tout();
        }

        //Gestion des styles reliés aux commentaires et description
        private void btnGrasCommentaire_Click(object sender, EventArgs e)
        {
            conContrat.TextGras(rtbCommentaire);
        }

        private void btnItaliqueCommentaire_Click(object sender, EventArgs e)
        {
            conContrat.TextItalic(rtbCommentaire);
        }

        private void btnSouslignerCommentaire_Click(object sender, EventArgs e)
        {
            conContrat.TextUderline(rtbCommentaire);
        }

        private void numPoliceCommentaire_ValueChanged(object sender, EventArgs e)
        {
            conContrat.SizeText(rtbCommentaire,numPoliceCommentaire.Value);
        }

        private void btnEnumCommentaire_Click(object sender, EventArgs e)
        {
            conContrat.EnumText(rtbCommentaire);
        }


        private void btnGrasDescription_Click(object sender, EventArgs e)
        {
            conContrat.TextGras(rtbDescriptionContrat);
        }

        private void btnItaliqueDescription_Click(object sender, EventArgs e)
        {
            conContrat.TextItalic(rtbDescriptionContrat);
        }

        private void btnSouslignerDescription_Click(object sender, EventArgs e)
        {
            conContrat.TextUderline(rtbDescriptionContrat);
        }

        private void numPoliceDescription_ValueChanged(object sender, EventArgs e)
        {
            conContrat.SizeText(rtbDescriptionContrat,numPoliceDescription.Value);
        }

        private void btnEnumDescription_Click(object sender, EventArgs e)
        {
            conContrat.EnumText(rtbDescriptionContrat);
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
                lblStatutContrat.Text = "Supprimé";
            else if (btnStatut2.Text == "Contrat annulé")
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

        private void btnDetailEngagement_Click(object sender, EventArgs e)
        {

        }

        private void btnDetailExigence_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterEngagement_Click(object sender, EventArgs e)
        {
            var frmDetailEngagement  = new DetailEngagement();
            frmDetailEngagement.ShowDialog();

        }

        private void btnAjouterExigence_Click(object sender, EventArgs e)
        {
            var frmDetailExigence = new DetailExigence();
            frmDetailExigence.ShowDialog();
        }

        private void cmbNomAgence_Format(object sender, ListControlConvertEventArgs e)
        {
            var itemAFormatter = (e.ListItem as Modele.vueSomAgence);
            e.Value = itemAFormatter.noAgence + " / " + itemAFormatter.nom;
        }

        private void btnAjoutAgence_Click(object sender, EventArgs e)
        {
            SommaireAgence sommaireAgence = new SommaireAgence();
            sommaireAgence.ShowDialog();
            PeuplerListes();
        }

        private void chkIdemAgence_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIdemAgence.Checked)
            {
                txtSignataireAgence.Text = null;
                txtSignataireAgence.Enabled = false;
            }
            else
            {
                txtSignataireAgence.Enabled = true;
            }
        }

        private void chkIdemDiffuseur_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIdemDiffuseur.Checked)
            {
                txtSignataireDiffuseur.Text = null;
                txtSignataireDiffuseur.Enabled = false;
            }
            else
            {
                txtSignataireDiffuseur.Enabled = true;
            }

        }

        private void btnAjouterArtiste_Click(object sender, EventArgs e)
        {
            SommaireArtiste sA = new SommaireArtiste();
            sA.ShowDialog();
            PeuplerListes();
        }
    }
}
