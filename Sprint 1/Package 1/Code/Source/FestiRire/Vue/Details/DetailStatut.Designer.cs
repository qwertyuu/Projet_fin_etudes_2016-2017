namespace FestiRire
{
    partial class DetailStatut
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrerStatut = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSupprimerStatut = new System.Windows.Forms.Button();
            this.btnChoixCouleur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pbApercuCouleur = new System.Windows.Forms.PictureBox();
            this.label32 = new System.Windows.Forms.Label();
            this.numPoliceDescription = new System.Windows.Forms.NumericUpDown();
            this.btnEnumDescription = new System.Windows.Forms.Button();
            this.btnSouslignerDescription = new System.Windows.Forms.Button();
            this.btnItaliqueDescription = new System.Windows.Forms.Button();
            this.btnGrasDescription = new System.Windows.Forms.Button();
            this.rtbDescriptionStatut = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbApercuCouleur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoliceDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(321, 391);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrerStatut
            // 
            this.btnEnregistrerStatut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrerStatut.Location = new System.Drawing.Point(240, 391);
            this.btnEnregistrerStatut.Name = "btnEnregistrerStatut";
            this.btnEnregistrerStatut.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrerStatut.TabIndex = 9;
            this.btnEnregistrerStatut.Text = "Enregistrer";
            this.btnEnregistrerStatut.UseVisualStyleBackColor = true;
            this.btnEnregistrerStatut.Click += new System.EventHandler(this.btnEnregistrerStatut_Click_1);
            // 
            // txtNom
            // 
            this.txtNom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNom.Location = new System.Drawing.Point(130, 15);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(269, 20);
            this.txtNom.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code de couleur:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom du statut:";
            // 
            // btnSupprimerStatut
            // 
            this.btnSupprimerStatut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerStatut.Location = new System.Drawing.Point(159, 391);
            this.btnSupprimerStatut.Name = "btnSupprimerStatut";
            this.btnSupprimerStatut.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerStatut.TabIndex = 9;
            this.btnSupprimerStatut.Text = "Supprimer";
            this.btnSupprimerStatut.UseVisualStyleBackColor = true;
            // 
            // btnChoixCouleur
            // 
            this.btnChoixCouleur.Location = new System.Drawing.Point(128, 362);
            this.btnChoixCouleur.Name = "btnChoixCouleur";
            this.btnChoixCouleur.Size = new System.Drawing.Size(156, 23);
            this.btnChoixCouleur.TabIndex = 9;
            this.btnChoixCouleur.Text = "Choisir une couleur...";
            this.btnChoixCouleur.UseVisualStyleBackColor = true;
            this.btnChoixCouleur.Click += new System.EventHandler(this.btnChoixCouleur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aperçu:";
            // 
            // pbApercuCouleur
            // 
            this.pbApercuCouleur.BackColor = System.Drawing.Color.Maroon;
            this.pbApercuCouleur.Location = new System.Drawing.Point(340, 362);
            this.pbApercuCouleur.Name = "pbApercuCouleur";
            this.pbApercuCouleur.Size = new System.Drawing.Size(56, 23);
            this.pbApercuCouleur.TabIndex = 10;
            this.pbApercuCouleur.TabStop = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(13, 43);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(107, 13);
            this.label32.TabIndex = 32;
            this.label32.Text = "Description du statut:";
            // 
            // numPoliceDescription
            // 
            this.numPoliceDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numPoliceDescription.Location = new System.Drawing.Point(212, 41);
            this.numPoliceDescription.Name = "numPoliceDescription";
            this.numPoliceDescription.Size = new System.Drawing.Size(34, 20);
            this.numPoliceDescription.TabIndex = 38;
            this.numPoliceDescription.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numPoliceDescription.ValueChanged += new System.EventHandler(this.numPoliceDescription_ValueChanged);
            // 
            // btnEnumDescription
            // 
            this.btnEnumDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnumDescription.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnumDescription.Location = new System.Drawing.Point(251, 40);
            this.btnEnumDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnumDescription.Name = "btnEnumDescription";
            this.btnEnumDescription.Size = new System.Drawing.Size(42, 21);
            this.btnEnumDescription.TabIndex = 37;
            this.btnEnumDescription.Text = "Enum";
            this.btnEnumDescription.UseVisualStyleBackColor = true;
            this.btnEnumDescription.Click += new System.EventHandler(this.btnEnumDescription_Click);
            // 
            // btnSouslignerDescription
            // 
            this.btnSouslignerDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSouslignerDescription.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSouslignerDescription.Location = new System.Drawing.Point(184, 40);
            this.btnSouslignerDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSouslignerDescription.Name = "btnSouslignerDescription";
            this.btnSouslignerDescription.Size = new System.Drawing.Size(23, 21);
            this.btnSouslignerDescription.TabIndex = 34;
            this.btnSouslignerDescription.Text = "I";
            this.btnSouslignerDescription.UseVisualStyleBackColor = true;
            this.btnSouslignerDescription.Click += new System.EventHandler(this.btnSouslignerDescription_Click);
            // 
            // btnItaliqueDescription
            // 
            this.btnItaliqueDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItaliqueDescription.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItaliqueDescription.Location = new System.Drawing.Point(157, 40);
            this.btnItaliqueDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnItaliqueDescription.Name = "btnItaliqueDescription";
            this.btnItaliqueDescription.Size = new System.Drawing.Size(23, 21);
            this.btnItaliqueDescription.TabIndex = 35;
            this.btnItaliqueDescription.Text = "I";
            this.btnItaliqueDescription.UseVisualStyleBackColor = true;
            this.btnItaliqueDescription.Click += new System.EventHandler(this.btnItaliqueDescription_Click);
            // 
            // btnGrasDescription
            // 
            this.btnGrasDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrasDescription.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrasDescription.Location = new System.Drawing.Point(130, 40);
            this.btnGrasDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGrasDescription.Name = "btnGrasDescription";
            this.btnGrasDescription.Size = new System.Drawing.Size(23, 21);
            this.btnGrasDescription.TabIndex = 36;
            this.btnGrasDescription.Text = "B";
            this.btnGrasDescription.UseVisualStyleBackColor = true;
            this.btnGrasDescription.Click += new System.EventHandler(this.btnGrasDescription_Click);
            // 
            // rtbDescriptionStatut
            // 
            this.rtbDescriptionStatut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDescriptionStatut.Location = new System.Drawing.Point(129, 66);
            this.rtbDescriptionStatut.Name = "rtbDescriptionStatut";
            this.rtbDescriptionStatut.Size = new System.Drawing.Size(267, 290);
            this.rtbDescriptionStatut.TabIndex = 33;
            this.rtbDescriptionStatut.Text = "";
            // 
            // DetailStatut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(408, 426);
            this.Controls.Add(this.numPoliceDescription);
            this.Controls.Add(this.btnEnumDescription);
            this.Controls.Add(this.btnSouslignerDescription);
            this.Controls.Add(this.btnItaliqueDescription);
            this.Controls.Add(this.btnGrasDescription);
            this.Controls.Add(this.rtbDescriptionStatut);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.pbApercuCouleur);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnChoixCouleur);
            this.Controls.Add(this.btnSupprimerStatut);
            this.Controls.Add(this.btnEnregistrerStatut);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetailStatut";
            this.Text = "Détail du statut";
            ((System.ComponentModel.ISupportInitialize)(this.pbApercuCouleur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoliceDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrerStatut;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSupprimerStatut;
        private System.Windows.Forms.Button btnChoixCouleur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbApercuCouleur;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown numPoliceDescription;
        private System.Windows.Forms.Button btnEnumDescription;
        private System.Windows.Forms.Button btnSouslignerDescription;
        private System.Windows.Forms.Button btnItaliqueDescription;
        private System.Windows.Forms.Button btnGrasDescription;
        private System.Windows.Forms.RichTextBox rtbDescriptionStatut;
    }
}