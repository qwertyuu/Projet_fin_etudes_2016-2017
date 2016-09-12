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
            this.btnAnnuler.Location = new System.Drawing.Point(482, 602);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(112, 35);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrerStatut
            // 
            this.btnEnregistrerStatut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrerStatut.Location = new System.Drawing.Point(360, 602);
            this.btnEnregistrerStatut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnregistrerStatut.Name = "btnEnregistrerStatut";
            this.btnEnregistrerStatut.Size = new System.Drawing.Size(112, 35);
            this.btnEnregistrerStatut.TabIndex = 9;
            this.btnEnregistrerStatut.Text = "Enregistrer";
            this.btnEnregistrerStatut.UseVisualStyleBackColor = true;
            this.btnEnregistrerStatut.Click += new System.EventHandler(this.btnEnregistrerStatut_Click_1);
            // 
            // txtNom
            // 
            this.txtNom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNom.Location = new System.Drawing.Point(195, 23);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(402, 26);
            this.txtNom.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 565);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code de couleur:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom du statut:";
            // 
            // btnSupprimerStatut
            // 
            this.btnSupprimerStatut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerStatut.Location = new System.Drawing.Point(238, 602);
            this.btnSupprimerStatut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupprimerStatut.Name = "btnSupprimerStatut";
            this.btnSupprimerStatut.Size = new System.Drawing.Size(112, 35);
            this.btnSupprimerStatut.TabIndex = 9;
            this.btnSupprimerStatut.Text = "Supprimer";
            this.btnSupprimerStatut.UseVisualStyleBackColor = true;
            // 
            // btnChoixCouleur
            // 
            this.btnChoixCouleur.Location = new System.Drawing.Point(192, 557);
            this.btnChoixCouleur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChoixCouleur.Name = "btnChoixCouleur";
            this.btnChoixCouleur.Size = new System.Drawing.Size(234, 35);
            this.btnChoixCouleur.TabIndex = 9;
            this.btnChoixCouleur.Text = "Choisir une couleur...";
            this.btnChoixCouleur.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 565);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aperçu:";
            // 
            // pbApercuCouleur
            // 
            this.pbApercuCouleur.BackColor = System.Drawing.Color.Maroon;
            this.pbApercuCouleur.Location = new System.Drawing.Point(510, 557);
            this.pbApercuCouleur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbApercuCouleur.Name = "pbApercuCouleur";
            this.pbApercuCouleur.Size = new System.Drawing.Size(84, 35);
            this.pbApercuCouleur.TabIndex = 10;
            this.pbApercuCouleur.TabStop = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(20, 66);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(160, 20);
            this.label32.TabIndex = 32;
            this.label32.Text = "Description du statut:";
            // 
            // numPoliceDescription
            // 
            this.numPoliceDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numPoliceDescription.Location = new System.Drawing.Point(318, 63);
            this.numPoliceDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPoliceDescription.Name = "numPoliceDescription";
            this.numPoliceDescription.Size = new System.Drawing.Size(51, 26);
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
            this.btnEnumDescription.Location = new System.Drawing.Point(376, 62);
            this.btnEnumDescription.Name = "btnEnumDescription";
            this.btnEnumDescription.Size = new System.Drawing.Size(63, 32);
            this.btnEnumDescription.TabIndex = 37;
            this.btnEnumDescription.Text = "Enum";
            this.btnEnumDescription.UseVisualStyleBackColor = true;
            this.btnEnumDescription.Click += new System.EventHandler(this.btnEnumDescription_Click);
            // 
            // btnSouslignerDescription
            // 
            this.btnSouslignerDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSouslignerDescription.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSouslignerDescription.Location = new System.Drawing.Point(276, 62);
            this.btnSouslignerDescription.Name = "btnSouslignerDescription";
            this.btnSouslignerDescription.Size = new System.Drawing.Size(34, 32);
            this.btnSouslignerDescription.TabIndex = 34;
            this.btnSouslignerDescription.Text = "I";
            this.btnSouslignerDescription.UseVisualStyleBackColor = true;
            this.btnSouslignerDescription.Click += new System.EventHandler(this.btnSouslignerDescription_Click);
            // 
            // btnItaliqueDescription
            // 
            this.btnItaliqueDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItaliqueDescription.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItaliqueDescription.Location = new System.Drawing.Point(236, 62);
            this.btnItaliqueDescription.Name = "btnItaliqueDescription";
            this.btnItaliqueDescription.Size = new System.Drawing.Size(34, 32);
            this.btnItaliqueDescription.TabIndex = 35;
            this.btnItaliqueDescription.Text = "I";
            this.btnItaliqueDescription.UseVisualStyleBackColor = true;
            this.btnItaliqueDescription.Click += new System.EventHandler(this.btnItaliqueDescription_Click);
            // 
            // btnGrasDescription
            // 
            this.btnGrasDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrasDescription.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrasDescription.Location = new System.Drawing.Point(195, 62);
            this.btnGrasDescription.Name = "btnGrasDescription";
            this.btnGrasDescription.Size = new System.Drawing.Size(34, 32);
            this.btnGrasDescription.TabIndex = 36;
            this.btnGrasDescription.Text = "B";
            this.btnGrasDescription.UseVisualStyleBackColor = true;
            this.btnGrasDescription.Click += new System.EventHandler(this.btnGrasDescription_Click);
            // 
            // rtbDescriptionStatut
            // 
            this.rtbDescriptionStatut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDescriptionStatut.Location = new System.Drawing.Point(194, 102);
            this.rtbDescriptionStatut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbDescriptionStatut.Name = "rtbDescriptionStatut";
            this.rtbDescriptionStatut.Size = new System.Drawing.Size(398, 444);
            this.rtbDescriptionStatut.TabIndex = 33;
            this.rtbDescriptionStatut.Text = "";
            // 
            // DetailStatut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(612, 655);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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