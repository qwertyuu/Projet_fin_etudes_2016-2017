namespace FestiRire.Vue
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.label10 = new System.Windows.Forms.Label();
            this.timerHover = new System.Windows.Forms.Timer(this.components);
            this.btnContrat = new System.Windows.Forms.Button();
            this.btnAgence = new System.Windows.Forms.Button();
            this.btnArtiste = new System.Windows.Forms.Button();
            this.btnCatArt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(266, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(358, 35);
            this.label10.TabIndex = 72;
            this.label10.Text = "Gestion du festival Festi Rire";
            // 
            // btnContrat
            // 
            this.btnContrat.BackColor = System.Drawing.Color.Transparent;
            this.btnContrat.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContrat.Location = new System.Drawing.Point(178, 41);
            this.btnContrat.Margin = new System.Windows.Forms.Padding(2);
            this.btnContrat.Name = "btnContrat";
            this.btnContrat.Size = new System.Drawing.Size(196, 43);
            this.btnContrat.TabIndex = 73;
            this.btnContrat.Text = "Contrat";
            this.btnContrat.UseVisualStyleBackColor = false;
            this.btnContrat.Click += new System.EventHandler(this.btnContrat_Click);
            // 
            // btnAgence
            // 
            this.btnAgence.BackColor = System.Drawing.Color.Transparent;
            this.btnAgence.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgence.Location = new System.Drawing.Point(378, 41);
            this.btnAgence.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgence.Name = "btnAgence";
            this.btnAgence.Size = new System.Drawing.Size(215, 43);
            this.btnAgence.TabIndex = 74;
            this.btnAgence.Text = "Agence";
            this.btnAgence.UseVisualStyleBackColor = false;
            this.btnAgence.Click += new System.EventHandler(this.btnAgence_Click);
            // 
            // btnArtiste
            // 
            this.btnArtiste.BackColor = System.Drawing.Color.Transparent;
            this.btnArtiste.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtiste.Location = new System.Drawing.Point(378, 93);
            this.btnArtiste.Margin = new System.Windows.Forms.Padding(2);
            this.btnArtiste.Name = "btnArtiste";
            this.btnArtiste.Size = new System.Drawing.Size(215, 43);
            this.btnArtiste.TabIndex = 77;
            this.btnArtiste.Text = "Artiste";
            this.btnArtiste.UseVisualStyleBackColor = false;
            this.btnArtiste.Click += new System.EventHandler(this.btnArtiste_Click);
            // 
            // btnCatArt
            // 
            this.btnCatArt.BackColor = System.Drawing.Color.Transparent;
            this.btnCatArt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatArt.Location = new System.Drawing.Point(179, 93);
            this.btnCatArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnCatArt.Name = "btnCatArt";
            this.btnCatArt.Size = new System.Drawing.Size(195, 43);
            this.btnCatArt.TabIndex = 79;
            this.btnCatArt.Text = "Catégorie d\'artistes";
            this.btnCatArt.UseVisualStyleBackColor = false;
            this.btnCatArt.Click += new System.EventHandler(this.btnCatArt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCatArt);
            this.groupBox1.Controls.Add(this.btnArtiste);
            this.groupBox1.Controls.Add(this.btnAgence);
            this.groupBox1.Controls.Add(this.btnContrat);
            this.groupBox1.Location = new System.Drawing.Point(45, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(775, 220);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contrat";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(887, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "menu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timerHover;
        private System.Windows.Forms.Button btnContrat;
        private System.Windows.Forms.Button btnAgence;
        private System.Windows.Forms.Button btnArtiste;
        private System.Windows.Forms.Button btnCatArt;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}