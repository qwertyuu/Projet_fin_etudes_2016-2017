using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestiRire
{
    public partial class DetailContrat : Form
    {
        Controleur.Details.DetailContrat contrat;
        public DetailContrat()
        {
            InitializeComponent();
            contrat = new Controleur.Details.DetailContrat();
            
        }

        public DetailContrat(string noContrat)
        {
            InitializeComponent();

        }

        //Gestion des styles reliés aux commentaires et description
        private void btnGrasCommentaire_Click(object sender, EventArgs e)
        {
            contrat.TextGras(rtbCommentaire);
        }

        private void btnItaliqueCommentaire_Click(object sender, EventArgs e)
        {
            contrat.TextItalic(rtbCommentaire);
        }

        private void btnSouslignerCommentaire_Click(object sender, EventArgs e)
        {
            contrat.TextUderline(rtbCommentaire);
        }

        private void numPoliceCommentaire_ValueChanged(object sender, EventArgs e)
        {
            contrat.SizeText(rtbCommentaire,numPoliceCommentaire.Value);
        }

        private void btnEnumCommentaire_Click(object sender, EventArgs e)
        {
            contrat.EnumText(rtbCommentaire);
        }


        private void btnGrasDescription_Click(object sender, EventArgs e)
        {
            contrat.TextGras(rtbDescriptionContrat);
        }

        private void btnItaliqueDescription_Click(object sender, EventArgs e)
        {
            contrat.TextItalic(rtbDescriptionContrat);
        }

        private void btnSouslignerDescription_Click(object sender, EventArgs e)
        {
            contrat.TextUderline(rtbDescriptionContrat);
        }

        private void numPoliceDescription_ValueChanged(object sender, EventArgs e)
        {
            contrat.SizeText(rtbDescriptionContrat,numPoliceDescription.Value);
        }

        private void btnEnumDescription_Click(object sender, EventArgs e)
        {
            contrat.EnumText(rtbDescriptionContrat);
        }
    }
}
