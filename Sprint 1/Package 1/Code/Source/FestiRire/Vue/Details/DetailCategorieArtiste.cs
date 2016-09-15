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
    public partial class DetailCategorieArtiste : Form
    {
        Controleur.Details.DetailCategorieArtiste DCA;
        Controleur.Validation validation;
        public DetailCategorieArtiste()
        {
            InitializeComponent();
            DCA = new Controleur.Details.DetailCategorieArtiste();
            validation = new Controleur.Validation();
        }
        string idOrginal = "";

        public DetailCategorieArtiste(int noCategorie)
        {
            InitializeComponent();
            DCA = new Controleur.Details.DetailCategorieArtiste();           
            Modele.tblCategorieArtiste categorie = DCA.LoadCatArtt(noCategorie);
            peuplerInterface(categorie);
            
        }


        //Permet de peupler l'interface détail
        private void peuplerInterface(Modele.tblCategorieArtiste catArt)
        {
            txtNomCategorie.Text = catArt.nom;
            rtbDescriptionCategorie.Text = catArt.description;
        }

        //Message de conformation lorsque l'uitlisateur appuit sur Annuler
        public void ConfirmationClose()
        {
            DialogResult result;
            result = MessageBox.Show("Si vous fermez vous allez perdre les données déja saisies. Voulez-vous fermer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //Gestion des styles reliés aux commentaires et description
        private void btnGrasCatArtiste_Click(object sender, EventArgs e)
        {
            DCA.TextGras(rtbDescriptionCategorie);
        }

        private void btnItalicCatArtiste_Click(object sender, EventArgs e)
        {
            DCA.TextItalic(rtbDescriptionCategorie);
        }

        private void btnUnderlineCatArtiste_Click(object sender, EventArgs e)
        {
            DCA.TextUderline(rtbDescriptionCategorie);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            DCA.SizeText(rtbDescriptionCategorie,numericUpDownCatArtiste.Value);
        }

        private void btnEnumCatArtiste_Click(object sender, EventArgs e)
        {
            DCA.EnumText(rtbDescriptionCategorie);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ConfirmationClose();
        }

        private void btnEnregistrerArtiste_Click(object sender, EventArgs e)
        {
            string messvide = validation.VerifierNomCat(txtNomCategorie.Text);
            if (messvide!="")
            {
                MessageBox.Show(messvide);
            }
            else
            {
               DCA.EnregistrerCatArt(txtNomCategorie.Text, rtbDescriptionCategorie.Text);
               this.Close();
            }


        }

        private void btnSupprimerArtiste_Click(object sender, EventArgs e)
        {

        }
    }
}
