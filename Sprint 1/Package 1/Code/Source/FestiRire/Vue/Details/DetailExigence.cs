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
    public partial class DetailExigence : Form
    {
        Controleur.Details.DetailExigence conExigence = new Controleur.Details.DetailExigence();
        Controleur.Sommaires.SommaireStatut conStatut = new Controleur.Sommaires.SommaireStatut();
        int? idExigence;
        public DetailExigence()
        {
            InitializeComponent();
            idExigence = null;
        }

        private void btnEnregistrerExigence_Click(object sender, EventArgs e)
        {
            if (idExigence != null)
            {
                conExigence.EnregistrerExigence((int)idExigence, txtNom.Text, dateExigence.Value, txtMontant.Text, cmbStatut.SelectedItem, cmbEvenement.SelectedItem, rtbCommentaire.Text, rtbDescriptionCourte.Text, rtbDescriptionLongue.Text);
                MessageBox.Show("Exigence Modifiée");
            }
            else
            {
                conExigence.EnregistrerExigence(txtNom.Text, dateExigence.Value, txtMontant.Text, cmbStatut.SelectedItem, cmbEvenement.SelectedItem, rtbCommentaire.Text, rtbDescriptionCourte.Text, rtbDescriptionLongue.Text);
                MessageBox.Show("Exigence Ajoutée");
            }
            this.Close();

        }

        public DetailExigence(int _idExigence)
        {
            InitializeComponent();
            idExigence = _idExigence;
            cmbStatut.DataSource = conStatut.Tout();
            PeuplerInterface(conExigence.LoadExigence(_idExigence));
        }

        private void PeuplerInterface(Modele.tblExigence _Exigence)
        {
            txtNom.Text = _Exigence.nom;
            dateExigence.Value = _Exigence.date ?? default(DateTime);

            txtMontant.Text = (_Exigence.montant ?? 0).ToString();
            cmbStatut.SelectedItem = _Exigence.tblStatut;
            rtbCommentaire.Text = _Exigence.commentaire;
            //txtPrixBillet.Text = _Exigence.;
            //txtCapacite.Text = conExigence.FormatTelephone(_Exigence.tblAdresse.telCellulaire);
            rtbDescriptionCourte.Text = _Exigence.descriptionCourte;
            rtbDescriptionLongue.Text = _Exigence.description;
        }
    }
}
