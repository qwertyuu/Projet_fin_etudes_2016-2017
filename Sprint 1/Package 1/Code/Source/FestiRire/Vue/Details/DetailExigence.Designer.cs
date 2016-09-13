namespace FestiRire
{
    partial class DetailExigence
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimerExigence = new System.Windows.Forms.Button();
            this.btnEnregistrerExigence = new System.Windows.Forms.Button();
            this.dateExigence = new System.Windows.Forms.DateTimePicker();
            this.txtMontant = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAjouterStatut = new System.Windows.Forms.Button();
            this.cmbEvenement = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbStatut = new System.Windows.Forms.ComboBox();
            this.numPoliceCommentaire = new System.Windows.Forms.NumericUpDown();
            this.btnEnumCommentaire = new System.Windows.Forms.Button();
            this.btnSouslignerCommentaire = new System.Windows.Forms.Button();
            this.btnItaliqueCommentaire = new System.Windows.Forms.Button();
            this.btnGrasCommentaire = new System.Windows.Forms.Button();
            this.rtbCommentaire = new System.Windows.Forms.RichTextBox();
            this.rtbDescriptionCourte = new System.Windows.Forms.RichTextBox();
            this.numPoliceDescriptionLongue = new System.Windows.Forms.NumericUpDown();
            this.btnEnumDescriptionLongue = new System.Windows.Forms.Button();
            this.btnSouslignerDescriptionLongue = new System.Windows.Forms.Button();
            this.btnItaliqueDescriptionLongue = new System.Windows.Forms.Button();
            this.btnGrasDescriptionLongue = new System.Windows.Forms.Button();
            this.rtbDescriptionLongue = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPoliceCommentaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoliceDescriptionLongue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Montant:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Commentaire:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(122, 18);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(424, 26);
            this.txtNom.TabIndex = 1;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(1071, 551);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(111, 45);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSupprimerExigence
            // 
            this.btnSupprimerExigence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerExigence.Location = new System.Drawing.Point(801, 551);
            this.btnSupprimerExigence.Name = "btnSupprimerExigence";
            this.btnSupprimerExigence.Size = new System.Drawing.Size(129, 45);
            this.btnSupprimerExigence.TabIndex = 7;
            this.btnSupprimerExigence.Text = "Supprimer";
            this.btnSupprimerExigence.UseVisualStyleBackColor = true;
            this.btnSupprimerExigence.Click += new System.EventHandler(this.btnSupprimerExigence_Click);
            // 
            // btnEnregistrerExigence
            // 
            this.btnEnregistrerExigence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrerExigence.Location = new System.Drawing.Point(936, 551);
            this.btnEnregistrerExigence.Name = "btnEnregistrerExigence";
            this.btnEnregistrerExigence.Size = new System.Drawing.Size(129, 45);
            this.btnEnregistrerExigence.TabIndex = 8;
            this.btnEnregistrerExigence.Text = "Enregistrer";
            this.btnEnregistrerExigence.UseVisualStyleBackColor = true;
            // 
            // dateExigence
            // 
            this.dateExigence.Location = new System.Drawing.Point(122, 57);
            this.dateExigence.Name = "dateExigence";
            this.dateExigence.Size = new System.Drawing.Size(202, 26);
            this.dateExigence.TabIndex = 23;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(122, 95);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(424, 26);
            this.txtMontant.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 138);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Statut:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description longue:";
            // 
            // btnAjouterStatut
            // 
            this.btnAjouterStatut.Location = new System.Drawing.Point(514, 134);
            this.btnAjouterStatut.Name = "btnAjouterStatut";
            this.btnAjouterStatut.Size = new System.Drawing.Size(34, 32);
            this.btnAjouterStatut.TabIndex = 46;
            this.btnAjouterStatut.Text = "+";
            this.btnAjouterStatut.UseVisualStyleBackColor = true;
            // 
            // cmbEvenement
            // 
            this.cmbEvenement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEvenement.FormattingEnabled = true;
            this.cmbEvenement.Location = new System.Drawing.Point(122, 174);
            this.cmbEvenement.Name = "cmbEvenement";
            this.cmbEvenement.Size = new System.Drawing.Size(426, 28);
            this.cmbEvenement.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 178);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 20);
            this.label13.TabIndex = 60;
            this.label13.Text = "Évènement:";
            // 
            // cmbStatut
            // 
            this.cmbStatut.DisplayMember = "nomStatut";
            this.cmbStatut.FormattingEnabled = true;
            this.cmbStatut.Location = new System.Drawing.Point(122, 134);
            this.cmbStatut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStatut.Name = "cmbStatut";
            this.cmbStatut.Size = new System.Drawing.Size(382, 28);
            this.cmbStatut.TabIndex = 62;
            // 
            // numPoliceCommentaire
            // 
            this.numPoliceCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numPoliceCommentaire.Location = new System.Drawing.Point(147, 246);
            this.numPoliceCommentaire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPoliceCommentaire.Name = "numPoliceCommentaire";
            this.numPoliceCommentaire.Size = new System.Drawing.Size(51, 26);
            this.numPoliceCommentaire.TabIndex = 67;
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
            this.btnEnumCommentaire.Location = new System.Drawing.Point(206, 245);
            this.btnEnumCommentaire.Name = "btnEnumCommentaire";
            this.btnEnumCommentaire.Size = new System.Drawing.Size(63, 32);
            this.btnEnumCommentaire.TabIndex = 66;
            this.btnEnumCommentaire.Text = "Enum";
            this.btnEnumCommentaire.UseVisualStyleBackColor = true;
            this.btnEnumCommentaire.Click += new System.EventHandler(this.btnEnumCommentaire_Click);
            // 
            // btnSouslignerCommentaire
            // 
            this.btnSouslignerCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSouslignerCommentaire.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSouslignerCommentaire.Location = new System.Drawing.Point(105, 246);
            this.btnSouslignerCommentaire.Name = "btnSouslignerCommentaire";
            this.btnSouslignerCommentaire.Size = new System.Drawing.Size(34, 32);
            this.btnSouslignerCommentaire.TabIndex = 63;
            this.btnSouslignerCommentaire.Text = "I";
            this.btnSouslignerCommentaire.UseVisualStyleBackColor = true;
            this.btnSouslignerCommentaire.Click += new System.EventHandler(this.btnSouslignerCommentaire_Click);
            // 
            // btnItaliqueCommentaire
            // 
            this.btnItaliqueCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItaliqueCommentaire.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItaliqueCommentaire.Location = new System.Drawing.Point(64, 246);
            this.btnItaliqueCommentaire.Name = "btnItaliqueCommentaire";
            this.btnItaliqueCommentaire.Size = new System.Drawing.Size(34, 32);
            this.btnItaliqueCommentaire.TabIndex = 64;
            this.btnItaliqueCommentaire.Text = "I";
            this.btnItaliqueCommentaire.UseVisualStyleBackColor = true;
            this.btnItaliqueCommentaire.Click += new System.EventHandler(this.btnItaliqueCommentaire_Click);
            // 
            // btnGrasCommentaire
            // 
            this.btnGrasCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrasCommentaire.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrasCommentaire.Location = new System.Drawing.Point(24, 246);
            this.btnGrasCommentaire.Name = "btnGrasCommentaire";
            this.btnGrasCommentaire.Size = new System.Drawing.Size(34, 32);
            this.btnGrasCommentaire.TabIndex = 65;
            this.btnGrasCommentaire.Text = "B";
            this.btnGrasCommentaire.UseVisualStyleBackColor = true;
            this.btnGrasCommentaire.Click += new System.EventHandler(this.btnGrasCommentaire_Click);
            // 
            // rtbCommentaire
            // 
            this.rtbCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCommentaire.Location = new System.Drawing.Point(22, 285);
            this.rtbCommentaire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbCommentaire.Name = "rtbCommentaire";
            this.rtbCommentaire.Size = new System.Drawing.Size(523, 253);
            this.rtbCommentaire.TabIndex = 68;
            this.rtbCommentaire.Text = "";
            // 
            // rtbDescriptionCourte
            // 
            this.rtbDescriptionCourte.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rtbDescriptionCourte.Location = new System.Drawing.Point(555, 39);
            this.rtbDescriptionCourte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbDescriptionCourte.Name = "rtbDescriptionCourte";
            this.rtbDescriptionCourte.Size = new System.Drawing.Size(627, 163);
            this.rtbDescriptionCourte.TabIndex = 70;
            this.rtbDescriptionCourte.Text = "";
            // 
            // numPoliceDescriptionLongue
            // 
            this.numPoliceDescriptionLongue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numPoliceDescriptionLongue.Location = new System.Drawing.Point(677, 245);
            this.numPoliceDescriptionLongue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPoliceDescriptionLongue.Name = "numPoliceDescriptionLongue";
            this.numPoliceDescriptionLongue.Size = new System.Drawing.Size(51, 26);
            this.numPoliceDescriptionLongue.TabIndex = 81;
            this.numPoliceDescriptionLongue.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numPoliceDescriptionLongue.ValueChanged += new System.EventHandler(this.numPoliceDescriptionLongue_ValueChanged);
            // 
            // btnEnumDescriptionLongue
            // 
            this.btnEnumDescriptionLongue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnumDescriptionLongue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnumDescriptionLongue.Location = new System.Drawing.Point(735, 241);
            this.btnEnumDescriptionLongue.Name = "btnEnumDescriptionLongue";
            this.btnEnumDescriptionLongue.Size = new System.Drawing.Size(63, 32);
            this.btnEnumDescriptionLongue.TabIndex = 80;
            this.btnEnumDescriptionLongue.Text = "Enum";
            this.btnEnumDescriptionLongue.UseVisualStyleBackColor = true;
            this.btnEnumDescriptionLongue.Click += new System.EventHandler(this.btnEnumDescriptionLongue_Click);
            // 
            // btnSouslignerDescriptionLongue
            // 
            this.btnSouslignerDescriptionLongue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSouslignerDescriptionLongue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSouslignerDescriptionLongue.Location = new System.Drawing.Point(636, 245);
            this.btnSouslignerDescriptionLongue.Name = "btnSouslignerDescriptionLongue";
            this.btnSouslignerDescriptionLongue.Size = new System.Drawing.Size(34, 32);
            this.btnSouslignerDescriptionLongue.TabIndex = 77;
            this.btnSouslignerDescriptionLongue.Text = "I";
            this.btnSouslignerDescriptionLongue.UseVisualStyleBackColor = true;
            this.btnSouslignerDescriptionLongue.Click += new System.EventHandler(this.btnSouslignerDescriptionLongue_Click);
            // 
            // btnItaliqueDescriptionLongue
            // 
            this.btnItaliqueDescriptionLongue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItaliqueDescriptionLongue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItaliqueDescriptionLongue.Location = new System.Drawing.Point(596, 246);
            this.btnItaliqueDescriptionLongue.Name = "btnItaliqueDescriptionLongue";
            this.btnItaliqueDescriptionLongue.Size = new System.Drawing.Size(34, 32);
            this.btnItaliqueDescriptionLongue.TabIndex = 78;
            this.btnItaliqueDescriptionLongue.Text = "I";
            this.btnItaliqueDescriptionLongue.UseVisualStyleBackColor = true;
            this.btnItaliqueDescriptionLongue.Click += new System.EventHandler(this.btnItaliqueDescriptionLongue_Click);
            // 
            // btnGrasDescriptionLongue
            // 
            this.btnGrasDescriptionLongue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrasDescriptionLongue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrasDescriptionLongue.Location = new System.Drawing.Point(556, 245);
            this.btnGrasDescriptionLongue.Name = "btnGrasDescriptionLongue";
            this.btnGrasDescriptionLongue.Size = new System.Drawing.Size(34, 32);
            this.btnGrasDescriptionLongue.TabIndex = 79;
            this.btnGrasDescriptionLongue.Text = "B";
            this.btnGrasDescriptionLongue.UseVisualStyleBackColor = true;
            this.btnGrasDescriptionLongue.Click += new System.EventHandler(this.btnGrasDescriptionLongue_Click);
            // 
            // rtbDescriptionLongue
            // 
            this.rtbDescriptionLongue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rtbDescriptionLongue.Location = new System.Drawing.Point(561, 290);
            this.rtbDescriptionLongue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbDescriptionLongue.Name = "rtbDescriptionLongue";
            this.rtbDescriptionLongue.Size = new System.Drawing.Size(624, 253);
            this.rtbDescriptionLongue.TabIndex = 76;
            this.rtbDescriptionLongue.Text = "";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Description courte:";
            // 
            // DetailExigence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(1198, 612);
            this.Controls.Add(this.numPoliceDescriptionLongue);
            this.Controls.Add(this.btnEnumDescriptionLongue);
            this.Controls.Add(this.btnSouslignerDescriptionLongue);
            this.Controls.Add(this.btnItaliqueDescriptionLongue);
            this.Controls.Add(this.btnGrasDescriptionLongue);
            this.Controls.Add(this.rtbDescriptionLongue);
            this.Controls.Add(this.rtbDescriptionCourte);
            this.Controls.Add(this.rtbCommentaire);
            this.Controls.Add(this.numPoliceCommentaire);
            this.Controls.Add(this.btnEnumCommentaire);
            this.Controls.Add(this.btnSouslignerCommentaire);
            this.Controls.Add(this.btnItaliqueCommentaire);
            this.Controls.Add(this.btnGrasCommentaire);
            this.Controls.Add(this.cmbStatut);
            this.Controls.Add(this.cmbEvenement);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAjouterStatut);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.dateExigence);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimerExigence);
            this.Controls.Add(this.btnEnregistrerExigence);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DetailExigence";
            this.Text = "Détail de l\'exigence";
            ((System.ComponentModel.ISupportInitialize)(this.numPoliceCommentaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoliceDescriptionLongue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupprimerExigence;
        private System.Windows.Forms.Button btnEnregistrerExigence;
        private System.Windows.Forms.DateTimePicker dateExigence;
        private System.Windows.Forms.MaskedTextBox txtMontant;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAjouterStatut;
        private System.Windows.Forms.ComboBox cmbEvenement;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbStatut;
        private System.Windows.Forms.NumericUpDown numPoliceCommentaire;
        private System.Windows.Forms.Button btnEnumCommentaire;
        private System.Windows.Forms.Button btnSouslignerCommentaire;
        private System.Windows.Forms.Button btnItaliqueCommentaire;
        private System.Windows.Forms.Button btnGrasCommentaire;
        private System.Windows.Forms.RichTextBox rtbCommentaire;
        private System.Windows.Forms.RichTextBox rtbDescriptionCourte;
        private System.Windows.Forms.NumericUpDown numPoliceDescriptionLongue;
        private System.Windows.Forms.Button btnEnumDescriptionLongue;
        private System.Windows.Forms.Button btnSouslignerDescriptionLongue;
        private System.Windows.Forms.Button btnItaliqueDescriptionLongue;
        private System.Windows.Forms.Button btnGrasDescriptionLongue;
        private System.Windows.Forms.RichTextBox rtbDescriptionLongue;
        private System.Windows.Forms.Label label6;
    }
}