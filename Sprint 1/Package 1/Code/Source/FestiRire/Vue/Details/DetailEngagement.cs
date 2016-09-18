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
    public partial class DetailEngagement : Form
    {
        Controleur.Details.DetailEngagement conEngagement = new Controleur.Details.DetailEngagement();
        Controleur.Validation validation = new Controleur.Validation();
        int? idEngagement;
        public DetailEngagement()
        {
            InitializeComponent();
            DesactiverBtnSupp();
        }

        private void btnEnregistrerEngagement_Click(object sender, EventArgs e)
        {
            if(txtNatureEngagement.Text=="" || txtLieu.Text=="")
            {
                MessageBox.Show("Veuillez entrer la nature et le lieu de l'engagement.");
                return;
            }
            else
            {
                if(!validation.ValiderChampDate(dateEngagement))
                {
                    MessageBox.Show(validation.MessVide);
                    return;
                }
                else
                {
                    if (idEngagement != null)
                    {
                        conEngagement.EnregistrerEngagement((int)idEngagement, txtNatureEngagement.Text, dateEngagement.Value, (int)numHeure.Value, (int)numMinute.Value, txtDuree.Text, txtLieu.Text, rtbCommentaire.Text, txtPrixBillet.Text, txtCapacite.Text, rtbDescriptionCourte.Text, rtbDescriptionLongue.Text);
                        MessageBox.Show("Engagement Modifié");
                    }
                    else
                    {
                        conEngagement.EnregistrerEngagement(txtNatureEngagement.Text, dateEngagement.Value, (int)numHeure.Value, (int)numMinute.Value, txtDuree.Text, txtLieu.Text, rtbCommentaire.Text, txtPrixBillet.Text, txtCapacite.Text, rtbDescriptionCourte.Text, rtbDescriptionLongue.Text);
                        MessageBox.Show("Engagement Ajouté");
                    }
                    this.Close();
                }
            }



        }

        public DetailEngagement(int idEngagement)
        {
            InitializeComponent();
            this.idEngagement = idEngagement;
            PeuplerInterface(conEngagement.LoadEngagement(idEngagement));
        }

        private void PeuplerInterface(Modele.tblEngagement _Engagement)
        {
            txtNatureEngagement.Text = _Engagement.nature;
            dateEngagement.Value = _Engagement.date ?? default(DateTime);
            if (_Engagement.heure.HasValue)
            {
                numHeure.Value = _Engagement.heure.Value.Hours;
                numMinute.Value = _Engagement.heure.Value.Minutes;
            }
            txtDuree.Text = _Engagement.duree;
            txtLieu.Text = _Engagement.lieu;
            rtbCommentaire.Text = _Engagement.commentaire;
            //txtPrixBillet.Text = _Engagement.;
            //txtCapacite.Text = conEngagement.FormatTelephone(_Engagement.tblAdresse.telCellulaire);
            rtbDescriptionCourte.Text = _Engagement.descriptionCourte;
            rtbDescriptionLongue.Text = _Engagement.description;
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

        private void btnSupprimerEngagement_Click(object sender, EventArgs e)
        {
            if (idEngagement != null)
            {
                DialogResult result = result = MessageBox.Show("Voulez-vous supprimer cet exigence?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    conEngagement.SupprimerEngagement((int)idEngagement);
                    MessageBox.Show("Exigence supprimée avec succès");
                    this.Close();
                }

            }
        }

        public void DesactiverBtnSupp()
        {
            btnSupprimerEngagement.Enabled = false;
        }

        //Gestion des styles de commentaire et description.
        private void btnGrasCommentaire_Click(object sender, EventArgs e)
        {
            conEngagement.TextGras(rtbCommentaire);
        }

        private void btnSouslignerCommentaire_Click(object sender, EventArgs e)
        {
            conEngagement.TextUderline(rtbCommentaire);
        }

        private void btnItaliqueCommentaire_Click(object sender, EventArgs e)
        {
            conEngagement.TextItalic(rtbCommentaire);
        }

        private void numPoliceCommentaire_ValueChanged(object sender, EventArgs e)
        {
            conEngagement.SizeText(rtbCommentaire,numPoliceCommentaire.Value);
        }

        private void btnEnumCommentaire_Click(object sender, EventArgs e)
        {
            conEngagement.EnumText(rtbCommentaire);
        }

        private void btnGrasDescriptionLongue_Click(object sender, EventArgs e)
        {
            conEngagement.TextGras(rtbDescriptionLongue);
        }

        private void btnItaliqueDescriptionLongue_Click(object sender, EventArgs e)
        {
            conEngagement.TextItalic(rtbDescriptionLongue);
        }

        private void btnSouslignerDescriptionLongue_Click(object sender, EventArgs e)
        {
            conEngagement.TextUderline(rtbDescriptionLongue);
        }

        private void numPoliceDescriptionLongue_ValueChanged(object sender, EventArgs e)
        {
            conEngagement.TextUderline(rtbDescriptionLongue);
        }

        private void btnEnumDescriptionLongue_Click(object sender, EventArgs e)
        {
            conEngagement.EnumText(rtbDescriptionLongue);
        }


    }
}
