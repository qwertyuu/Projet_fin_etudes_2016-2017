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
        enum listes { Tout, Artiste, Agence, Exigence, Engagement }
        Controleur.Details.DetailContrat conContrat;
        Controleur.Sommaires.SommaireAgence conSomAgence;
        Controleur.Details.DetailArtiste conArtiste;
        Controleur.Validation validation;
        Controleur.Sommaires.SommaireExigence conSomExi;
        Controleur.Sommaires.SommaireEngagement conSomEng;
        private string idContrat;
        private string idAgence;
        private int idDiffuseur;

        public DetailContrat()
        {
            InitializeComponent();
            InitComplet();
            idContrat = null;
            idDiffuseur = 1;
            btnEnregistrerContrat.Enabled = false;
            PeuplerListes();
            verifierStatut();
        }

        public void InitComplet()
        {
            //propriétés du datagridview engagement
            dgvEngagement.AutoGenerateColumns = false;
            dgvEngagement.RowHeadersVisible = false;
            dgvEngagement.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvEngagement.AllowUserToResizeRows = false;
            dgvEngagement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEngagement.MultiSelect = false;
            dgvEngagement.AllowUserToAddRows = false;
            dgvEngagement.ReadOnly = true;
            dgvEngagement.AllowUserToDeleteRows = false;


            //propriétés du datagridview exigence
            dgvExigence.AutoGenerateColumns = false;
            dgvExigence.RowHeadersVisible = false;
            dgvExigence.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvExigence.AllowUserToResizeRows = false;
            dgvExigence.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExigence.MultiSelect = false;
            dgvExigence.AllowUserToAddRows = false;
            dgvExigence.ReadOnly = true;
            dgvExigence.AllowUserToDeleteRows = false;


            conContrat = new Controleur.Details.DetailContrat();
            conSomAgence = new Controleur.Sommaires.SommaireAgence();
            conArtiste = new Controleur.Details.DetailArtiste();
            validation = new Controleur.Validation();
            conSomExi = new Controleur.Sommaires.SommaireExigence();
            conSomEng = new Controleur.Sommaires.SommaireEngagement();
        }

        public DetailContrat(string noContrat)
        {
            InitializeComponent();
            InitComplet();
            idContrat = noContrat;
            idDiffuseur = 1;
            PeuplerListes();
            PeuplerInterface();
            verifierStatut();
        }

        private void SelectionnerArtistes(Modele.tblContrat contratDuMoment)
        {
            var artistes = contratDuMoment.tblArtiste;
            for (int i = 0; i < lstArtiste.Items.Count; i++)
            {
                lstArtiste.SetSelected(i, artistes.Contains(lstArtiste.Items[i] as Modele.tblArtiste));
            }
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
            SelectionnerArtistes(contratDuMoment);

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

            //peupler le statut et associer les bon boutons de changement de statut
            lblStatutContrat.Text = contratDuMoment.tblStatut.nomStatut;
            verifierStatut();
        }

        private void PeuplerListes(listes l = listes.Tout)
        {
            switch (l)
            {
                case listes.Tout:
                    //peupler toutes les listes
                    cmbNomAgence.DataSource = conSomAgence.Tout();
                    lstArtiste.DataSource = conArtiste.Tout();
                    dgvExigence.DataSource = conSomExi.ToutPourContrat(idContrat).ToSortableBindingList();
                    dgvEngagement.DataSource = conSomEng.ToutPourContrat(idContrat).ToSortableBindingList();
                    break;
                case listes.Artiste:
                    //peupler les artistes
                    lstArtiste.DataSource = conArtiste.Tout();
                    break;
                case listes.Agence:
                    //peupler les agences
                    cmbNomAgence.DataSource = conSomAgence.Tout();
                    break;
                case listes.Exigence:
                    //peupler les exigences
                    dgvExigence.DataSource = conSomExi.ToutPourContrat(idContrat).ToSortableBindingList();
                    break;
                case listes.Engagement:
                    //peupler les engagements
                    dgvEngagement.DataSource = conSomEng.ToutPourContrat(idContrat).ToSortableBindingList();
                    break;
            }
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
            conContrat.SizeText(rtbCommentaire, numPoliceCommentaire.Value);
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
            conContrat.SizeText(rtbDescriptionContrat, numPoliceDescription.Value);
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
            btnEnregistrerContrat.Enabled = true;
            verifierStatut();
        }

        private void btnStatut2_Click(object sender, EventArgs e)
        {
            if (btnStatut2.Text == "Supprimer")
                lblStatutContrat.Text = "Supprimé";
            else if (btnStatut2.Text == "Annuler")
                lblStatutContrat.Text = "Annulé";
            btnEnregistrerContrat.Enabled = true;

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
                btnStatut2.Text = "Annuler";
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
            DetailEngagement frmDetailEngagement = new DetailEngagement(((Modele.vueSomEngagement)dgvEngagement.SelectedRows[0].DataBoundItem).noEngagement);
            frmDetailEngagement.ShowDialog();
            dgvEngagement.DataSource = null;
            dgvEngagement.DataSource = conSomEng.Tout().ToSortableBindingList();
        }

        private void btnDetailExigence_Click(object sender, EventArgs e)
        {
            DetailExigence frmDetailExigence = new DetailExigence(((Modele.vueSomExigence)dgvExigence.SelectedRows[0].DataBoundItem).noExigence);
            frmDetailExigence.ShowDialog();
            dgvExigence.DataSource = null;
            dgvExigence.DataSource = conSomExi.Tout().ToSortableBindingList();
        }

        private void btnAjouterEngagement_Click(object sender, EventArgs e)
        {
            var frmDetailEngagement = new DetailEngagement();
            frmDetailEngagement.ShowDialog();
            PeuplerListes(listes.Engagement);

        }

        private void btnAjouterExigence_Click(object sender, EventArgs e)
        {
            var frmDetailExigence = new DetailExigence();
            frmDetailExigence.ShowDialog();
            PeuplerListes(listes.Exigence);
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
            PeuplerListes(listes.Agence);
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
            PeuplerListes(listes.Artiste);
            var contratDuMoment = conContrat.SelectContrat(idContrat);
            if (contratDuMoment != null)
            {
                SelectionnerArtistes(contratDuMoment);
            }
        }

        private void btnEnregistrerContrat_Click(object sender, EventArgs e)
        {
            string mes = "";
            if (txtNumeroContrat.Text == "" || txtNomContrat.Text == "")
            {
                MessageBox.Show("Veuillez entrer le numéro et le nom du contrat");
                return;
            }
            else
            {
                if (!validation.ValiderChampRespo(txtNomResponsableAgence.Text, txtPrenomResponsableAgence.Text, txtCourrielAgence.Text) && cmbNomAgence.SelectedIndex == -1)
                {
                    MessageBox.Show(validation.MessVide + " de l'agence");
                    return;
                }
                else
                {
                    if (!validation.ValiderChampRespo(txtNomResponsableDiffuseur.Text, txtPrenomResponsableDiffuseur.Text, txtCourrielDiffuseur.Text))
                    {
                        MessageBox.Show(validation.MessVide + " du diffuseur");
                        return;
                    }
                }
            }
            var contratEcrit = conContrat.SelectContrat(txtNumeroContrat.Text);
            if (idContrat == null && contratEcrit != null)
            {
                if (MessageBox.Show(string.Format("Le numéro de contrat que vous avez entré existe déjà sous le nom de {0}\nVoulez-vous l'écraser?", contratEcrit.nom), "Contrat existant", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            idAgence = (cmbNomAgence.SelectedItem as Modele.vueSomAgence).noAgence;

            //On enregistre le responsable de l'agence
            var responsableAgence = conContrat.EnregistrerResponsable(txtNumeroContrat.Text, txtNomResponsableAgence.Text, txtPrenomResponsableAgence.Text, txtCourrielAgence.Text, txtCellulaireAgence.Text, txtTelephoneAgence.Text, txtExtensionTelephoneAgence.Text, txtSignataireAgence.Text, dateSignatureAgence.Value, chkIdemAgence.Checked, idAgence, null);
            //On enregistre le responsable du  diffuseur
            var responsableDiffuseur = conContrat.EnregistrerResponsable(txtNumeroContrat.Text, txtNomResponsableDiffuseur.Text, txtPrenomResponsableDiffuseur.Text, txtCourrielDiffuseur.Text, txtCellulaireDiffuseur.Text, txtTelephoneDiffuseur.Text, txtExtensionTelephoneDiffuseur.Text, txtSignataireDiffuseur.Text, dateSignatureDiffuseur.Value, chkIdemDiffuseur.Checked, null, idDiffuseur);

            if (!conContrat.EnregistrerContrat(idContrat, txtNumeroContrat.Text, txtNomContrat.Text, txtLieuContrat.Text, rtbCommentaire.Rtf, rtbDescriptionContrat.Rtf, lblStatutContrat.Text, idAgence, responsableAgence, responsableDiffuseur))
            {
                mes = "Le contrat a été modifiée avec succès";
            }
            else
            {
                mes = "Le contrat a été ajouté avec succès";
            }
            MessageBox.Show(mes);
            this.Close();

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Si vous fermez vous allez perdre les données déja saisies. Voulez-vous fermer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}