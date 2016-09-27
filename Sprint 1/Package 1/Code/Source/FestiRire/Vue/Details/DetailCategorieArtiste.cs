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
        Controleur.Validation validation  = new Controleur.Validation();
        //Crée l'interface insert
        public DetailCategorieArtiste()
        {
            InitializeComponent();
            DCA = new Controleur.Details.DetailCategorieArtiste();
            IdCatArt = 0;
        }
        int IdCatArt;
        //Crée l'interface avec modifications / Update
        public DetailCategorieArtiste(int noCategorie)
        {
            InitializeComponent();
            IdCatArt = 0;
            DCA = new Controleur.Details.DetailCategorieArtiste();
            Modele.tblCategorieArtiste categorie = DCA.LoadCatArtt(noCategorie);
            peuplerInterface(categorie);
            
        }
        //Fonction pour désactiver le bouton supprimer lorsque l'interface est en mode ajout
        public void DesactiverBtnSupp()
        {
            btnSupprimerArtiste.Enabled = false;
        }

        //Permet de peupler l'interface détail
        private void peuplerInterface(Modele.tblCategorieArtiste catArt)
        {
            IdCatArt = catArt.noCategorie; //On concerve le numéro pour pouvoir supprimer avec.
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
            string mes = "";
            string messvide;
            messvide = validation.VerifierNomCat(txtNomCategorie.Text);
            if (messvide!="")
            {
                MessageBox.Show(messvide);
            }
            else
            {
                if (!DCA.EnregistrerCatArt(IdCatArt, txtNomCategorie.Text, rtbDescriptionCategorie.Text))
                    mes = "La catégorie d'artiste a été modifiée  avec succés.";
                else
                    mes = "La catégorie d'artiste a été enregistrée avec succés.";
                MessageBox.Show(mes);
               this.Close();
            }


        }

        private void btnSupprimerArtiste_Click(object sender, EventArgs e)
        {
            if(IdCatArt!=0)
            {
                DialogResult result = result = MessageBox.Show("Voulez-vous supprimer cette catégorie d'artiste?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result==DialogResult.Yes)
                {
                    DCA.deleteCatArt(IdCatArt);
                    MessageBox.Show("La catégorie d'artiste a été supprimée avec succés");
                    this.Close();
                }
            }
        }
    }
}
