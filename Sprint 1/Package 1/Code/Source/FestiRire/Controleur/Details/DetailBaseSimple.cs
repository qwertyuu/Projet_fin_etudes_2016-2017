using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FestiRire.Controleur.Details
{
    abstract class DetailBaseSimple
    {
        protected DBProvider provider;
        public DetailBaseSimple()
        {
            provider = new DBProvider();
        }

        protected string SanitariserTexte(string s)
        {
            string final = s.Trim();
            return final == "" ? null : final;
        }

        public string SanitariserTelephone(string tel)
        {
            StringBuilder noTelFinal = new StringBuilder();
            char[] caracteresAccepte = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            foreach (var c in tel)
            {
                if (caracteresAccepte.Contains(c))
                {
                    noTelFinal.Append(c);
                }
            }
            return noTelFinal.ToString();
        }

        public string FormatTelephone(string tel)
        {
            StringBuilder sB = new StringBuilder();
            sB.Append("(");
            sB.Append(tel.Substring(0, 3));
            sB.Append(") ");
            sB.Append(tel.Substring(3, 3));
            sB.Append("-");
            sB.Append(tel.Substring(6));
            return sB.ToString();
        }

        protected string SanitariserCourriel(string courr)
        {
            return SanitariserTexte(courr);
        }

        public void Save()
        {
            provider.Save();
        }

        //Mettre le text sélectionner en gras.
        public void TextGras(System.Windows.Forms.RichTextBox text)
        {
            if (text.SelectionFont != null)
            {
                Font currentFont = text.SelectionFont;
                FontStyle newStyle;
                FontStyle styleItalic = FontStyle.Regular ;
                FontStyle styleUderline = FontStyle.Regular; 
                if (text.SelectionFont.Bold == true)
                {
                    newStyle = FontStyle.Regular;
                }
                else
                    newStyle = FontStyle.Bold;
                //On verifie s'il ya déja des styles appliqués
                if (text.SelectionFont.Italic)
                    styleItalic = FontStyle.Italic;

                if (text.SelectionFont.Underline)
                    styleUderline = FontStyle.Underline;
                text.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle| styleItalic| styleUderline);

            }
        }

        //Mettre le texte en italique
        public void TextItalic(System.Windows.Forms.RichTextBox text)
        {
            if (text.SelectionFont != null)
            {
                Font currentFont = text.SelectionFont;
                FontStyle newStyle;
                FontStyle styleGras = FontStyle.Regular;
                FontStyle styleUderline = FontStyle.Regular;
                if (text.SelectionFont.Italic == true)
                {
                    newStyle = FontStyle.Regular;
                }
                else
                    newStyle = FontStyle.Italic;
                //On verifie s'il ya déja des styles appliqués
                if (text.SelectionFont.Bold)
                    styleGras = FontStyle.Bold;
                if (text.SelectionFont.Underline)
                styleUderline = FontStyle.Underline;
                text.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle | styleGras | styleUderline);

            }
        }
        //Mettre le texte souligné
        public void TextUderline(System.Windows.Forms.RichTextBox text)
        {
            if (text.SelectionFont != null)
            {
                Font currentFont = text.SelectionFont;
                FontStyle newStyle;
                FontStyle styleGras = FontStyle.Regular;
                FontStyle styleItalic = FontStyle.Regular;
                if (text.SelectionFont.Underline == true)
                {
                    newStyle = FontStyle.Regular;
                }
                else
                    newStyle = FontStyle.Underline;
                //On verifie s'il ya déja des styles appliqués
                if (text.SelectionFont.Bold)
                    styleGras = FontStyle.Bold;
                if (text.SelectionFont.Italic)
                        styleItalic = FontStyle.Italic;
                text.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle | styleGras | styleItalic);

            }
        }

        //Change size text
        public void SizeText(System.Windows.Forms.RichTextBox text,decimal taille)
        {
            if(text.SelectionFont != null)
            {
                Font currentFont = text.SelectionFont;
                FontStyle styleGras = FontStyle.Regular;
                FontStyle styleItalic = FontStyle.Regular;
                FontStyle stylUderline = FontStyle.Regular;
                //On verifie qu'il ya pas d'autre style appliqué.

                if (text.SelectionFont.Bold)
                    styleGras = FontStyle.Bold;
                if (text.SelectionFont.Italic)
                    styleItalic = FontStyle.Italic;
                if (text.SelectionFont.Underline)
                    styleItalic = FontStyle.Underline;
                if (text.SelectionFont != null)
                {
                    text.SelectionFont = new Font(currentFont.FontFamily, (float)taille, FontStyle.Regular|styleGras|styleItalic|stylUderline);
                }
            }
        }

        //put enum.

        public void EnumText(System.Windows.Forms.RichTextBox text)
        {
            text.SelectionBullet = !text.SelectionBullet;
        }
    }
}
