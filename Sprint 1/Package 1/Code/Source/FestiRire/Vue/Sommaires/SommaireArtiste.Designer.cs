﻿namespace FestiRire
{
    partial class SommaireArtiste
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
            this.dgvArtiste = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltres = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiste)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArtiste
            // 
            this.dgvArtiste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArtiste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtiste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Categorie});
            this.dgvArtiste.Location = new System.Drawing.Point(6, 45);
            this.dgvArtiste.Name = "dgvArtiste";
            this.dgvArtiste.Size = new System.Drawing.Size(1758, 328);
            this.dgvArtiste.TabIndex = 0;
            this.dgvArtiste.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvArtiste_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nom";
            this.Column1.HeaderText = "Nom";
            this.Column1.Name = "Column1";
            // 
            // Categorie
            // 
            this.Categorie.DataPropertyName = "categories";
            this.Categorie.HeaderText = "Categorie";
            this.Categorie.Name = "Categorie";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnFiltres);
            this.groupBox1.Controls.Add(this.dgvArtiste);
            this.groupBox1.Controls.Add(this.btnRechercher);
            this.groupBox1.Controls.Add(this.txtRecherche);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1770, 379);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artistes";
            // 
            // btnFiltres
            // 
            this.btnFiltres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltres.Location = new System.Drawing.Point(1630, 17);
            this.btnFiltres.Name = "btnFiltres";
            this.btnFiltres.Size = new System.Drawing.Size(134, 23);
            this.btnFiltres.TabIndex = 25;
            this.btnFiltres.Text = "Filtres";
            this.btnFiltres.UseVisualStyleBackColor = true;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRechercher.Location = new System.Drawing.Point(1549, 17);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 24;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // txtRecherche
            // 
            this.txtRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecherche.Location = new System.Drawing.Point(6, 20);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(1537, 20);
            this.txtRecherche.TabIndex = 23;
            this.txtRecherche.Text = "Recherche rapide";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.Location = new System.Drawing.Point(1685, 396);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(94, 31);
            this.btnAjouter.TabIndex = 22;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetail.Location = new System.Drawing.Point(1587, 396);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(94, 31);
            this.btnDetail.TabIndex = 21;
            this.btnDetail.Text = "Détail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFermer.Location = new System.Drawing.Point(11, 396);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(94, 31);
            this.btnFermer.TabIndex = 22;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // SommaireArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFermer;
            this.ClientSize = new System.Drawing.Size(1335, 438);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDetail);
            this.Name = "SommaireArtiste";
            this.Text = "Sommaire des artistes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiste)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtiste;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnFiltres;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorie;
    }
}