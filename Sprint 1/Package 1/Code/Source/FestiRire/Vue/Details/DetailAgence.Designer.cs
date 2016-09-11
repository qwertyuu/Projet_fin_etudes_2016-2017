namespace FestiRire
{
    partial class DetailAgence
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
            this.txtNomAgence = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrerAgence = new System.Windows.Forms.Button();
            this.btnSupprimerAgence = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPays = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPosteBureau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelCellulaire = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBureau = new System.Windows.Forms.TextBox();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbAdresse = new System.Windows.Forms.RichTextBox();
            this.txtCourriel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomAgence
            // 
            this.txtNomAgence.Location = new System.Drawing.Point(120, 37);
            this.txtNomAgence.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomAgence.Name = "txtNomAgence";
            this.txtNomAgence.Size = new System.Drawing.Size(318, 20);
            this.txtNomAgence.TabIndex = 26;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 40);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "Nom de l\'agence:";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(367, 322);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 30;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrerAgence
            // 
            this.btnEnregistrerAgence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrerAgence.Location = new System.Drawing.Point(286, 322);
            this.btnEnregistrerAgence.Name = "btnEnregistrerAgence";
            this.btnEnregistrerAgence.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrerAgence.TabIndex = 30;
            this.btnEnregistrerAgence.Text = "Enregistrer";
            this.btnEnregistrerAgence.UseVisualStyleBackColor = true;
            this.btnEnregistrerAgence.Click += new System.EventHandler(this.btnEnregistrerAgence_Click);
            // 
            // btnSupprimerAgence
            // 
            this.btnSupprimerAgence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerAgence.Location = new System.Drawing.Point(206, 322);
            this.btnSupprimerAgence.Name = "btnSupprimerAgence";
            this.btnSupprimerAgence.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerAgence.TabIndex = 30;
            this.btnSupprimerAgence.Text = "Supprimer";
            this.btnSupprimerAgence.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtPays);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtVille);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtPosteBureau);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTelCellulaire);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtBureau);
            this.groupBox3.Controls.Add(this.cmbProvince);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtCodePostal);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.rtbAdresse);
            this.groupBox3.Location = new System.Drawing.Point(8, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 228);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adresse";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Pays:";
            // 
            // txtPays
            // 
            this.txtPays.Location = new System.Drawing.Point(9, 118);
            this.txtPays.Name = "txtPays";
            this.txtPays.ReadOnly = true;
            this.txtPays.Size = new System.Drawing.Size(118, 20);
            this.txtPays.TabIndex = 69;
            this.txtPays.Text = "Canada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Ville:";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(8, 199);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(118, 20);
            this.txtVille.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Poste:";
            // 
            // txtPosteBureau
            // 
            this.txtPosteBureau.Location = new System.Drawing.Point(260, 161);
            this.txtPosteBureau.Name = "txtPosteBureau";
            this.txtPosteBureau.Size = new System.Drawing.Size(48, 20);
            this.txtPosteBureau.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Téléphone cellulaire:";
            // 
            // txtTelCellulaire
            // 
            this.txtTelCellulaire.Location = new System.Drawing.Point(132, 199);
            this.txtTelCellulaire.Name = "txtTelCellulaire";
            this.txtTelCellulaire.Size = new System.Drawing.Size(118, 20);
            this.txtTelCellulaire.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Téléphone bureau:";
            // 
            // txtBureau
            // 
            this.txtBureau.Location = new System.Drawing.Point(132, 161);
            this.txtBureau.Name = "txtBureau";
            this.txtBureau.Size = new System.Drawing.Size(118, 20);
            this.txtBureau.TabIndex = 60;
            // 
            // cmbProvince
            // 
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Items.AddRange(new object[] {
            "AB",
            "BC",
            "IPE",
            "MB",
            "NB",
            "NS",
            "ON",
            "QC",
            "SK",
            "NL",
            "NU",
            "NT",
            "YT"});
            this.cmbProvince.Location = new System.Drawing.Point(8, 161);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(118, 21);
            this.cmbProvince.TabIndex = 59;
            this.cmbProvince.Text = "QC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Province:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Code postal:";
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(133, 118);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(118, 20);
            this.txtCodePostal.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Adresse civique:";
            // 
            // rtbAdresse
            // 
            this.rtbAdresse.Location = new System.Drawing.Point(6, 32);
            this.rtbAdresse.Name = "rtbAdresse";
            this.rtbAdresse.Size = new System.Drawing.Size(406, 66);
            this.rtbAdresse.TabIndex = 0;
            this.rtbAdresse.Text = "";
            // 
            // txtCourriel
            // 
            this.txtCourriel.Location = new System.Drawing.Point(120, 61);
            this.txtCourriel.Margin = new System.Windows.Forms.Padding(2);
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.Size = new System.Drawing.Size(318, 20);
            this.txtCourriel.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Courriel:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "Numéro de l\'agence:";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(120, 12);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(118, 20);
            this.txtNo.TabIndex = 71;
            // 
            // DetailAgence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(448, 354);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtCourriel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSupprimerAgence);
            this.Controls.Add(this.txtNomAgence);
            this.Controls.Add(this.btnEnregistrerAgence);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnAnnuler);
            this.Name = "DetailAgence";
            this.Text = "Détail de l\'agence";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomAgence;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrerAgence;
        private System.Windows.Forms.Button btnSupprimerAgence;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPosteBureau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelCellulaire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBureau;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbAdresse;
        private System.Windows.Forms.TextBox txtCourriel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPays;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNo;
    }
}