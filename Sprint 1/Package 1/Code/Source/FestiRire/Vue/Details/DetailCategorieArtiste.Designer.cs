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
            this.txtNomCategorie.Size = new System.Drawing.Size(678, 20);
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
            this.rtbDescriptionCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescriptionCategorie.Location = new System.Drawing.Point(78, 44);
            this.rtbDescriptionCategorie.Name = "rtbDescriptionCategorie";
            this.rtbDescriptionCategorie.Size = new System.Drawing.Size(678, 333);
            this.rtbDescriptionCategorie.TabIndex = 2;
            this.rtbDescriptionCategorie.Text = "";
            // 
            // btnEnregistrerArtiste
            // 
            this.btnEnregistrerArtiste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrerArtiste.Location = new System.Drawing.Point(600, 389);
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
            this.btnAnnuler.Location = new System.Drawing.Point(681, 389);
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
            this.btnSupprimerArtiste.Location = new System.Drawing.Point(516, 389);
            this.btnSupprimerArtiste.Name = "btnSupprimerArtiste";
            this.btnSupprimerArtiste.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerArtiste.TabIndex = 3;
            this.btnSupprimerArtiste.Text = "Supprimer";
            this.btnSupprimerArtiste.UseVisualStyleBackColor = true;
            this.btnSupprimerArtiste.Click += new System.EventHandler(this.btnSupprimerArtiste_Click);
            // 
            // DetailCategorieArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(768, 424);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimerArtiste);
            this.Controls.Add(this.btnEnregistrerArtiste);
            this.Controls.Add(this.rtbDescriptionCategorie);
            this.Controls.Add(this.txtNomCategorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(301, 140);
            this.Name = "DetailCategorieArtiste";
            this.Text = "Détail de la catégorie d\'artiste";
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
    }
}