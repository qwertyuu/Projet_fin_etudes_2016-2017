namespace FestiRire
{
    partial class DetailArtiste
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomArtiste = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrerArtiste = new System.Windows.Forms.Button();
            this.btnSupprimerArtiste = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjouterCategorieArtiste = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numPoliceCommentaire = new System.Windows.Forms.NumericUpDown();
            this.btnEnumCommentaire = new System.Windows.Forms.Button();
            this.btnSouslignerCommentaire = new System.Windows.Forms.Button();
            this.btnItaliqueCommentaire = new System.Windows.Forms.Button();
            this.btnGrasCommentaire = new System.Windows.Forms.Button();
            this.lblNomFichier = new System.Windows.Forms.Label();
            this.lblTypeFichier = new System.Windows.Forms.Label();
            this.lblTailleFichier = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbCommentaire = new System.Windows.Forms.RichTextBox();
            this.btnParcourirPhotoOfficielle = new System.Windows.Forms.Button();
            this.btnSupprimerPhotoOfficiel = new System.Windows.Forms.Button();
            this.lstPhotoOfficiel = new System.Windows.Forms.ListBox();
            this.cmbContrat = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSupprimerFiche = new System.Windows.Forms.Button();
            this.btnParcourir = new System.Windows.Forms.Button();
            this.lstFiches = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstFichier = new System.Windows.Forms.ListBox();
            this.btnSupprimerFichier = new System.Windows.Forms.Button();
            this.btnParcourirFichier = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pbApercu = new System.Windows.Forms.PictureBox();
            this.openFileDialogfichier = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.lstCatArtiste = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPoliceCommentaire)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbApercu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomArtiste
            // 
            this.txtNomArtiste.Location = new System.Drawing.Point(168, 9);
            this.txtNomArtiste.Name = "txtNomArtiste";
            this.txtNomArtiste.Size = new System.Drawing.Size(475, 26);
            this.txtNomArtiste.TabIndex = 26;
            this.txtNomArtiste.Text = "Les Denis Drolets";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 14);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 20);
            this.label20.TabIndex = 25;
            this.label20.Text = "Nom d\'artiste:";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(1156, 966);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(112, 35);
            this.btnAnnuler.TabIndex = 30;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrerArtiste
            // 
            this.btnEnregistrerArtiste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrerArtiste.Location = new System.Drawing.Point(1035, 966);
            this.btnEnregistrerArtiste.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnregistrerArtiste.Name = "btnEnregistrerArtiste";
            this.btnEnregistrerArtiste.Size = new System.Drawing.Size(112, 35);
            this.btnEnregistrerArtiste.TabIndex = 30;
            this.btnEnregistrerArtiste.Text = "Enregistrer";
            this.btnEnregistrerArtiste.UseVisualStyleBackColor = true;
            this.btnEnregistrerArtiste.Click += new System.EventHandler(this.btnEnregistrerArtiste_Click);
            // 
            // btnSupprimerArtiste
            // 
            this.btnSupprimerArtiste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerArtiste.Location = new System.Drawing.Point(914, 966);
            this.btnSupprimerArtiste.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupprimerArtiste.Name = "btnSupprimerArtiste";
            this.btnSupprimerArtiste.Size = new System.Drawing.Size(112, 35);
            this.btnSupprimerArtiste.TabIndex = 30;
            this.btnSupprimerArtiste.Text = "Supprimer";
            this.btnSupprimerArtiste.UseVisualStyleBackColor = true;
            this.btnSupprimerArtiste.Click += new System.EventHandler(this.btnSupprimerArtiste_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Catégories d\'artiste:";
            // 
            // btnAjouterCategorieArtiste
            // 
            this.btnAjouterCategorieArtiste.Location = new System.Drawing.Point(168, 222);
            this.btnAjouterCategorieArtiste.Name = "btnAjouterCategorieArtiste";
            this.btnAjouterCategorieArtiste.Size = new System.Drawing.Size(477, 38);
            this.btnAjouterCategorieArtiste.TabIndex = 44;
            this.btnAjouterCategorieArtiste.Text = "Gérer";
            this.btnAjouterCategorieArtiste.UseVisualStyleBackColor = true;
            this.btnAjouterCategorieArtiste.Click += new System.EventHandler(this.btnAjouterCategorieArtiste_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numPoliceCommentaire);
            this.groupBox1.Controls.Add(this.btnEnumCommentaire);
            this.groupBox1.Controls.Add(this.btnSouslignerCommentaire);
            this.groupBox1.Controls.Add(this.btnItaliqueCommentaire);
            this.groupBox1.Controls.Add(this.btnGrasCommentaire);
            this.groupBox1.Controls.Add(this.lblNomFichier);
            this.groupBox1.Controls.Add(this.lblTypeFichier);
            this.groupBox1.Controls.Add(this.lblTailleFichier);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtbCommentaire);
            this.groupBox1.Location = new System.Drawing.Point(654, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(615, 489);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propriétés du fichier";
            // 
            // numPoliceCommentaire
            // 
            this.numPoliceCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numPoliceCommentaire.Location = new System.Drawing.Point(246, 185);
            this.numPoliceCommentaire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPoliceCommentaire.Name = "numPoliceCommentaire";
            this.numPoliceCommentaire.Size = new System.Drawing.Size(51, 26);
            this.numPoliceCommentaire.TabIndex = 79;
            this.numPoliceCommentaire.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numPoliceCommentaire.ValueChanged += new System.EventHandler(this.numPoliceCommentaire_ValueChanged);
            // 
            // btnEnumCommentaire
            // 
            this.btnEnumCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnumCommentaire.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnumCommentaire.Location = new System.Drawing.Point(304, 183);
            this.btnEnumCommentaire.Name = "btnEnumCommentaire";
            this.btnEnumCommentaire.Size = new System.Drawing.Size(63, 32);
            this.btnEnumCommentaire.TabIndex = 78;
            this.btnEnumCommentaire.Text = "Enum";
            this.btnEnumCommentaire.UseVisualStyleBackColor = true;
            this.btnEnumCommentaire.Click += new System.EventHandler(this.btnEnumCommentaire_Click);
            // 
            // btnSouslignerCommentaire
            // 
            this.btnSouslignerCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSouslignerCommentaire.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSouslignerCommentaire.Location = new System.Drawing.Point(204, 183);
            this.btnSouslignerCommentaire.Name = "btnSouslignerCommentaire";
            this.btnSouslignerCommentaire.Size = new System.Drawing.Size(34, 32);
            this.btnSouslignerCommentaire.TabIndex = 75;
            this.btnSouslignerCommentaire.Text = "I";
            this.btnSouslignerCommentaire.UseVisualStyleBackColor = true;
            this.btnSouslignerCommentaire.Click += new System.EventHandler(this.btnSouslignerCommentaire_Click);
            // 
            // btnItaliqueCommentaire
            // 
            this.btnItaliqueCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItaliqueCommentaire.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItaliqueCommentaire.Location = new System.Drawing.Point(164, 183);
            this.btnItaliqueCommentaire.Name = "btnItaliqueCommentaire";
            this.btnItaliqueCommentaire.Size = new System.Drawing.Size(34, 32);
            this.btnItaliqueCommentaire.TabIndex = 76;
            this.btnItaliqueCommentaire.Text = "I";
            this.btnItaliqueCommentaire.UseVisualStyleBackColor = true;
            this.btnItaliqueCommentaire.Click += new System.EventHandler(this.btnItaliqueCommentaire_Click);
            // 
            // btnGrasCommentaire
            // 
            this.btnGrasCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrasCommentaire.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrasCommentaire.Location = new System.Drawing.Point(123, 183);
            this.btnGrasCommentaire.Name = "btnGrasCommentaire";
            this.btnGrasCommentaire.Size = new System.Drawing.Size(34, 32);
            this.btnGrasCommentaire.TabIndex = 77;
            this.btnGrasCommentaire.Text = "B";
            this.btnGrasCommentaire.UseVisualStyleBackColor = true;
            this.btnGrasCommentaire.Click += new System.EventHandler(this.btnGrasCommentaire_Click);
            // 
            // lblNomFichier
            // 
            this.lblNomFichier.AutoSize = true;
            this.lblNomFichier.Location = new System.Drawing.Point(9, 25);
            this.lblNomFichier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomFichier.Name = "lblNomFichier";
            this.lblNomFichier.Size = new System.Drawing.Size(241, 20);
            this.lblNomFichier.TabIndex = 27;
            this.lblNomFichier.Text = "Nom: Pedigree_DenisDrolets.pdf";
            // 
            // lblTypeFichier
            // 
            this.lblTypeFichier.AutoSize = true;
            this.lblTypeFichier.Location = new System.Drawing.Point(9, 74);
            this.lblTypeFichier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeFichier.Name = "lblTypeFichier";
            this.lblTypeFichier.Size = new System.Drawing.Size(125, 20);
            this.lblTypeFichier.TabIndex = 27;
            this.lblTypeFichier.Text = "Type: Document";
            // 
            // lblTailleFichier
            // 
            this.lblTailleFichier.AutoSize = true;
            this.lblTailleFichier.Location = new System.Drawing.Point(9, 51);
            this.lblTailleFichier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTailleFichier.Name = "lblTailleFichier";
            this.lblTailleFichier.Size = new System.Drawing.Size(101, 20);
            this.lblTailleFichier.TabIndex = 27;
            this.lblTailleFichier.Text = "Taille: 580 ko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Commentaire:";
            // 
            // rtbCommentaire
            // 
            this.rtbCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCommentaire.Location = new System.Drawing.Point(9, 223);
            this.rtbCommentaire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbCommentaire.Name = "rtbCommentaire";
            this.rtbCommentaire.Size = new System.Drawing.Size(595, 255);
            this.rtbCommentaire.TabIndex = 56;
            this.rtbCommentaire.Text = "";
            this.rtbCommentaire.TextChanged += new System.EventHandler(this.rtbCommentaire_TextChanged);
            // 
            // btnParcourirPhotoOfficielle
            // 
            this.btnParcourirPhotoOfficielle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnParcourirPhotoOfficielle.Location = new System.Drawing.Point(14, 200);
            this.btnParcourirPhotoOfficielle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParcourirPhotoOfficielle.Name = "btnParcourirPhotoOfficielle";
            this.btnParcourirPhotoOfficielle.Size = new System.Drawing.Size(298, 35);
            this.btnParcourirPhotoOfficielle.TabIndex = 48;
            this.btnParcourirPhotoOfficielle.Text = "Parcourir...";
            this.btnParcourirPhotoOfficielle.UseVisualStyleBackColor = true;
            this.btnParcourirPhotoOfficielle.Click += new System.EventHandler(this.btnParcourirPhotoOfficielle_Click);
            // 
            // btnSupprimerPhotoOfficiel
            // 
            this.btnSupprimerPhotoOfficiel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSupprimerPhotoOfficiel.Location = new System.Drawing.Point(321, 200);
            this.btnSupprimerPhotoOfficiel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupprimerPhotoOfficiel.Name = "btnSupprimerPhotoOfficiel";
            this.btnSupprimerPhotoOfficiel.Size = new System.Drawing.Size(290, 35);
            this.btnSupprimerPhotoOfficiel.TabIndex = 49;
            this.btnSupprimerPhotoOfficiel.Text = "Supprimer le fichier";
            this.btnSupprimerPhotoOfficiel.UseVisualStyleBackColor = true;
            this.btnSupprimerPhotoOfficiel.Click += new System.EventHandler(this.btnSupprimerPhotoOfficiel_Click);
            // 
            // lstPhotoOfficiel
            // 
            this.lstPhotoOfficiel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPhotoOfficiel.FormattingEnabled = true;
            this.lstPhotoOfficiel.ItemHeight = 20;
            this.lstPhotoOfficiel.Location = new System.Drawing.Point(14, 68);
            this.lstPhotoOfficiel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstPhotoOfficiel.Name = "lstPhotoOfficiel";
            this.lstPhotoOfficiel.Size = new System.Drawing.Size(595, 124);
            this.lstPhotoOfficiel.TabIndex = 47;
            this.lstPhotoOfficiel.SelectedIndexChanged += new System.EventHandler(this.lstPhotoOfficiel_SelectedIndexChanged);
            this.lstPhotoOfficiel.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstPhotoOfficiel_Format);
            // 
            // cmbContrat
            // 
            this.cmbContrat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbContrat.FormattingEnabled = true;
            this.cmbContrat.Location = new System.Drawing.Point(154, 28);
            this.cmbContrat.Name = "cmbContrat";
            this.cmbContrat.Size = new System.Drawing.Size(454, 28);
            this.cmbContrat.TabIndex = 50;
            this.cmbContrat.SelectedValueChanged += new System.EventHandler(this.cmbContrat_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lstPhotoOfficiel);
            this.groupBox2.Controls.Add(this.cmbContrat);
            this.groupBox2.Controls.Add(this.btnSupprimerPhotoOfficiel);
            this.groupBox2.Controls.Add(this.btnParcourirPhotoOfficielle);
            this.groupBox2.Location = new System.Drawing.Point(18, 471);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(627, 249);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Photos officielles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Contrat concerné:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSupprimerFiche);
            this.groupBox3.Controls.Add(this.btnParcourir);
            this.groupBox3.Controls.Add(this.lstFiches);
            this.groupBox3.Location = new System.Drawing.Point(18, 268);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(627, 194);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste des fiches";
            // 
            // btnSupprimerFiche
            // 
            this.btnSupprimerFiche.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSupprimerFiche.Location = new System.Drawing.Point(321, 145);
            this.btnSupprimerFiche.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupprimerFiche.Name = "btnSupprimerFiche";
            this.btnSupprimerFiche.Size = new System.Drawing.Size(290, 35);
            this.btnSupprimerFiche.TabIndex = 51;
            this.btnSupprimerFiche.Text = "Supprimer le fichier";
            this.btnSupprimerFiche.UseVisualStyleBackColor = true;
            this.btnSupprimerFiche.Click += new System.EventHandler(this.btnSupprimerFiche_Click);
            // 
            // btnParcourir
            // 
            this.btnParcourir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnParcourir.Location = new System.Drawing.Point(14, 145);
            this.btnParcourir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParcourir.Name = "btnParcourir";
            this.btnParcourir.Size = new System.Drawing.Size(298, 35);
            this.btnParcourir.TabIndex = 50;
            this.btnParcourir.Text = "Parcourir...";
            this.btnParcourir.UseVisualStyleBackColor = true;
            this.btnParcourir.Click += new System.EventHandler(this.btnParcourir_Click);
            // 
            // lstFiches
            // 
            this.lstFiches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lstFiches.FormattingEnabled = true;
            this.lstFiches.Location = new System.Drawing.Point(9, 19);
            this.lstFiches.Name = "lstFiches";
            this.lstFiches.Size = new System.Drawing.Size(595, 104);
            this.lstFiches.TabIndex = 32;
            this.lstFiches.SelectedIndexChanged += new System.EventHandler(this.lstFiches_SelectedIndexChanged);
            this.lstFiches.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstFiches_Format);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstFichier);
            this.groupBox4.Controls.Add(this.btnSupprimerFichier);
            this.groupBox4.Controls.Add(this.btnParcourirFichier);
            this.groupBox4.Location = new System.Drawing.Point(18, 729);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(627, 228);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fichiers";
            // 
            // lstFichier
            // 
            this.lstFichier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFichier.FormattingEnabled = true;
            this.lstFichier.Location = new System.Drawing.Point(6, 19);
            this.lstFichier.Name = "lstFichier";
            this.lstFichier.Size = new System.Drawing.Size(600, 144);
            this.lstFichier.TabIndex = 47;
            this.lstFichier.SelectedIndexChanged += new System.EventHandler(this.lstFiches_SelectedIndexChanged);
            this.lstFichier.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstFiches_Format);
            // 
            // btnSupprimerFichier
            // 
            this.btnSupprimerFichier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSupprimerFichier.Location = new System.Drawing.Point(316, 183);
            this.btnSupprimerFichier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupprimerFichier.Name = "btnSupprimerFichier";
            this.btnSupprimerFichier.Size = new System.Drawing.Size(294, 35);
            this.btnSupprimerFichier.TabIndex = 49;
            this.btnSupprimerFichier.Text = "Supprimer le fichier";
            this.btnSupprimerFichier.UseVisualStyleBackColor = true;
            this.btnSupprimerFichier.Click += new System.EventHandler(this.btnSupprimerFichier_Click);
            // 
            // btnParcourirFichier
            // 
            this.btnParcourirFichier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnParcourirFichier.Location = new System.Drawing.Point(9, 183);
            this.btnParcourirFichier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParcourirFichier.Name = "btnParcourirFichier";
            this.btnParcourirFichier.Size = new System.Drawing.Size(298, 35);
            this.btnParcourirFichier.TabIndex = 48;
            this.btnParcourirFichier.Text = "Parcourir...";
            this.btnParcourirFichier.UseVisualStyleBackColor = true;
            this.btnParcourirFichier.Click += new System.EventHandler(this.btnParcourirFichier_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pbApercu);
            this.groupBox5.Location = new System.Drawing.Point(654, 508);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(615, 449);
            this.groupBox5.TabIndex = 54;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Aperçu";
            // 
            // pbApercu
            // 
            this.pbApercu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbApercu.Location = new System.Drawing.Point(4, 24);
            this.pbApercu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbApercu.Name = "pbApercu";
            this.pbApercu.Size = new System.Drawing.Size(607, 420);
            this.pbApercu.TabIndex = 0;
            this.pbApercu.TabStop = false;
            // 
            // openFileDialogfichier
            // 
            this.openFileDialogfichier.FileName = "openFileDialog1";
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // lstCatArtiste
            // 
            this.lstCatArtiste.FormattingEnabled = true;
            this.lstCatArtiste.ItemHeight = 20;
            this.lstCatArtiste.Location = new System.Drawing.Point(168, 48);
            this.lstCatArtiste.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCatArtiste.Name = "lstCatArtiste";
            this.lstCatArtiste.Size = new System.Drawing.Size(475, 164);
            this.lstCatArtiste.TabIndex = 55;
            // 
            // DetailArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(1287, 1020);
            this.Controls.Add(this.lstCatArtiste);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAjouterCategorieArtiste);
            this.Controls.Add(this.btnSupprimerArtiste);
            this.Controls.Add(this.btnEnregistrerArtiste);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtNomArtiste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label20);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DetailArtiste";
            this.Text = "Détail de l\'artiste";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPoliceCommentaire)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbApercu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomArtiste;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrerArtiste;
        private System.Windows.Forms.Button btnSupprimerArtiste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjouterCategorieArtiste;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTailleFichier;
        private System.Windows.Forms.Label lblNomFichier;
        private System.Windows.Forms.Label lblTypeFichier;
        private System.Windows.Forms.Button btnParcourirPhotoOfficielle;
        private System.Windows.Forms.Button btnSupprimerPhotoOfficiel;
        private System.Windows.Forms.ListBox lstPhotoOfficiel;
        private System.Windows.Forms.ComboBox cmbContrat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSupprimerFiche;
        private System.Windows.Forms.Button btnParcourir;
        private System.Windows.Forms.ListBox lstFiches;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstFichier;
        private System.Windows.Forms.Button btnSupprimerFichier;
        private System.Windows.Forms.Button btnParcourirFichier;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pbApercu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbCommentaire;
        private System.Windows.Forms.NumericUpDown numPoliceCommentaire;
        private System.Windows.Forms.Button btnEnumCommentaire;
        private System.Windows.Forms.Button btnSouslignerCommentaire;
        private System.Windows.Forms.Button btnItaliqueCommentaire;
        private System.Windows.Forms.Button btnGrasCommentaire;
        private System.Windows.Forms.OpenFileDialog openFileDialogfichier;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
        private System.Windows.Forms.ListBox lstCatArtiste;
    }
}