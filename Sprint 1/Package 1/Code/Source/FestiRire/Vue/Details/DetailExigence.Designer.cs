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
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPoliceCommentaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoliceDescriptionLongue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Montant:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Commentaire:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(81, 12);
            this.txtNom.MaxLength = 30;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(284, 20);
            this.txtNom.TabIndex = 1;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Location = new System.Drawing.Point(716, 358);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(74, 29);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSupprimerExigence
            // 
            this.btnSupprimerExigence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerExigence.Location = new System.Drawing.Point(536, 358);
            this.btnSupprimerExigence.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimerExigence.Name = "btnSupprimerExigence";
            this.btnSupprimerExigence.Size = new System.Drawing.Size(86, 29);
            this.btnSupprimerExigence.TabIndex = 7;
            this.btnSupprimerExigence.Text = "Supprimer";
            this.btnSupprimerExigence.UseVisualStyleBackColor = true;
            this.btnSupprimerExigence.Click += new System.EventHandler(this.btnSupprimerExigence_Click);
            // 
            // btnEnregistrerExigence
            // 
            this.btnEnregistrerExigence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrerExigence.Location = new System.Drawing.Point(626, 358);
            this.btnEnregistrerExigence.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnregistrerExigence.Name = "btnEnregistrerExigence";
            this.btnEnregistrerExigence.Size = new System.Drawing.Size(86, 29);
            this.btnEnregistrerExigence.TabIndex = 8;
            this.btnEnregistrerExigence.Text = "Enregistrer";
            this.btnEnregistrerExigence.UseVisualStyleBackColor = true;
            this.btnEnregistrerExigence.Click += new System.EventHandler(this.btnEnregistrerExigence_Click);
            // 
            // dateExigence
            // 
            this.dateExigence.Location = new System.Drawing.Point(81, 37);
            this.dateExigence.Margin = new System.Windows.Forms.Padding(2);
            this.dateExigence.Name = "dateExigence";
            this.dateExigence.Size = new System.Drawing.Size(136, 20);
            this.dateExigence.TabIndex = 23;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(81, 62);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(284, 20);
            this.txtMontant.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Statut:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description longue:";
            // 
            // cmbEvenement
            // 
            this.cmbEvenement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEvenement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvenement.Enabled = false;
            this.cmbEvenement.FormattingEnabled = true;
            this.cmbEvenement.Location = new System.Drawing.Point(81, 113);
            this.cmbEvenement.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEvenement.Name = "cmbEvenement";
            this.cmbEvenement.Size = new System.Drawing.Size(284, 21);
            this.cmbEvenement.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "Évènement:";
            // 
            // cmbStatut
            // 
            this.cmbStatut.DisplayMember = "nomStatut";
            this.cmbStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatut.FormattingEnabled = true;
            this.cmbStatut.Location = new System.Drawing.Point(81, 87);
            this.cmbStatut.Name = "cmbStatut";
            this.cmbStatut.Size = new System.Drawing.Size(284, 21);
            this.cmbStatut.TabIndex = 62;
            // 
            // numPoliceCommentaire
            // 
            this.numPoliceCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numPoliceCommentaire.Location = new System.Drawing.Point(98, 163);
            this.numPoliceCommentaire.Name = "numPoliceCommentaire";
            this.numPoliceCommentaire.Size = new System.Drawing.Size(34, 20);
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
            this.btnEnumCommentaire.Location = new System.Drawing.Point(137, 162);
            this.btnEnumCommentaire.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnumCommentaire.Name = "btnEnumCommentaire";
            this.btnEnumCommentaire.Size = new System.Drawing.Size(42, 21);
            this.btnEnumCommentaire.TabIndex = 66;
            this.btnEnumCommentaire.Text = "Enum";
            this.btnEnumCommentaire.UseVisualStyleBackColor = true;
            this.btnEnumCommentaire.Click += new System.EventHandler(this.btnEnumCommentaire_Click);
            // 
            // btnSouslignerCommentaire
            // 
            this.btnSouslignerCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSouslignerCommentaire.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSouslignerCommentaire.Location = new System.Drawing.Point(70, 163);
            this.btnSouslignerCommentaire.Margin = new System.Windows.Forms.Padding(2);
            this.btnSouslignerCommentaire.Name = "btnSouslignerCommentaire";
            this.btnSouslignerCommentaire.Size = new System.Drawing.Size(23, 21);
            this.btnSouslignerCommentaire.TabIndex = 63;
            this.btnSouslignerCommentaire.Text = "I";
            this.btnSouslignerCommentaire.UseVisualStyleBackColor = true;
            this.btnSouslignerCommentaire.Click += new System.EventHandler(this.btnSouslignerCommentaire_Click);
            // 
            // btnItaliqueCommentaire
            // 
            this.btnItaliqueCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItaliqueCommentaire.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItaliqueCommentaire.Location = new System.Drawing.Point(43, 163);
            this.btnItaliqueCommentaire.Margin = new System.Windows.Forms.Padding(2);
            this.btnItaliqueCommentaire.Name = "btnItaliqueCommentaire";
            this.btnItaliqueCommentaire.Size = new System.Drawing.Size(23, 21);
            this.btnItaliqueCommentaire.TabIndex = 64;
            this.btnItaliqueCommentaire.Text = "I";
            this.btnItaliqueCommentaire.UseVisualStyleBackColor = true;
            this.btnItaliqueCommentaire.Click += new System.EventHandler(this.btnItaliqueCommentaire_Click);
            // 
            // btnGrasCommentaire
            // 
            this.btnGrasCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrasCommentaire.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrasCommentaire.Location = new System.Drawing.Point(16, 163);
            this.btnGrasCommentaire.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrasCommentaire.Name = "btnGrasCommentaire";
            this.btnGrasCommentaire.Size = new System.Drawing.Size(23, 21);
            this.btnGrasCommentaire.TabIndex = 65;
            this.btnGrasCommentaire.Text = "B";
            this.btnGrasCommentaire.UseVisualStyleBackColor = true;
            this.btnGrasCommentaire.Click += new System.EventHandler(this.btnGrasCommentaire_Click);
            // 
            // rtbCommentaire
            // 
            this.rtbCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCommentaire.Location = new System.Drawing.Point(15, 188);
            this.rtbCommentaire.Name = "rtbCommentaire";
            this.rtbCommentaire.Size = new System.Drawing.Size(350, 166);
            this.rtbCommentaire.TabIndex = 68;
            this.rtbCommentaire.Text = "";
            // 
            // rtbDescriptionCourte
            // 
            this.rtbDescriptionCourte.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rtbDescriptionCourte.Location = new System.Drawing.Point(372, 25);
            this.rtbDescriptionCourte.Name = "rtbDescriptionCourte";
            this.rtbDescriptionCourte.Size = new System.Drawing.Size(419, 107);
            this.rtbDescriptionCourte.TabIndex = 70;
            this.rtbDescriptionCourte.Text = "";
            // 
            // numPoliceDescriptionLongue
            // 
            this.numPoliceDescriptionLongue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numPoliceDescriptionLongue.Location = new System.Drawing.Point(453, 164);
            this.numPoliceDescriptionLongue.Name = "numPoliceDescriptionLongue";
            this.numPoliceDescriptionLongue.Size = new System.Drawing.Size(34, 20);
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
            this.btnEnumDescriptionLongue.Location = new System.Drawing.Point(492, 163);
            this.btnEnumDescriptionLongue.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnumDescriptionLongue.Name = "btnEnumDescriptionLongue";
            this.btnEnumDescriptionLongue.Size = new System.Drawing.Size(42, 21);
            this.btnEnumDescriptionLongue.TabIndex = 80;
            this.btnEnumDescriptionLongue.Text = "Enum";
            this.btnEnumDescriptionLongue.UseVisualStyleBackColor = true;
            this.btnEnumDescriptionLongue.Click += new System.EventHandler(this.btnEnumDescriptionLongue_Click);
            // 
            // btnSouslignerDescriptionLongue
            // 
            this.btnSouslignerDescriptionLongue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSouslignerDescriptionLongue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSouslignerDescriptionLongue.Location = new System.Drawing.Point(425, 163);
            this.btnSouslignerDescriptionLongue.Margin = new System.Windows.Forms.Padding(2);
            this.btnSouslignerDescriptionLongue.Name = "btnSouslignerDescriptionLongue";
            this.btnSouslignerDescriptionLongue.Size = new System.Drawing.Size(23, 21);
            this.btnSouslignerDescriptionLongue.TabIndex = 77;
            this.btnSouslignerDescriptionLongue.Text = "I";
            this.btnSouslignerDescriptionLongue.UseVisualStyleBackColor = true;
            this.btnSouslignerDescriptionLongue.Click += new System.EventHandler(this.btnSouslignerDescriptionLongue_Click);
            // 
            // btnItaliqueDescriptionLongue
            // 
            this.btnItaliqueDescriptionLongue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItaliqueDescriptionLongue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItaliqueDescriptionLongue.Location = new System.Drawing.Point(398, 163);
            this.btnItaliqueDescriptionLongue.Margin = new System.Windows.Forms.Padding(2);
            this.btnItaliqueDescriptionLongue.Name = "btnItaliqueDescriptionLongue";
            this.btnItaliqueDescriptionLongue.Size = new System.Drawing.Size(23, 21);
            this.btnItaliqueDescriptionLongue.TabIndex = 78;
            this.btnItaliqueDescriptionLongue.Text = "I";
            this.btnItaliqueDescriptionLongue.UseVisualStyleBackColor = true;
            this.btnItaliqueDescriptionLongue.Click += new System.EventHandler(this.btnItaliqueDescriptionLongue_Click);
            // 
            // btnGrasDescriptionLongue
            // 
            this.btnGrasDescriptionLongue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrasDescriptionLongue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrasDescriptionLongue.Location = new System.Drawing.Point(375, 163);
            this.btnGrasDescriptionLongue.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrasDescriptionLongue.Name = "btnGrasDescriptionLongue";
            this.btnGrasDescriptionLongue.Size = new System.Drawing.Size(23, 21);
            this.btnGrasDescriptionLongue.TabIndex = 79;
            this.btnGrasDescriptionLongue.Text = "B";
            this.btnGrasDescriptionLongue.UseVisualStyleBackColor = true;
            this.btnGrasDescriptionLongue.Click += new System.EventHandler(this.btnGrasDescriptionLongue_Click);
            // 
            // rtbDescriptionLongue
            // 
            this.rtbDescriptionLongue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rtbDescriptionLongue.Location = new System.Drawing.Point(376, 188);
            this.rtbDescriptionLongue.Name = "rtbDescriptionLongue";
            this.rtbDescriptionLongue.Size = new System.Drawing.Size(417, 166);
            this.rtbDescriptionLongue.TabIndex = 76;
            this.rtbDescriptionLongue.Text = "";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Description courte:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(59, 33);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 24);
            this.label15.TabIndex = 82;
            this.label15.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(59, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 24);
            this.label7.TabIndex = 83;
            this.label7.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(11, 374);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 13);
            this.label18.TabIndex = 84;
            this.label18.Text = "* Champs obligatoires";
            // 
            // DetailExigence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(801, 398);
            this.ControlBox = false;
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label15);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label18;
    }
}