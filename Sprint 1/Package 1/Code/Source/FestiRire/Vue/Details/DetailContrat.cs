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
            //peupler les informations qui viennent directement du contrat lui-meme
            var contratDuMoment = conContrat.SelectContrat(idContrat);
            txtNumeroContrat.Text = contratDuMoment.noContrat;
            txtNomContrat.Text = contratDuMoment.nom;
            txtLieuContrat.Text = contratDuMoment.lieu;
            rtbCommentaire.Rtf = contratDuMoment.commentaire;
            rtbDescriptionContrat.Rtf = contratDuMoment.description;

            //sélectionner la bonne agence
            cmbNomAgence.SelectedItem = conSomAgence.Tout().SingleOrDefault(a => a.noAgence == contratDuMoment.noAgence);

            //sélectionner les artistes liés au contrat
            var artistes = contratDuMoment.tblArtiste;
            for (int i = 0; i < lstArtiste.Items.Count; i++)
            {
                lstArtiste.SetSelected(i, artistes.Contains(lstArtiste.Items[i] as Modele.tblArtiste));
            }

            //peupler le responsable de l'agence
            var ResponsableAgence = conContrat.ResponsableAgence(idContrat);
            txtNomResponsableAgence.Text = ResponsableAgence.nom;
            txtPrenomResponsableAgence.Text = ResponsableAgence.prenom;
            txtCellulaireAgence.Text = conContrat.FormatTelephone(ResponsableAgence.telCellulaire);
            txtCourrielAgence.Text = ResponsableAgence.courriel;
            txtTelephoneAgence.Text = conContrat.FormatTelephone(ResponsableAgence.telBureau);
            txtSignataireAgence.Text = ResponsableAgence.signataire;
            dateSignatureAgence.Value = ResponsableAgence.dateSignature ?? DateTime.Now;
            txtExtensionTelephoneAgence.Text = ResponsableAgence.extension;
            chkIdemAgence.Checked = ResponsableAgence.idem;


            //peupler le responsable du diffuseur
            var ResponsableDiffuseur = conContrat.ResponsableDiffuseur(idContrat);
            txtNomResponsableDiffuseur.Text = ResponsableDiffuseur.nom;
            txtPrenomResponsableDiffuseur.Text = ResponsableDiffuseur.prenom;
            txtCellulaireDiffuseur.Text = conContrat.FormatTelephone(ResponsableDiffuseur.telCellulaire);
            txtCourrielDiffuseur.Text = ResponsableDiffuseur.courriel;
            txtTelephoneDiffuseur.Text = conContrat.FormatTelephone(ResponsableDiffuseur.telBureau);
            txtSignataireDiffuseur.Text = ResponsableDiffuseur.signataire;
            dateSignatureDiffuseur.Value = ResponsableDiffuseur.dateSignature ?? DateTime.Now;
            txtExtensionTelephoneDiffuseur.Text = ResponsableDiffuseur.extension;
            chkIdemDiffuseur.Checked = ResponsableDiffuseur.idem;

            //peupler les exigences

            //dgvExigence.DataSource
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
            else if (lblStatutContrat.Text == "Annulé" || lblStatutContrat.Text == "Supprimé" || lblStatutContrat.Text == "Terminé")
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

        private void btnEnregistrerContrat_Click(object sender, EventArgs e)
        {

        }
    }
}
