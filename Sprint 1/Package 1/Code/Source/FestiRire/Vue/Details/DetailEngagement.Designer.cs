namespace FestiRire
{
    partial class DetailEngagement
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
            this.rtbDescriptionLongue = new System.Windows.Forms.RichTextBox();
            this.txtHeure = new System.Windows.Forms.MaskedTextBox();
            this.dateEngagement = new System.Windows.Forms.DateTimePicker();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimerEngagement = new System.Windows.Forms.Button();
            this.btnEnregistrerEngagement = new System.Windows.Forms.Button();
            this.txtNatureEngagement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbCommentaire = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrixBillet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCapacite = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numPoliceDescriptionLongue = new System.Windows.Forms.NumericUpDown();
            this.btnEnumDescriptionLongue = new System.Windows.Forms.Button();
            this.btnSouslignerDescriptionLongue = new System.Windows.Forms.Button();
            this.btnItaliqueDescriptionLongue = new System.Windows.Forms.Button();
            this.btnGrasDescriptionLongue = new System.Windows.Forms.Button();
            this.numPoliceCommentaire = new System.Windows.Forms.NumericUpDown();
            this.btnEnumCommentaire = new System.Windows.Forms.Button();
            this.btnSouslignerCommentaire = new System.Windows.Forms.Button();
            this.btnItaliqueCommentaire = new System.Windows.Forms.Button();
            this.btnGrasCommentaire = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbDescriptionCourte = new System.Windows.Forms.RichTextBox();
            this.btnGrasDescriptionCourte = new System.Windows.Forms.Button();
            this.btnItaliqueDescriptionCourte = new System.Windows.Forms.Button();
            this.btnSouslignerDescriptionCourte = new System.Windows.Forms.Button();
            this.btnEnumDescriptionCourte = new System.Windows.Forms.Button();
            this.numPoliceDescriptionCourte = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPoliceDescriptionLongue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoliceCommentaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoliceDescriptionCourte)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbDescriptionLongue
            // 
            this.rtbDescriptionLongue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rtbDescriptionLongue.Location = new System.Drawing.Point(755, 319);
            this.rtbDescriptionLongue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbDescriptionLongue.Name = "rtbDescriptionLongue";
            this.rtbDescriptionLongue.Size = new System.Drawing.Size(472, 336);
            this.rtbDescriptionLongue.TabIndex = 46;
            this.rtbDescriptionLongue.Text = "";
            // 
            // txtHeure
            // 
            this.txtHeure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeure.Location = new System.Drawing.Point(128, 98);
            this.txtHeure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHeure.Name = "txtHeure";
            this.txtHeure.Size = new System.Drawing.Size(595, 26);
            this.txtHeure.TabIndex = 40;
            // 
            // dateEngagement
            // 
            this.dateEngagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEngagement.Location = new System.Drawing.Point(128, 60);
            this.dateEngagement.Name = "dateEngagement";
            this.dateEngagement.Size = new System.Drawing.Size(351, 26);
            this.dateEngagement.TabIndex = 39;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(1110, 667);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(111, 45);
            this.btnAnnuler.TabIndex = 38;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSupprimerEngagement
            // 
            this.btnSupprimerEngagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerEngagement.Location = new System.Drawing.Point(840, 667);
            this.btnSupprimerEngagement.Name = "btnSupprimerEngagement";
            this.btnSupprimerEngagement.Size = new System.Drawing.Size(129, 45);
            this.btnSupprimerEngagement.TabIndex = 36;
            this.btnSupprimerEngagement.Text = "Supprimer";
            this.btnSupprimerEngagement.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrerEngagement
            // 
            this.btnEnregistrerEngagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrerEngagement.Location = new System.Drawing.Point(975, 667);
            this.btnEnregistrerEngagement.Name = "btnEnregistrerEngagement";
            this.btnEnregistrerEngagement.Size = new System.Drawing.Size(129, 45);
            this.btnEnregistrerEngagement.TabIndex = 37;
            this.btnEnregistrerEngagement.Text = "Enregistrer";
            this.btnEnregistrerEngagement.UseVisualStyleBackColor = true;
            this.btnEnregistrerEngagement.Click += new System.EventHandler(this.btnEnregistrerEngagement_Click);
            // 
            // txtNatureEngagement
            // 
            this.txtNatureEngagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNatureEngagement.Location = new System.Drawing.Point(128, 22);
            this.txtNatureEngagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNatureEngagement.Name = "txtNatureEngagement";
            this.txtNatureEngagement.Size = new System.Drawing.Size(595, 26);
            this.txtNatureEngagement.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(756, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Description longue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Heure:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nature:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Durée:";
            // 
            // rtbCommentaire
            // 
            this.rtbCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCommentaire.Location = new System.Drawing.Point(28, 275);
            this.rtbCommentaire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbCommentaire.Name = "rtbCommentaire";
            this.rtbCommentaire.Size = new System.Drawing.Size(694, 384);
            this.rtbCommentaire.TabIndex = 50;
            this.rtbCommentaire.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 211);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Commentaire:";
            // 
            // txtPrixBillet
            // 
            this.txtPrixBillet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPrixBillet.Location = new System.Drawing.Point(912, 18);
            this.txtPrixBillet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrixBillet.Name = "txtPrixBillet";
            this.txtPrixBillet.Size = new System.Drawing.Size(314, 26);
            this.txtPrixBillet.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(750, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Prix des billets:";
            // 
            // txtCapacite
            // 
            this.txtCapacite.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCapacite.Location = new System.Drawing.Point(912, 58);
            this.txtCapacite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCapacite.Name = "txtCapacite";
            this.txtCapacite.Size = new System.Drawing.Size(314, 26);
            this.txtCapacite.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(750, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 20);
            this.label11.TabIndex = 53;
            this.label11.Text = "Capacité de la salle:";
            // 
            // txtDuree
            // 
            this.txtDuree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuree.Location = new System.Drawing.Point(128, 138);
            this.txtDuree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(595, 26);
            this.txtDuree.TabIndex = 55;
            // 
            // txtLieu
            // 
            this.txtLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLieu.Location = new System.Drawing.Point(128, 175);
            this.txtLieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(595, 26);
            this.txtLieu.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 180);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 20);
            this.label12.TabIndex = 57;
            this.label12.Text = "Lieu:";
            // 
            // numPoliceDescriptionLongue
            // 
            this.numPoliceDescriptionLongue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numPoliceDescriptionLongue.Location = new System.Drawing.Point(877, 277);
            this.numPoliceDescriptionLongue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPoliceDescriptionLongue.Name = "numPoliceDescriptionLongue";
            this.numPoliceDescriptionLongue.Size = new System.Drawing.Size(51, 26);
            this.numPoliceDescriptionLongue.TabIndex = 64;
            this.numPoliceDescriptionLongue.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // btnEnumDescriptionLongue
            // 
            this.btnEnumDescriptionLongue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnumDescriptionLongue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnumDescriptionLongue.Location = new System.Drawing.Point(936, 275);
            this.btnEnumDescriptionLongue.Name = "btnEnumDescriptionLongue";
            this.btnEnumDescriptionLongue.Size = new System.Drawing.Size(63, 32);
            this.btnEnumDescriptionLongue.TabIndex = 63;
            this.btnEnumDescriptionLongue.Text = "Enum";
            this.btnEnumDescriptionLongue.UseVisualStyleBackColor = true;
            // 
            // btnSouslignerDescriptionLongue
            // 
            this.btnSouslignerDescriptionLongue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSouslignerDescriptionLongue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSouslignerDescriptionLongue.Location = new System.Drawing.Point(835, 275);
            this.btnSouslignerDescriptionLongue.Name = "btnSouslignerDescriptionLongue";
            this.btnSouslignerDescriptionLongue.Size = new System.Drawing.Size(34, 32);
            this.btnSouslignerDescriptionLongue.TabIndex = 60;
            this.btnSouslignerDescriptionLongue.Text = "I";
            this.btnSouslignerDescriptionLongue.UseVisualStyleBackColor = true;
            // 
            // btnItaliqueDescriptionLongue
            // 
            this.btnItaliqueDescriptionLongue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItaliqueDescriptionLongue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItaliqueDescriptionLongue.Location = new System.Drawing.Point(795, 275);
            this.btnItaliqueDescriptionLongue.Name = "btnItaliqueDescriptionLongue";
            this.btnItaliqueDescriptionLongue.Size = new System.Drawing.Size(34, 32);
            this.btnItaliqueDescriptionLongue.TabIndex = 61;
            this.btnItaliqueDescriptionLongue.Text = "I";
            this.btnItaliqueDescriptionLongue.UseVisualStyleBackColor = true;
            // 
            // btnGrasDescriptionLongue
            // 
            this.btnGrasDescriptionLongue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrasDescriptionLongue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrasDescriptionLongue.Location = new System.Drawing.Point(755, 275);
            this.btnGrasDescriptionLongue.Name = "btnGrasDescriptionLongue";
            this.btnGrasDescriptionLongue.Size = new System.Drawing.Size(34, 32);
            this.btnGrasDescriptionLongue.TabIndex = 62;
            this.btnGrasDescriptionLongue.Text = "B";
            this.btnGrasDescriptionLongue.UseVisualStyleBackColor = true;
            // 
            // numPoliceCommentaire
            // 
            this.numPoliceCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numPoliceCommentaire.Location = new System.Drawing.Point(158, 235);
            this.numPoliceCommentaire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPoliceCommentaire.Name = "numPoliceCommentaire";
            this.numPoliceCommentaire.Size = new System.Drawing.Size(52, 26);
            this.numPoliceCommentaire.TabIndex = 74;
            this.numPoliceCommentaire.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // btnEnumCommentaire
            // 
            this.btnEnumCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnumCommentaire.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnumCommentaire.Location = new System.Drawing.Point(217, 235);
            this.btnEnumCommentaire.Name = "btnEnumCommentaire";
            this.btnEnumCommentaire.Size = new System.Drawing.Size(71, 32);
            this.btnEnumCommentaire.TabIndex = 73;
            this.btnEnumCommentaire.Text = "Enum";
            this.btnEnumCommentaire.UseVisualStyleBackColor = true;
            // 
            // btnSouslignerCommentaire
            // 
            this.btnSouslignerCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSouslignerCommentaire.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSouslignerCommentaire.Location = new System.Drawing.Point(78, 235);
            this.btnSouslignerCommentaire.Name = "btnSouslignerCommentaire";
            this.btnSouslignerCommentaire.Size = new System.Drawing.Size(35, 32);
            this.btnSouslignerCommentaire.TabIndex = 70;
            this.btnSouslignerCommentaire.Text = "I";
            this.btnSouslignerCommentaire.UseVisualStyleBackColor = true;
            this.btnSouslignerCommentaire.Click += new System.EventHandler(this.btnSouslignerCommentaire_Click);
            // 
            // btnItaliqueCommentaire
            // 
            this.btnItaliqueCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItaliqueCommentaire.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItaliqueCommentaire.Location = new System.Drawing.Point(119, 235);
            this.btnItaliqueCommentaire.Name = "btnItaliqueCommentaire";
            this.btnItaliqueCommentaire.Size = new System.Drawing.Size(32, 32);
            this.btnItaliqueCommentaire.TabIndex = 71;
            this.btnItaliqueCommentaire.Text = "I";
            this.btnItaliqueCommentaire.UseVisualStyleBackColor = true;
            // 
            // btnGrasCommentaire
            // 
            this.btnGrasCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrasCommentaire.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrasCommentaire.Location = new System.Drawing.Point(36, 235);
            this.btnGrasCommentaire.Name = "btnGrasCommentaire";
            this.btnGrasCommentaire.Size = new System.Drawing.Size(36, 32);
            this.btnGrasCommentaire.TabIndex = 72;
            this.btnGrasCommentaire.Text = "B";
            this.btnGrasCommentaire.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(750, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Description courte:";
            // 
            // rtbDescriptionCourte
            // 
            this.rtbDescriptionCourte.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rtbDescriptionCourte.Location = new System.Drawing.Point(755, 164);
            this.rtbDescriptionCourte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbDescriptionCourte.Name = "rtbDescriptionCourte";
            this.rtbDescriptionCourte.Size = new System.Drawing.Size(472, 86);
            this.rtbDescriptionCourte.TabIndex = 45;
            this.rtbDescriptionCourte.Text = "";
            // 
            // btnGrasDescriptionCourte
            // 
            this.btnGrasDescriptionCourte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrasDescriptionCourte.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrasDescriptionCourte.Location = new System.Drawing.Point(755, 118);
            this.btnGrasDescriptionCourte.Name = "btnGrasDescriptionCourte";
            this.btnGrasDescriptionCourte.Size = new System.Drawing.Size(34, 32);
            this.btnGrasDescriptionCourte.TabIndex = 67;
            this.btnGrasDescriptionCourte.Text = "B";
            this.btnGrasDescriptionCourte.UseVisualStyleBackColor = true;
            // 
            // btnItaliqueDescriptionCourte
            // 
            this.btnItaliqueDescriptionCourte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItaliqueDescriptionCourte.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItaliqueDescriptionCourte.Location = new System.Drawing.Point(795, 118);
            this.btnItaliqueDescriptionCourte.Name = "btnItaliqueDescriptionCourte";
            this.btnItaliqueDescriptionCourte.Size = new System.Drawing.Size(34, 32);
            this.btnItaliqueDescriptionCourte.TabIndex = 66;
            this.btnItaliqueDescriptionCourte.Text = "I";
            this.btnItaliqueDescriptionCourte.UseVisualStyleBackColor = true;
            // 
            // btnSouslignerDescriptionCourte
            // 
            this.btnSouslignerDescriptionCourte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSouslignerDescriptionCourte.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSouslignerDescriptionCourte.Location = new System.Drawing.Point(835, 118);
            this.btnSouslignerDescriptionCourte.Name = "btnSouslignerDescriptionCourte";
            this.btnSouslignerDescriptionCourte.Size = new System.Drawing.Size(34, 32);
            this.btnSouslignerDescriptionCourte.TabIndex = 65;
            this.btnSouslignerDescriptionCourte.Text = "I";
            this.btnSouslignerDescriptionCourte.UseVisualStyleBackColor = true;
            // 
            // btnEnumDescriptionCourte
            // 
            this.btnEnumDescriptionCourte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnumDescriptionCourte.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnumDescriptionCourte.Location = new System.Drawing.Point(936, 118);
            this.btnEnumDescriptionCourte.Name = "btnEnumDescriptionCourte";
            this.btnEnumDescriptionCourte.Size = new System.Drawing.Size(63, 32);
            this.btnEnumDescriptionCourte.TabIndex = 68;
            this.btnEnumDescriptionCourte.Text = "Enum";
            this.btnEnumDescriptionCourte.UseVisualStyleBackColor = true;
            // 
            // numPoliceDescriptionCourte
            // 
            this.numPoliceDescriptionCourte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numPoliceDescriptionCourte.Location = new System.Drawing.Point(877, 120);
            this.numPoliceDescriptionCourte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPoliceDescriptionCourte.Name = "numPoliceDescriptionCourte";
            this.numPoliceDescriptionCourte.Size = new System.Drawing.Size(51, 26);
            this.numPoliceDescriptionCourte.TabIndex = 69;
            this.numPoliceDescriptionCourte.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // DetailEngagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(1237, 729);
            this.Controls.Add(this.numPoliceCommentaire);
            this.Controls.Add(this.btnEnumCommentaire);
            this.Controls.Add(this.btnSouslignerCommentaire);
            this.Controls.Add(this.btnItaliqueCommentaire);
            this.Controls.Add(this.btnGrasCommentaire);
            this.Controls.Add(this.numPoliceDescriptionCourte);
            this.Controls.Add(this.btnEnumDescriptionCourte);
            this.Controls.Add(this.btnSouslignerDescriptionCourte);
            this.Controls.Add(this.btnItaliqueDescriptionCourte);
            this.Controls.Add(this.btnGrasDescriptionCourte);
            this.Controls.Add(this.numPoliceDescriptionLongue);
            this.Controls.Add(this.btnEnumDescriptionLongue);
            this.Controls.Add(this.btnSouslignerDescriptionLongue);
            this.Controls.Add(this.btnItaliqueDescriptionLongue);
            this.Controls.Add(this.btnGrasDescriptionLongue);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.txtCapacite);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPrixBillet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rtbCommentaire);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbDescriptionLongue);
            this.Controls.Add(this.rtbDescriptionCourte);
            this.Controls.Add(this.txtHeure);
            this.Controls.Add(this.dateEngagement);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimerEngagement);
            this.Controls.Add(this.btnEnregistrerEngagement);
            this.Controls.Add(this.txtNatureEngagement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DetailEngagement";
            this.Text = "Détail de l\'engagement";
            ((System.ComponentModel.ISupportInitialize)(this.numPoliceDescriptionLongue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoliceCommentaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoliceDescriptionCourte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDescriptionLongue;
        private System.Windows.Forms.MaskedTextBox txtHeure;
        private System.Windows.Forms.DateTimePicker dateEngagement;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupprimerEngagement;
        private System.Windows.Forms.Button btnEnregistrerEngagement;
        private System.Windows.Forms.TextBox txtNatureEngagement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbCommentaire;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrixBillet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCapacite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numPoliceDescriptionLongue;
        private System.Windows.Forms.Button btnEnumDescriptionLongue;
        private System.Windows.Forms.Button btnSouslignerDescriptionLongue;
        private System.Windows.Forms.Button btnItaliqueDescriptionLongue;
        private System.Windows.Forms.Button btnGrasDescriptionLongue;
        private System.Windows.Forms.NumericUpDown numPoliceCommentaire;
        private System.Windows.Forms.Button btnEnumCommentaire;
        private System.Windows.Forms.Button btnSouslignerCommentaire;
        private System.Windows.Forms.Button btnItaliqueCommentaire;
        private System.Windows.Forms.Button btnGrasCommentaire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbDescriptionCourte;
        private System.Windows.Forms.Button btnGrasDescriptionCourte;
        private System.Windows.Forms.Button btnItaliqueDescriptionCourte;
        private System.Windows.Forms.Button btnSouslignerDescriptionCourte;
        private System.Windows.Forms.Button btnEnumDescriptionCourte;
        private System.Windows.Forms.NumericUpDown numPoliceDescriptionCourte;
    }
}