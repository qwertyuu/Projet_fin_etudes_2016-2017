namespace FestiRire
{
    partial class DetailCategorieArtiste
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomCategorie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbDescriptionCategorie = new System.Windows.Forms.RichTextBox();
            this.btnEnregistrerArtiste = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimerArtiste = new System.Windows.Forms.Button();
            this.btnUnderlineCatArtiste = new System.Windows.Forms.Button();
            this.btnItalicCatArtiste = new System.Windows.Forms.Button();
            this.btnGrasCatArtiste = new System.Windows.Forms.Button();
            this.numericUpDownCatArtiste = new System.Windows.Forms.NumericUpDown();
            this.btnEnumCatArtiste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCatArtiste)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom:";
            // 
            // txtNomCategorie
            // 
            this.txtNomCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomCategorie.Location = new System.Drawing.Point(78, 9);
            this.txtNomCategorie.Name = "txtNomCategorie";
            this.txtNomCategorie.Size = new System.Drawing.Size(263, 20);
            this.txtNomCategorie.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description:";
            // 
            // rtbDescriptionCategorie
            // 
            this.rtbDescriptionCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDescriptionCategorie.Location = new System.Drawing.Point(78, 64);
            this.rtbDescriptionCategorie.Name = "rtbDescriptionCategorie";
            this.rtbDescriptionCategorie.Size = new System.Drawing.Size(263, 313);
            this.rtbDescriptionCategorie.TabIndex = 2;
            this.rtbDescriptionCategorie.Text = "";
            // 
            // btnEnregistrerArtiste
            // 
            this.btnEnregistrerArtiste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrerArtiste.Location = new System.Drawing.Point(185, 389);
            this.btnEnregistrerArtiste.Name = "btnEnregistrerArtiste";
            this.btnEnregistrerArtiste.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrerArtiste.TabIndex = 3;
            this.btnEnregistrerArtiste.Text = "Enregistrer";
            this.btnEnregistrerArtiste.UseVisualStyleBackColor = true;
            this.btnEnregistrerArtiste.Click += new System.EventHandler(this.btnEnregistrerArtiste_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Location = new System.Drawing.Point(266, 389);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSupprimerArtiste
            // 
            this.btnSupprimerArtiste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerArtiste.Location = new System.Drawing.Point(101, 389);
            this.btnSupprimerArtiste.Name = "btnSupprimerArtiste";
            this.btnSupprimerArtiste.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerArtiste.TabIndex = 3;
            this.btnSupprimerArtiste.Text = "Supprimer";
            this.btnSupprimerArtiste.UseVisualStyleBackColor = true;
            this.btnSupprimerArtiste.Click += new System.EventHandler(this.btnSupprimerArtiste_Click);
            // 
            // btnUnderlineCatArtiste
            // 
            this.btnUnderlineCatArtiste.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnderlineCatArtiste.Location = new System.Drawing.Point(134, 38);
            this.btnUnderlineCatArtiste.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnderlineCatArtiste.Name = "btnUnderlineCatArtiste";
            this.btnUnderlineCatArtiste.Size = new System.Drawing.Size(23, 21);
            this.btnUnderlineCatArtiste.TabIndex = 9;
            this.btnUnderlineCatArtiste.Text = "I";
            this.btnUnderlineCatArtiste.UseVisualStyleBackColor = true;
            this.btnUnderlineCatArtiste.Click += new System.EventHandler(this.btnUnderlineCatArtiste_Click);
            // 
            // btnItalicCatArtiste
            // 
            this.btnItalicCatArtiste.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItalicCatArtiste.Location = new System.Drawing.Point(107, 38);
            this.btnItalicCatArtiste.Margin = new System.Windows.Forms.Padding(2);
            this.btnItalicCatArtiste.Name = "btnItalicCatArtiste";
            this.btnItalicCatArtiste.Size = new System.Drawing.Size(23, 21);
            this.btnItalicCatArtiste.TabIndex = 10;
            this.btnItalicCatArtiste.Text = "I";
            this.btnItalicCatArtiste.UseVisualStyleBackColor = true;
            this.btnItalicCatArtiste.Click += new System.EventHandler(this.btnItalicCatArtiste_Click);
            // 
            // btnGrasCatArtiste
            // 
            this.btnGrasCatArtiste.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrasCatArtiste.Location = new System.Drawing.Point(80, 38);
            this.btnGrasCatArtiste.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrasCatArtiste.Name = "btnGrasCatArtiste";
            this.btnGrasCatArtiste.Size = new System.Drawing.Size(23, 21);
            this.btnGrasCatArtiste.TabIndex = 11;
            this.btnGrasCatArtiste.Text = "B";
            this.btnGrasCatArtiste.UseVisualStyleBackColor = true;
            this.btnGrasCatArtiste.Click += new System.EventHandler(this.btnGrasCatArtiste_Click);
            // 
            // numericUpDownCatArtiste
            // 
            this.numericUpDownCatArtiste.Location = new System.Drawing.Point(162, 39);
            this.numericUpDownCatArtiste.Name = "numericUpDownCatArtiste";
            this.numericUpDownCatArtiste.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownCatArtiste.TabIndex = 12;
            this.numericUpDownCatArtiste.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownCatArtiste.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnEnumCatArtiste
            // 
            this.btnEnumCatArtiste.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnumCatArtiste.Location = new System.Drawing.Point(201, 38);
            this.btnEnumCatArtiste.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnumCatArtiste.Name = "btnEnumCatArtiste";
            this.btnEnumCatArtiste.Size = new System.Drawing.Size(42, 21);
            this.btnEnumCatArtiste.TabIndex = 11;
            this.btnEnumCatArtiste.Text = "Enum";
            this.btnEnumCatArtiste.UseVisualStyleBackColor = true;
            this.btnEnumCatArtiste.Click += new System.EventHandler(this.btnEnumCatArtiste_Click);
            // 
            // DetailCategorieArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 424);
            this.Controls.Add(this.numericUpDownCatArtiste);
            this.Controls.Add(this.btnUnderlineCatArtiste);
            this.Controls.Add(this.btnItalicCatArtiste);
            this.Controls.Add(this.btnEnumCatArtiste);
            this.Controls.Add(this.btnGrasCatArtiste);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimerArtiste);
            this.Controls.Add(this.btnEnregistrerArtiste);
            this.Controls.Add(this.rtbDescriptionCategorie);
            this.Controls.Add(this.txtNomCategorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(301, 140);
            this.Name = "DetailCategorieArtiste";
            this.Text = "Détail de la catégorie d\'artiste";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCatArtiste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomCategorie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbDescriptionCategorie;
        private System.Windows.Forms.Button btnEnregistrerArtiste;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupprimerArtiste;
        private System.Windows.Forms.Button btnUnderlineCatArtiste;
        private System.Windows.Forms.Button btnItalicCatArtiste;
        private System.Windows.Forms.Button btnGrasCatArtiste;
        private System.Windows.Forms.NumericUpDown numericUpDownCatArtiste;
        private System.Windows.Forms.Button btnEnumCatArtiste;
    }
}