using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestiRire
{
    public partial class DetailArtiste : Form
    {
        Controleur.Details.DetailArtiste artiste;
        Controleur.Sommaires.SommaireCategorieArtiste conSomCatArtiste;
        Controleur.Details.DetailFichiers conDetailFichiers;
        Controleur.Details.DetailCategorieArtiste conCatArtiste;
        int? idartiste;
        private Modele.tblFichierPersonnel Selection;

        public Modele.tblFichierPersonnel selection
        {
            get { return Selection; }
            set { Selection = value; rtbCommentaire.Enabled = true; }
        }

        public DetailArtiste()
        {
            InitializeComponent();
            conDetailFichiers = new Controleur.Details.DetailFichiers();
            artiste = new Controleur.Details.DetailArtiste();
            conSomCatArtiste = new Controleur.Sommaires.SommaireCategorieArtiste();
            lstCatArtiste.SelectionMode = SelectionMode.MultiSimple;
            cmbContrat.DataSource = artiste.ChargerContrat();
            cmbContrat.DisplayMember = "noContrat";
            lstCatArtiste.DataSource = conSomCatArtiste.Tout();
            lstCatArtiste.DisplayMember = "nom";
            idartiste = null;
            selection = null;

            lstFiches.DataSource = new List<Modele.tblFichierPersonnel>();
            lstFichier.DataSource = new List<Modele.tblFichierPersonnel>();
            lstPhotoOfficiel.DataSource = new List<Modele.tblFichierOfficiel>();
        }



        public DetailArtiste(int _idArtiste)
        {
            InitializeComponent();
            artiste = new Controleur.Details.DetailArtiste();
            conDetailFichiers = new Controleur.Details.DetailFichiers();
            conSomCatArtiste = new Controleur.Sommaires.SommaireCategorieArtiste();
            lstCatArtiste.SelectionMode = SelectionMode.MultiSimple;
            cmbContrat.DataSource = artiste.ChargerContrat();
            cmbContrat.DisplayMember = "noContrat";
            lstCatArtiste.DataSource = conSomCatArtiste.Tout();
            lstCatArtiste.DisplayMember = "nom";
            txtNomArtiste.Text = artiste.SelectArtiste(_idArtiste).nom;
            lstFiches.DataSource = artiste.Fiches(_idArtiste);
            lstFichier.DataSource = artiste.Fichiers(_idArtiste);
            lstPhotoOfficiel.DataSource = artiste.PhotoOfficielles(_idArtiste);
            idartiste = _idArtiste;
            loadCatArtiste();

        }

        private void loadCatArtiste()
        {
            //fonction qui s'occupe de sélectionner les catégories d'artistes lié à l'artiste
            if (this.idartiste == null)
                return;
            var categories = artiste.ChargerListCatArtis((int)this.idartiste);
            for (int i = 0; i < lstCatArtiste.Items.Count; i++)
            {
                lstCatArtiste.SetSelected(i, categories.Any(a => a.noCategorie == (lstCatArtiste.Items[i] as Modele.vueSomCatArtiste).noCategorie));
            }
        }

        public void DesactiverBtnSupp()
        {
            btnSupprimerArtiste.Enabled = false;
        }
        private void btnParcourir_Click(object sender, EventArgs e)
        {
            openFileDialogfichier.Multiselect = false;
            openFileDialogfichier.Title = "Sélectionner le fichier.";
            openFileDialogfichier.Filter = "Documents|*.xls;*.xlsx;*.xlsm;*.pdf;*.txt;";
            DialogResult result = openFileDialogfichier.ShowDialog();
            if (result == DialogResult.OK) //Si on choisie le fichier
            {
                var f = new Modele.tblFichierPersonnel()
                {
                    chemin = openFileDialogfichier.FileName,
                    type = "Fiche",
                    commentaire = rtbCommentaire.Rtf
                };
                var tempList = (lstFiches.DataSource as List<Modele.tblFichierPersonnel>);
                tempList.Add(f);
                lstFiches.DataSource = null;
                lstFiches.DataSource = tempList;
                lstFiches.SelectedItem = f;
            }



        }

        private void btnParcourirPhotoOfficielle_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Multiselect = false;
            openFileDialogPhoto.Filter = "Images | *.png; *.bmp; *.jpg";
            openFileDialogPhoto.Title = "Sélectionner la photo";
            DialogResult result = openFileDialogPhoto.ShowDialog();

            if (result == DialogResult.OK) //Si om choisie le fichier
            {
                var p = new Modele.tblFichierPersonnel()
                {
                    chemin = openFileDialogPhoto.FileName,
                    type = "Fichier",
                    commentaire = rtbCommentaire.Rtf
                };
                var j = new Modele.tblFichierOfficiel()
                {
                    tblFichierPersonnel = p,
                    tblContrat = cmbContrat.SelectedItem as Modele.tblContrat,
                    noContrat = (cmbContrat.SelectedItem as Modele.tblContrat).noContrat
                };
                var tempList = (lstPhotoOfficiel.DataSource as List<Modele.tblFichierOfficiel>);
                tempList.Add(j);
                lstPhotoOfficiel.DataSource = null;
                lstPhotoOfficiel.DataSource = tempList;
                lstPhotoOfficiel.SelectedItem = j;
            }

        }


        private void btnAjouterCategorieArtiste_Click(object sender, EventArgs e)
        {
            SommaireCategoriesArtiste cat = new SommaireCategoriesArtiste();
            cat.ShowDialog();
            lstCatArtiste.DataSource = conSomCatArtiste.Tout();
            loadCatArtiste();
        }

        private void lstPhotoOfficiel_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = (lstPhotoOfficiel.SelectedItem as Modele.tblFichierOfficiel);
            if (i == null)
            {
                pbApercu.Image = null;
                lblTailleFichier.Text = "Taille:";
                lblNomFichier.Text = "Nom:";
                lblTypeFichier.Text = "Type:";
                cmbContrat.SelectedIndex = 0;
                rtbCommentaire.Rtf = "";
                this.selection = null;
                return;
            }
            var f = new FileInfo(((sender as ListBox).SelectedItem as Modele.tblFichierOfficiel).tblFichierPersonnel.chemin);

            Dictionary<string, string> types = new Dictionary<string, string>()
            {
                { "PNG",    "Image" },
                { "JPG",    "Image" },
                { "JPEG",   "Image" },
                { "PDF",    "Document" },
                { "DOCX",   "Document" },
                { "DOC",    "Document" },
                { "TXT",    "Texte" }
            };
            if (File.Exists(i.tblFichierPersonnel.chemin) && types[f.Extension.Substring(1).ToUpper()] == "Image")
            {
                pbApercu.Image = Image.FromFile(i.tblFichierPersonnel.chemin);
            }
            else
            {
                pbApercu.Image = null;
            }
            if (f != null && f.Exists)
            {
                lblTailleFichier.Text = "Taille:" + BytesToString(f.Length);
                lblNomFichier.Text = "Nom:" + f.Name;
                lblTypeFichier.Text = "Type:" + types[f.Extension.Substring(1).ToUpper()];
            }
            cmbContrat.SelectedItem = i.tblContrat;
            this.selection = ((sender as ListBox).SelectedItem as Modele.tblFichierOfficiel).tblFichierPersonnel;
            rtbCommentaire.Rtf = i.tblFichierPersonnel.commentaire;
        }

        private void lstFiches_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = Path.GetFileName((e.ListItem as Modele.tblFichierPersonnel).chemin);
        }

        private void lstFiches_SelectedIndexChanged(object sender, EventArgs e)
        {

            var i = ((sender as ListBox).SelectedItem as Modele.tblFichierPersonnel);
            if (i == null)
            {
                pbApercu.Image = null;
                lblTailleFichier.Text = "Taille:";
                lblNomFichier.Text = "Nom:";
                lblTypeFichier.Text = "Type:";
                cmbContrat.SelectedIndex = 0;
                rtbCommentaire.Rtf = "";
                this.selection = null;
                rtbCommentaire.Enabled = true;
                return;
            }
            Dictionary<string, string> types = new Dictionary<string, string>()
            {
                { "PNG",    "Image" },
                { "JPG",    "Image" },
                { "JPEG",   "Image" },
                { "PDF",    "Document" },
                { "DOCX",   "Document" },
                { "DOC",    "Document" },
                { "TXT",    "Texte" }
            };
            var f = new FileInfo(i.chemin);
            if (File.Exists(i.chemin) && types[f.Extension.Substring(1).ToUpper()] == "Image")
            {
                pbApercu.Image = Image.FromFile(i.chemin);
            }
            else
            {
                pbApercu.Image = null;
            }
            lblTailleFichier.Text = "Taille:" + BytesToString(f.Length);
            lblNomFichier.Text = "Nom:" + f.Name;
            lblTypeFichier.Text = "Type:" + types[f.Extension.Substring(1).ToUpper()];
            this.selection = (sender as ListBox).SelectedItem as Modele.tblFichierPersonnel;
            rtbCommentaire.Rtf = i.commentaire;
        }
        //permet de convertir les grosseur de fichier en un format lisible
        static string BytesToString(long byteCount)
        {
            string[] suf = { "o", "ko", "mo", "go", "to", "po", "eo" };
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }

        private void btnParcourirFichier_Click(object sender, EventArgs e)
        {
            openFileDialogfichier.Multiselect = false;
            openFileDialogfichier.Title = "Sélectionner le fichier.";
            openFileDialogfichier.Filter = "Documents|*.xls;*.xlsx;*.xlsm;*.pdf;*.txt;|Images | *.png; *.bmp; *.jpg;";
            DialogResult result = openFileDialogfichier.ShowDialog();
            if (result == DialogResult.OK) //Si on choisie le fichier
            {
                var f = new Modele.tblFichierPersonnel()
                {
                    chemin = openFileDialogfichier.FileName,
                    type = "Fichier"
                };
                var tempList = (lstFichier.DataSource as List<Modele.tblFichierPersonnel>);
                tempList.Add(f);
                lstFichier.DataSource = null;
                lstFichier.DataSource = tempList;
                lstFichier.SelectedItem = f;
            }
        }

        private void lstPhotoOfficiel_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = Path.GetFileName((e.ListItem as Modele.tblFichierOfficiel).tblFichierPersonnel.chemin);
        }

        private void btnEnregistrerArtiste_Click(object sender, EventArgs e)
        {
            var cats = lstCatArtiste.SelectedItems.Cast<Modele.vueSomCatArtiste>();
            conCatArtiste = new Controleur.Details.DetailCategorieArtiste();
            var categories = (from a in conCatArtiste.Tout()
                    join b in cats on a.noCategorie equals b.noCategorie
                    select a).ToList();

            if (txtNomArtiste.Text == "" || lstCatArtiste.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez entrez le nom de l'artiste et sa catégorie.");
                return;
            }
            else
            {
                if (idartiste == null)
                {
                    idartiste = artiste.AjouterArtiste(
                        txtNomArtiste.Text,
                        categories,
                        rtbCommentaire.Rtf
                    );
                }
                else
                {
                    artiste.AjouterArtiste(
                        (int)this.idartiste,
                        txtNomArtiste.Text,
                        categories,
                        rtbCommentaire.Rtf
                    );
                }
            }

            foreach (Modele.tblFichierPersonnel item in lstFichier.Items)
            {
                if (!artiste.Fichiers((int)idartiste).Contains(item))
                {
                    item.noArtiste = (int)this.idartiste;
                    artiste.AjouterFichier(item);
                }
            }

            foreach (Modele.tblFichierPersonnel item in lstFiches.Items)
            {
                if (!artiste.Fiches((int)idartiste).Contains(item))
                {
                    item.noArtiste = (int)this.idartiste;
                    artiste.AjouterFiche(item);
                }
            }
            artiste.Save();

            foreach (Modele.tblFichierOfficiel item in lstPhotoOfficiel.Items)
            {
                if (!artiste.Photos((int)idartiste).Contains(item.tblFichierPersonnel))
                {
                    item.tblFichierPersonnel.noArtiste = (int)this.idartiste;
                    artiste.AjouterPhoto(item.tblFichierPersonnel);
                }
                if (!artiste.PhotoOfficielles((int)idartiste).Contains(item))
                {
                    item.noFichier = item.tblFichierPersonnel.noFichier;
                    item.noArtiste = (int)idartiste;
                    artiste.AjouterPhotoOfficielle(item);
                }
            }

            foreach (var item in artiste.Photos((int)idartiste))
            {
                if (!lstPhotoOfficiel.Items.Cast<Modele.tblFichierOfficiel>().Any(a => a.tblFichierPersonnel.noFichier == item.noFichier))
                {
                    conDetailFichiers.Supprimer(item);
                }
            }

            foreach (var item in artiste.Fiches((int)idartiste))
            {
                if (!lstFiches.Items.Contains(item))
                {
                    conDetailFichiers.Supprimer(item);
                }
            }
            foreach (var item in artiste.Fichiers((int)idartiste))
            {
                if (!lstFichier.Items.Contains(item))
                {
                    conDetailFichiers.Supprimer(item);
                }
            }
            conDetailFichiers.Save();
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

        private void btnSupprimerArtiste_Click(object sender, EventArgs e)
        {
            artiste.Supprimer((int)idartiste);
        }

        private void rtbCommentaire_TextChanged(object sender, EventArgs e)
        {
            if (this.selection != null)
                this.selection.commentaire = rtbCommentaire.Rtf;
            else
                MessageBox.Show("Vous devez sélectionnez un fichier ou une photo avant d'y mettre une commentire");
        }

        private void cmbContrat_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstPhotoOfficiel.SelectedItem == null)
            {
                return;
            }
            (lstPhotoOfficiel.SelectedItem as Modele.tblFichierOfficiel).tblContrat = cmbContrat.SelectedItem as Modele.tblContrat;
            (lstPhotoOfficiel.SelectedItem as Modele.tblFichierOfficiel).noContrat = (cmbContrat.SelectedItem as Modele.tblContrat).noContrat;
        }

        private void btnSupprimerFiche_Click(object sender, EventArgs e)
        {
            if (lstFiches.SelectedItem != null)
            {
                int index = lstFiches.SelectedIndex;
                var tempList = (lstFiches.DataSource as List<Modele.tblFichierPersonnel>);
                tempList.Remove(lstFiches.SelectedItem as Modele.tblFichierPersonnel);
                lstFiches.DataSource = null;
                lstFiches.DataSource = tempList;
                if (tempList.Count > 0)
                {
                    lstFiches.SelectedIndex = Math.Max(0, index - 1);
                }
                else
                {
                    lstFiches.SelectedItem = null;
                }
            }
        }

        private void btnSupprimerPhotoOfficiel_Click(object sender, EventArgs e)
        {
            if (lstPhotoOfficiel.SelectedItem != null)
            {
                int index = lstPhotoOfficiel.SelectedIndex;
                var tempList = (lstPhotoOfficiel.DataSource as List<Modele.tblFichierOfficiel>);
                tempList.Remove(lstPhotoOfficiel.SelectedItem as Modele.tblFichierOfficiel);
                lstPhotoOfficiel.DataSource = null;
                lstPhotoOfficiel.DataSource = tempList;
                if (tempList.Count > 0)
                {
                    lstPhotoOfficiel.SelectedIndex = Math.Max(0, index - 1);
                }
                else
                {
                    lstPhotoOfficiel.SelectedIndex = -1;
                }
            }
        }

        private void btnSupprimerFichier_Click(object sender, EventArgs e)
        {
            if (lstFichier.SelectedItem != null)
            {
                int index = lstFichier.SelectedIndex;
                var tempList = (lstFichier.DataSource as List<Modele.tblFichierPersonnel>);
                tempList.Remove(lstFichier.SelectedItem as Modele.tblFichierPersonnel);
                lstFichier.DataSource = null;
                lstFichier.DataSource = tempList;
                if (tempList.Count > 0)
                {
                    lstFichier.SelectedIndex = Math.Max(0, index - 1);
                }
                else
                {
                    lstFichier.SelectedItem = null;
                }
            }
        }

        //Gestion des styles reliés aux commentaires et description
        private void btnGrasCommentaire_Click(object sender, EventArgs e)
        {
            artiste.TextGras(rtbCommentaire);
        }

        private void btnItaliqueCommentaire_Click(object sender, EventArgs e)
        {
            artiste.TextItalic(rtbCommentaire);
        }

        private void btnSouslignerCommentaire_Click(object sender, EventArgs e)
        {
            artiste.TextUderline(rtbCommentaire);
        }

        private void numPoliceCommentaire_ValueChanged(object sender, EventArgs e)
        {
            artiste.SizeText(rtbCommentaire,numPoliceCommentaire.Value);
        }

        private void btnEnumCommentaire_Click(object sender, EventArgs e)
        {
            artiste.EnumText(rtbCommentaire);
        }
    }
}
