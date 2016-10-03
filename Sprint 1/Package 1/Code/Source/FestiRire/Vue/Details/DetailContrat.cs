using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FestiRire.Modele;

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
            dateSignatureAgence.CustomFormat = " ";
            dateSignatureDiffuseur.CustomFormat = " ";
            idDiffuseur = 1;
            btnEnregistrerContrat.Enabled = false;
            PeuplerListes();
            lstArtiste.ClearSelected();
            verifierStatut();
        }

        public void EnleverEtoile(bool Etat)
        {
            lbl0.Visible = Etat; lbl7.Visible = Etat;
            lbl1.Visible = Etat;
            lbl2.Visible = Etat;
            lbl3.Visible = Etat;
            lbl4.Visible = Etat;
            lbl5.Visible = Etat;
            lbl6.Visible = Etat;

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
            SelectionnerAgence(contratDuMoment);

            //sélectionner les artistes liés au contrat
            SelectionnerArtistes(contratDuMoment);

            //peupler le responsable de l'agence
            var ResponsableAgence = conContrat.ResponsableAgence(idContrat);
            if (ResponsableAgence != null)
            {
                txtNomResponsableAgence.Text = ResponsableAgence.nom;
                txtPrenomResponsableAgence.Text = ResponsableAgence.prenom;
                txtCellulaireAgence.Text = conContrat.FormatTelephone(ResponsableAgence.telCellulaire);
                txtCourrielAgence.Text = ResponsableAgence.courriel;
                txtTelephoneAgence.Text = conContrat.FormatTelephone(ResponsableAgence.telBureau);
                txtSignataireAgence.Text = ResponsableAgence.signataire;
                if (ResponsableAgence.dateSignature == null)
                {
                    dateSignatureAgence.CustomFormat = " ";
                }
                else
                {
                    dateSignatureAgence.Value = (DateTime)ResponsableAgence.dateSignature;
                }
                txtExtensionTelephoneAgence.Text = ResponsableAgence.extension;
                chkIdemAgence.Checked = ResponsableAgence.idem;
            }

            //peupler le responsable du diffuseur
            var ResponsableDiffuseur = conContrat.ResponsableDiffuseur(idContrat);
            if (ResponsableDiffuseur != null)
            {
                txtNomResponsableDiffuseur.Text = ResponsableDiffuseur.nom;
                txtPrenomResponsableDiffuseur.Text = ResponsableDiffuseur.prenom;
                txtCellulaireDiffuseur.Text = conContrat.FormatTelephone(ResponsableDiffuseur.telCellulaire);
                txtCourrielDiffuseur.Text = ResponsableDiffuseur.courriel;
                txtTelephoneDiffuseur.Text = conContrat.FormatTelephone(ResponsableDiffuseur.telBureau);
                txtSignataireDiffuseur.Text = ResponsableDiffuseur.signataire;
                if (ResponsableDiffuseur.dateSignature == null)
                {
                    dateSignatureDiffuseur.CustomFormat = " ";
                }
                else
                {
                    dateSignatureDiffuseur.Value = (DateTime)ResponsableDiffuseur.dateSignature;
                }
                txtExtensionTelephoneDiffuseur.Text = ResponsableDiffuseur.extension;
                chkIdemDiffuseur.Checked = ResponsableDiffuseur.idem;
            }

            //peupler le statut et associer les bon boutons de changement de statut
            lblStatutContrat.Text = contratDuMoment.tblStatut.nomStatut;
            verifierStatut();
        }

        private void SelectionnerAgence(tblContrat contratDuMoment)
        {
            cmbNomAgence.SelectedItem = (cmbNomAgence.DataSource as List<Modele.vueSomAgence>).SingleOrDefault(a => a.noAgence == contratDuMoment.noAgence);
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
                if (txtNomContrat.Text == "" || txtNumeroContrat.Text == "")
                    MessageBox.Show("Vous devez d'abord entrer le numéro et le nom du contrat avant de changer de statut");
                else
                {
                    if (MessageBox.Show(("Si vous passez le statut du contrat à En cours, le numéro, le nom et lieu du contrat ne seront plus modifiable.\nVoulez-vous changer de statut?"), "Changement de statut", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        txtNumeroContrat.Enabled = false;
                        txtNomContrat.Enabled = false;
                        lblStatutContrat.Text = "En cours";
                        EnleverEtoile(true);
                    }
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
                EnleverEtoile(false);
            }
            else if (lblStatutContrat.Text == "En cours")
            {
                btnStatut1.Text = "Terminé";
                btnStatut1.Visible = true;
                btnStatut2.Text = "Annuler";
                btnStatut2.Visible = true;
                EnleverEtoile(true);

            }
            else if (lblStatutContrat.Text == "Annulé" || lblStatutContrat.Text == "Supprimé" || lblStatutContrat.Text == "Terminé")
            {
                
                if(!verifierChampRespo())
                {
                    return;
                }
                btnStatut1.Visible = false;
                btnStatut2.Visible = false;
                DesactiverTout(this);

            }
        }
        private void DesactiverTout(Control container)
        {
            foreach (Control c in container.Controls)
            {
                DesactiverTout(c);
                if (c is TextBox || c is ComboBox || c is ListBox || c is Button || c is NumericUpDown || c is CheckBox || c is DateTimePicker || c is RichTextBox)
                {
                    if (c.Text != "Fermer" || c.Text != "Enregistrer")
                    {
                        c.Enabled = false;
                    }
                }
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
            if (dgvEngagement.SelectedRows.Count == 0)
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
            var contratDuMoment = conContrat.SelectContrat(idContrat);
            if (contratDuMoment != null)
            {
                //sélectionner la bonne agence
                SelectionnerAgence(contratDuMoment);
            }
        }

        private void chkIdemAgence_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIdemAgence.Checked)
            {
                txtSignataireAgence.Text = null;
                txtSignataireAgence.Enabled = false;
                lblSiAgen.Visible = false;

            }
            else
            {
                txtSignataireAgence.Enabled = true;
                lblSiAgen.Visible = true;
            }
        }

        private void chkIdemDiffuseur_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIdemDiffuseur.Checked)
            {
                txtSignataireDiffuseur.Text = null;
                txtSignataireDiffuseur.Enabled = false;
                lblSigDiff.Visible = false;
            }
            else
            {
                txtSignataireDiffuseur.Enabled = true;
                lblSigDiff.Visible = true;
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

        public bool verifierChampRespo()
        {
             if (conContrat.SanitariserTexte(txtNumeroContrat.Text) == null || conContrat.SanitariserTexte(txtNomContrat.Text) == null)
            {
                MessageBox.Show("Veuillez entrer le numéro et le nom du contrat");
                return false;
            }

            if (lblStatutContrat.Text == "En cours" || lblStatutContrat.Text == "Terminé")
            {
                if (conContrat.SanitariserTexte(txtLieuContrat.Text) == null)
                {
                    MessageBox.Show("Veuillez entrez le lieu du contrat");
                    return false;
                }
                if (lstArtiste.SelectedIndex == -1)
                {
                    MessageBox.Show("Veuillez selectionner au moins un artiste");
                    return false;
                }
                if (dgvEngagement.SelectedRows.Count != 0)
                {
                    if (dgvEngagement.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Veuillez selectionner au  moins un engagement");
                        return false;
                    }
                }
                if (!validation.ValiderChampRespo(txtNomResponsableAgence.Text, txtPrenomResponsableAgence.Text, txtCourrielAgence.Text))
                {
                    MessageBox.Show(validation.MessVide + " de l'agence");
                    return false;
                }
                else
                {
                    if (!validation.IsValidEmail(txtCourrielAgence.Text))
                    {
                        MessageBox.Show("Courriel  de l'agence invalide");
                        return false;
                    }
                }
                if (!validation.ValiderChampRespo(txtNomResponsableDiffuseur.Text, txtPrenomResponsableDiffuseur.Text, txtCourrielDiffuseur.Text))
                {
                    MessageBox.Show(validation.MessVide + " du diffuseur");
                    return false;
                }
                else
                {
                    if (!validation.IsValidEmail(txtCourrielDiffuseur.Text))
                    {
                        MessageBox.Show("Courriel  du diffuseur invalide");
                        return false;
                    }
                }


                //On verifie si la date est bien dans le futur
                if (!validation.ValiderChampDate(dateSignatureAgence) || !validation.ValiderChampDate(dateSignatureDiffuseur))
                {
                    MessageBox.Show(validation.MessVide);
                    return false;
                }

                //On verifie si Idem a été coché ou pas.
                if (!validation.IdemIsChecked(chkIdemAgence.Checked, txtSignataireAgence.Text))
                {
                    MessageBox.Show(validation.MessVide + " de l'agence.");
                    return false;
                }
                if (!validation.IdemIsChecked(chkIdemDiffuseur.Checked, txtSignataireDiffuseur.Text))
                {
                    MessageBox.Show(validation.MessVide + " du diffusseur.");
                    return false;
                }

                //On verifie les numéros de téléphones
                validation.verifierTel(txtTelephoneAgence.Text, txtCellulaireAgence.Text, txtExtensionTelephoneAgence.Text);
                if (validation.MessTel != "")
                {
                    MessageBox.Show(validation.MessTel + " de l'agence");
                    return false;
                }
                validation.verifierTel(txtTelephoneDiffuseur.Text, txtCellulaireDiffuseur.Text, txtExtensionTelephoneDiffuseur.Text);
                if (validation.MessTel != "")
                {
                    MessageBox.Show(validation.MessTel + " du diffusseur");
                    return false;
                }

            }
            if (cmbNomAgence.SelectedItem == null)
            {
                MessageBox.Show("Vous devez choisir une agence");
                return false;
            }

            return true;

        }
        private void btnEnregistrerContrat_Click(object sender, EventArgs e)
        {
            string mes = "";
            verifierChampRespo();

          //Si tout se passe bien on débute l'enregistrement du contrat.
          var contratEcrit = conContrat.SelectContrat(txtNumeroContrat.Text);
            if (idContrat == null && contratEcrit != null)
            {
                if (MessageBox.Show(string.Format("Le numéro de contrat que vous avez entré existe déjà sous le nom de {0}\nVoulez-vous l'écraser?", contratEcrit.nom), "Contrat existant", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            idAgence = (cmbNomAgence.SelectedItem as Modele.vueSomAgence).noAgence;
            Modele.tblResponsable responsableAgence = null;
            Modele.tblResponsable responsableDiffuseur = null;

            if (!validation.ValiderChampRespo(txtNomResponsableAgence.Text, txtPrenomResponsableAgence.Text, txtCourrielAgence.Text))
            {
                MessageBox.Show("Le responsable de l'agence n'a pas pu être enregistré car un des champs obligatoire est vide.");
            }
            else
            {
                if (!validation.IsValidEmail(txtCourrielAgence.Text))
                {
                    MessageBox.Show("Le responsable de l'agence n'a pas pu être enregistré car le format du courriel est invalide.");
                }
                else
                {
                    //On enregistre le responsable de l'agence
                    DateTime? dateSignature = null;
                    if (dateSignatureAgence.CustomFormat != " ")
                    {
                        dateSignature = dateSignatureAgence.Value;
                    }
                    responsableAgence = conContrat.EnregistrerResponsable(txtNumeroContrat.Text, txtNomResponsableAgence.Text, txtPrenomResponsableAgence.Text, txtCourrielAgence.Text, txtCellulaireAgence.Text, txtTelephoneAgence.Text, txtExtensionTelephoneAgence.Text, txtSignataireAgence.Text, dateSignature, chkIdemAgence.Checked, idAgence, null);
                }
            }


            if (!validation.ValiderChampRespo(txtNomResponsableDiffuseur.Text, txtPrenomResponsableDiffuseur.Text, txtCourrielDiffuseur.Text))
            {
                MessageBox.Show("Le responsable du diffuseur n'a pas pu être enregistré car un des champs obligatoire est vide.");
            }
            else
            {
                if (!validation.IsValidEmail(txtCourrielDiffuseur.Text))
                {
                    MessageBox.Show("Le responsable du diffuseur n'a pas pu être enregistré car le format du courriel est invalide.");
                }
                else
                {
                    //On enregistre le responsable du  diffuseur
                    DateTime? dateSignature = null;
                    if (dateSignatureDiffuseur.CustomFormat != " ")
                    {
                        dateSignature = dateSignatureDiffuseur.Value;
                    }
                    responsableDiffuseur = conContrat.EnregistrerResponsable(txtNumeroContrat.Text, txtNomResponsableDiffuseur.Text, txtPrenomResponsableDiffuseur.Text, txtCourrielDiffuseur.Text, txtCellulaireDiffuseur.Text, txtTelephoneDiffuseur.Text, txtExtensionTelephoneDiffuseur.Text, txtSignataireDiffuseur.Text, dateSignature, chkIdemDiffuseur.Checked, null, idDiffuseur);
                }
            }
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
            this.Close();
        }

        private void dateSignatureAgence_ValueChanged(object sender, EventArgs e)
        {
            dateSignatureAgence.Format = DateTimePickerFormat.Long;
        }

        private void dateSignatureDiffuseur_ValueChanged(object sender, EventArgs e)
        {
            dateSignatureDiffuseur.Format = DateTimePickerFormat.Long;
        }
    }
}