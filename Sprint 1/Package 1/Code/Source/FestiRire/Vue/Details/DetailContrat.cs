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
        Controleur.Validation validation = new Controleur.Validation();
        private string idContrat;
        private string idAgence;
        private int idDiffuseur;

        public DetailContrat()
        {
            InitializeComponent();
            conContrat = new Controleur.Details.DetailContrat();
            conSomAgence = new Controleur.Sommaires.SommaireAgence();
            conArtiste = new Controleur.Details.DetailArtiste();
            idContrat = null;
            idDiffuseur = 1;
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
            idDiffuseur = 1;
            PeuplerListes();
            PeuplerInterface();
            verifierStatut();
        }

        private string ExtraitNoAgence(string no)
        {
            int i = 0;
            string noExtrait = "";
            while (no[i] != '/')
            {
                noExtrait += no[i];
                i++;
            }
            return noExtrait;

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
            var frmDetailEngagement = new DetailEngagement();
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
            string mes = "";
            MessageBox.Show(DisplayObjectInfo(conContrat.SelectContrat(txtNumeroContrat.Text)));
            return;
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
            

            //On enregistre le responsable de l'agence
            conContrat.EnregistrerResponsable(idContrat, txtNomResponsableAgence.Text, txtPrenomResponsableAgence.Text, txtCourrielAgence.Text, txtCellulaireAgence.Text, txtTelephoneAgence.Text, txtExtensionTelephoneAgence.Text, txtSignataireAgence.Text, dateSignatureAgence.Value, chkIdemAgence.Checked, idAgence, idDiffuseur);
            //On enregistre le responsable du  diffuseur
            conContrat.EnregistrerResponsable(idContrat, txtNomResponsableDiffuseur.Text, txtPrenomResponsableDiffuseur.Text, txtCourrielDiffuseur.Text, txtCellulaireDiffuseur.Text, txtTelephoneDiffuseur.Text, txtExtensionTelephoneDiffuseur.Text, txtSignataireDiffuseur.Text, dateSignatureDiffuseur.Value, chkIdemDiffuseur.Checked, null, idDiffuseur);

            if (!conContrat.EnregistrerContrat(idContrat,txtNumeroContrat.Text, txtNomContrat.Text, txtLieuContrat.Text, rtbCommentaire.Rtf, rtbDescriptionContrat.Rtf, lblStatutContrat.Text, idAgence))
            {
                mes = "Le contrat a été modifiée  avec succés";
            }
            else
            {
                mes = "Le contrat a été ajouté  avec succés";
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

        public static string DisplayObjectInfo(Object o)
        {
            StringBuilder sb = new StringBuilder();

            // Include the type of the object
            System.Type type = o.GetType();
            sb.Append("Type: " + type.Name);

            // Include information for each Field
            sb.Append("\r\n\r\nFields:");
            System.Reflection.FieldInfo[] fi = type.GetFields();
            if (fi.Length > 0)
            {
                foreach (System.Reflection.FieldInfo f in fi)
                {
                    sb.Append("\r\n " + f.ToString() + " = " +
                              f.GetValue(o));
                }
            }
            else
                sb.Append("\r\n None");

            // Include information for each Property
            sb.Append("\r\n\r\nProperties:");
            System.Reflection.PropertyInfo[] pi = type.GetProperties();
            if (pi.Length > 0)
            {
                foreach (System.Reflection.PropertyInfo p in pi)
                {
                    sb.Append("\r\n " + p.ToString() + " = " +
                              p.GetValue(o, null));
                }
            }
            else
                sb.Append("\r\n None");

            return sb.ToString();
        }
    }
}