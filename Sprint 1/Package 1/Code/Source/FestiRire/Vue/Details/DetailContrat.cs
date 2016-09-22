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
        Controleur.Details.DetailStatut conStatut;
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
            conStatut = new Controleur.Details.DetailStatut();
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
            txtNumeroContrat.Enabled = false;
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

        private void PeuplerExigence()
        {
            dgvExigence.DataSource = conSomExi.ToutPourContrat(idContrat)
                .Select(a => new { date = a.date, nom = a.nom, montant = a.montant, statut = conStatut.LoadStatut(a.noStatut).nomStatut, description = a.descriptionCourte, noExigence = a.noExigence })
                .ToList()
                .ToSortableBindingList();
        }

        private void PeuplerListes(listes l = listes.Tout)
        {
            switch (l)
            {
                case listes.Tout:
                    //peupler toutes les listes
                    cmbNomAgence.DataSource = conSomAgence.Tout();
                    lstArtiste.DataSource = conArtiste.Tout();
                    PeuplerExigence();
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
                    PeuplerExigence();
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
            {
                lblStatutContrat.Text = "En négociation";
            }

            else if (btnStatut1.Text == "En cours")
            {
                if (MessageBox.Show(("Si vous passez le statut du contrat à En cours, le numéro, le nom et lieu du contrat ne seront plus modifiable.\nVoulez-vous changer de statut?"), "Changement de statut", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtNumeroContrat.Enabled = false;
                    txtNomContrat.Enabled = false;
                    lblStatutContrat.Text = "En cours";
                }
            }
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
            if (idContrat == null)
            {
                MessageBox.Show("Vous devez enregistrer le contrat afin de pouvoir accéder au détail d'un engagement");
                return;
            }
            if (dgvEngagement.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vous devez avoir au moins une exigence dans la grille avant d'appuyer sur détail");
            }
            else
            {
                DetailEngagement frmDetailEngagement = new DetailEngagement(((Modele.vueSomEngagement)dgvEngagement.SelectedRows[0].DataBoundItem).noEngagement);
                frmDetailEngagement.ShowDialog();
                PeuplerListes(listes.Engagement);
            }

        }

        private void btnDetailExigence_Click(object sender, EventArgs e)
        {
            if (idContrat == null)
            {
                MessageBox.Show("Vous devez enregistrer le contrat afin de pouvoir accéder au détail d'une exigence");
                return;
            }
            if (dgvEngagement.SelectedRows.Count != 0)
            {
                MessageBox.Show("Vous devez avoir au moins un engagement dans la grille avant d'appuyer sur détail");
            }
            else
            {
                //tricottage pour aller chercher le numero d'exigence d'un type anonyme utilisé pour l'affichage
                int noExigence = (int)dgvExigence.SelectedRows[0].DataBoundItem.GetType().GetProperty("noExigence").GetValue(dgvExigence.SelectedRows[0].DataBoundItem, null);
                DetailExigence frmDetailExigence = new DetailExigence(noExigence);
                frmDetailExigence.ShowDialog();
                PeuplerListes(listes.Exigence);
            }

        }

        private void btnAjouterEngagement_Click(object sender, EventArgs e)
        {
            if (idContrat == null)
            {
                MessageBox.Show("Vous devez enregistrer le contrat afin de pouvoir ajouter un engagement");
                return;
            }
            var frmDetailEngagement = new DetailEngagement(idContrat);
            frmDetailEngagement.ShowDialog();
            PeuplerListes(listes.Engagement);

        }

        private void btnAjouterExigence_Click(object sender, EventArgs e)
        {
            if (idContrat == null)
            {
                MessageBox.Show("Vous devez enregistrer le contrat afin de pouvoir ajouter une exigence");
                return;
            }
            var frmDetailExigence = new DetailExigence(idContrat);
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
            //bool SaveRepoAgence = true;
            //bool SaveRespoDiffusseur = true;
            if (txtNumeroContrat.Text == "" || txtNomContrat.Text == "")
            {
                MessageBox.Show("Veuillez entrer le numéro et le nom du contrat");
                return;
            }

            if (lblStatutContrat.Text == "En cours")
            {
                if (txtLieuContrat.Text == "")
                {
                    MessageBox.Show("Veuillez entrez le lieu du contrat");
                    return;
                }

                if (lstArtiste.SelectedIndex == -1)
                {
                    MessageBox.Show("Veuillez selectionner au moins un artiste");
                    return;
                }

                //if (dgvEngagement.SelectedRows.Count==0)
                //{
                //    MessageBox.Show("Veuillez au moins un engagement");
                //    return;
                //}
                if (!validation.ValiderChampRespo(txtNomResponsableAgence.Text, txtPrenomResponsableAgence.Text, txtCourrielAgence.Text))
                {
                    MessageBox.Show(validation.MessVide + " de l'agence");
                    return;
                }
                if (!validation.ValiderChampRespo(txtNomResponsableDiffuseur.Text, txtPrenomResponsableDiffuseur.Text, txtCourrielDiffuseur.Text))
                {
                    MessageBox.Show(validation.MessVide + " du diffuseur");
                    return;
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
            string noContratAjoute = "";
            if (!conContrat.EnregistrerContrat(idContrat, txtNumeroContrat.Text, txtNomContrat.Text, txtLieuContrat.Text, rtbCommentaire.Rtf, rtbDescriptionContrat.Rtf, lblStatutContrat.Text, idAgence, responsableAgence, responsableDiffuseur, lstArtiste.SelectedItems.Cast<Modele.tblArtiste>().ToList(), out noContratAjoute))
            {
                mes = "Les informations du contrat ont été mis à jour";
            }
            else
            {
                idContrat = noContratAjoute;
                mes = "Le contrat a été créé avec succès";
            }
            MessageBox.Show(mes);

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