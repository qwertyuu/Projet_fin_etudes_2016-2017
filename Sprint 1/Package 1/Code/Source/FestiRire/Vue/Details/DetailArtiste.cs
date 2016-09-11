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
    public partial class DetailArtiste : Form
    {
        Controleur.Details.DetailArtiste artiste;
        public DetailArtiste()
        {
            InitializeComponent();
            artiste = new Controleur.Details.DetailArtiste();
            ChargerCatArtiste();
            ChargerContrat();
            //var a = new Message();
        }

        private void ChargerCatArtiste()
        {
            foreach(Modele.tblCategorieArtiste cat in artiste.ChargerListCatArtis())
            {
                cmbCategorieArtiste.Items.Add(cat.nom.ToString());
            }
        }

        private void ChargerContrat()
        {
            foreach (Modele.tblContrat cat in artiste.ChargerContrat())
            {
                cmbContrat.Items.Add(cat.nom.ToString());
            }
        }


        private void btnParcourir_Click(object sender, EventArgs e)
        {
            bool valide = false;
            openFileDialogfichier.Multiselect = true;
            openFileDialogfichier.Title = "Sélectionner le fichier.";
            DialogResult result = openFileDialogfichier.ShowDialog();
            while(valide==false)
            {
                if (result == DialogResult.OK) //Si on choisie le fichier
                {
                    if (openFileDialogPhoto.Filter == "Excel Files|*.xls;*.xlsx;*.xlsm")
                    {
                        foreach(String f in openFileDialogfichier.FileNames)
                        {
                            lstFiches.Items.Add(f);
                        }
                        valide = true;
                    }
                    else
                    {
                        MessageBox.Show("Type de fichier invalide");
                        result = openFileDialogPhoto.ShowDialog();
                    }
                }
                else
                    valide = true;
            }



        }

        private void btnParcourirPhotoOfficielle_Click(object sender, EventArgs e)
        {
            //bool valide = false;
            openFileDialogPhoto.Multiselect = true;
            openFileDialogfichier.Title = "Sélectionner la photo";
            DialogResult result = openFileDialogPhoto.ShowDialog();

            if (result == DialogResult.OK) //Si om choisie le fichier
            {
                openFileDialogfichier.Filter = "Image Files(*.bmp, *.jpg) | *.bmp; *.jpg";
                openFileDialogfichier.FilterIndex = 2;
                          foreach(string f in openFileDialogPhoto.SafeFileNames)
                         {
                               lstPhotoOfficiel.Items.Add(f);
                         }
            }

            //while (valide==false)
            //{
            //    if (result == DialogResult.OK) //Si om choisie le fichier
            //    {
            //        openFileDialogfichier.Filter = "Image Files(*.bmp, *.jpg) | *.bmp; *.jpg";
            //        openFileDialogfichier.FilterIndex = 2;
            //        //if (openFileDialogPhoto.Filter == "Image Files(*.bmp, *.jpg) | *.bmp; *.jpg")
            //        //{
            //        //    foreach(string f in openFileDialogPhoto.SafeFileNames)
            //        //    {
            //        //        lstPhotoOfficiel.Items.Add(f);
            //        //    }

            //        //}
            //        //else
            //        //{
            //        //    MessageBox.Show("Type de fichier invalide");
            //        //    result = openFileDialogPhoto.ShowDialog();
            //        //}
            //    }
            //    else
            //        valide = true;
            //}

        }

        private void btnAjouterCategorieArtiste_Click(object sender, EventArgs e)
        {
            DetailCategorieArtiste cat = new DetailCategorieArtiste();
            cat.ShowDialog();
        }
    }
}
