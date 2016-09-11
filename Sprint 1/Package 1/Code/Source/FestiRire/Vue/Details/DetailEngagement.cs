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
        bool modeCreation;
        public DetailEngagement()
        {
            InitializeComponent();
            modeCreation = true;
        }

        private void btnEnregistrerEngagement_Click(object sender, EventArgs e)
        {
            conEngagement.EnregistrerEngagement(txtNatureEngagement.Text, dateEngagement.Value, txtHeure.Text, txtDuree.Text, txtLieu.Text, rtbCommentaire.Text, txtPrixBillet.Text, txtCapacite.Text, rtbDescriptionCourte.Text, rtbDescriptionLongue.Text);
            if (!modeCreation)
            {
                MessageBox.Show("Engagement Modifié");
            }
            else
            {
                MessageBox.Show("Engagement Ajouté");
            }
            this.Close();

        }

        public DetailEngagement(int idEngagement)
        {
            InitializeComponent();
            modeCreation = false;
            PeuplerInterface(conEngagement.LoadEngagement(idEngagement));
        }

        private void PeuplerInterface(Modele.tblEngagement _Engagement)
        {
            txtNatureEngagement.Text = _Engagement.nature;
            dateEngagement.Value = _Engagement.date ?? default(DateTime);
            //txtHeure.Text = _Engagement.heure;
            txtDuree.Text = _Engagement.duree;
            txtLieu.Text = _Engagement.lieu;
            rtbCommentaire.Text = _Engagement.commentaire;
            //txtPrixBillet.Text = _Engagement.;
            //txtCapacite.Text = conEngagement.FormatTelephone(_Engagement.tblAdresse.telCellulaire);
            rtbDescriptionCourte.Text = _Engagement.descriptionCourte;
            rtbDescriptionLongue.Text = _Engagement.description;
        }
    }
}
