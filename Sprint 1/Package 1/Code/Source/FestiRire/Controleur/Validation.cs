using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace FestiRire.Controleur
{
    class Validation
    {
        private string messVide;
        private string messTel;
        public string MessVide
        {
            get { return messVide; }
        }
        public string MessTel
        {
            get { return messTel; }
        }

        public void verifierChampVide(string nom, string no, string courr, string addr, string ville, string prov, string pays, string code)
        {
            messVide = "";
            if (nom == "" || no == "" || courr == "" || addr == "" || ville == "" || prov == "" || pays == "" || code == "")
            {
                messVide = "Vos devez remplir tous les champs obbigatoire";
            }
             
        }

        public void verifierTel(string tel, string cel, string poste)
        {
            messTel = "";
            if(tel==""&& cel=="")
            {
                messTel = "Vous devez préciser au moins un numéro de téléphone.";
            }
            else
            {
                if(cel!="")
                {
                    if (!Regex.IsMatch(cel, @"^\d+$") || cel.Length != 10)
                    {
                        messTel = "Le numéro de téléphone entré n'est pas valide.";
                    }
                }
                else
                {
                    if (!Regex.IsMatch(tel, @"^\d+$") || tel.Length != 10)
                    {
                        messTel = "Le numéro de téléphone entré n'est pas valide.";
                    }
                    else
                    {
                           if (cel != "" && poste == "")
                            {
                                messTel = "Vous devez préciser le numéro de poste.";
                            }
                           else
                        {
                            if(!Regex.IsMatch(tel, @"^\d+$"))
                             messTel = "Le poste entré n'est pas valide.";


                        }
                    }

                }
            
            }


        } 
        //Vérifier émail
        public bool IsValidEmail(string email)
        {
            bool valide = true;
            if (String.IsNullOrEmpty(email))
                valide= false;
            else
            {
                valide=Regex.IsMatch(email.Trim(), @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",RegexOptions.IgnoreCase,TimeSpan.FromMilliseconds(250));
            }
            return valide;
        }  
        
        //Verifier code postal
        public bool IsValidCodePost(string code)
        {
            bool valide = false;
            if (String.IsNullOrEmpty(code))
                valide = false;
            else
                valide = Regex.IsMatch(code.Trim().ToUpper(), "^[a-zA-Z]{1}[0-9]{1}[a-zA-Z]{1}(\\-| |){1}[0-9]{1}[a-zA-Z]{1}[0-9]{1}$", RegexOptions.IgnoreCase);
            return valide;
        }

        //Hash le mot de passe
        public string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }

        //Validation sur la catégorie d'artiste.
        public string VerifierNomCat(string nom)
        {
           string Vide = "";
            if (string.IsNullOrEmpty(nom))
                Vide= "Veuillez entrer le nom de la catégorie d'artiste.";
            return Vide;
        }

        public bool VerifierNoAgence(string no)
        {
            if (no[no.Length - 1] == '0' && no[no.Length - 2] == '9')
                return true;
            else
            return false;
                    

        }

        //Validation de l'agagement.
        public bool ValiderChampDate(DateTimePicker date)
        {
            if (date.Value < DateTime.Now)
            {
                messVide = "La date doit être dans le futur";
                return false;
            }
            else
                return true;
            

        }

        
        public bool ValiderChampRespo(string nom, string prenom, string courriel)
        {
            if (nom == "" || prenom == "" || courriel == "")
            {
                messVide = "Veuillez entrez les champs obliatoires";
                return false;
            }
            else
                return true;
        }

    }
}
