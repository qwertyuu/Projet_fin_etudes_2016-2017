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
    class Validation : Details.DetailBaseSimple
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
            if (SanitariserTexte(nom) == null || SanitariserTexte(no) == null || SanitariserCourriel(courr) == null || SanitariserTexte(addr) == null || SanitariserTexte(ville) == null || SanitariserTexte(prov) == null || SanitariserTexte(pays) == null || SanitariserTexte(code) == null)
            {
                messVide = "Vous devez remplir tous les champs obligatoires";
            }

        }

        public void verifierTel(string _tel, string _cel, string _poste)
        {
            messTel = "";
            //sanitarisation
            string tel = SanitariserTelephone(_tel);
            string cel = SanitariserTelephone(_cel);
            string poste = SanitariserTexte(_poste);

            if (tel == null && cel == null)
            {
                messTel = "Vous devez préciser au moins un numéro de téléphone";
            }
            else
            {
                if (cel != null)
                {
                    if (!Regex.IsMatch(cel, @"^\d+$") || cel.Length != 10)
                    {
                        messTel = "Le numéro de téléphone entré n'est pas valide";
                    }
                }
                else
                {
                    if (!Regex.IsMatch(tel, @"^\d+$") || tel.Length != 10)
                    {
                        messTel = "Le numéro de téléphone entré n'est pas valide";
                    }
                    else
                    {
                        if (cel != null && poste == null)
                        {
                            messTel = "Vous devez préciser le numéro de poste";
                        }
                        else
                        {
                            if (!Regex.IsMatch(tel, @"^\d+$"))
                                messTel = "Le poste entré n'est pas valide";


                        }
                    }

                }

            }


        }
        //Vérifier émail
        public bool IsValidEmail(string _email)
        {
            bool valide = true;
            //sanitarisation
            string email = SanitariserCourriel(_email);
            if (String.IsNullOrEmpty(email))
                valide = false;
            else
            {
                valide = Regex.IsMatch(email, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(500));
            }
            return valide;
        }

        //Verifier code postal
        public bool IsValidCodePost(string _code)
        {
            bool valide = false;
            //sanitarisation
            string code = SanitariserTexte(_code);
            if (String.IsNullOrEmpty(code))
                valide = false;
            else
                valide = Regex.IsMatch(code.ToUpper(), "^[a-zA-Z]{1}[0-9]{1}[a-zA-Z]{1}(\\-| |){1}[0-9]{1}[a-zA-Z]{1}[0-9]{1}$", RegexOptions.IgnoreCase);
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
        public string VerifierNomCat(string _nom)
        {
            string Vide = "";
            //sanitarisation
            string nom = SanitariserTexte(_nom);
            if (string.IsNullOrEmpty(nom))
                Vide = "Veuillez entrer le nom de la catégorie d'artiste.";
            return Vide;
        }

        public bool VerifierNoAgence(string _no)
        {
            //sanitarisation
            string no = SanitariserTexte(_no);
            //déterminer si le numéro d'agence finit par 90
            if (no.Length >= 2 && no.EndsWith("90"))
                return true;
            else
                return false;


        }

        //Validation de l'agagement.
        public bool ValiderChampDate(DateTimePicker date)
        {
            if (date.Value.Date < DateTime.Now.Date)
            {
                messVide = "La date doit être dans le futur";
                return false;
            }
            else
                return true;


        }


        public bool ValiderChampRespo(string _nom, string _prenom, string _courriel)
        {
            string nom = SanitariserTexte(_nom);
            string prenom = SanitariserTexte(_prenom);
            string courriel = SanitariserCourriel(_courriel);
            if (nom == null || prenom == null || courriel == null)
            {
                messVide = "Veuillez entrer les champs obligatoires";
                return false;
            }
            else
                return true;
        }

        public bool IdemIsChecked(bool idem, string signataire)
        {
            if (idem == false)
            {
                if (SanitariserTexte(signataire) == null)
                {
                    messVide = "Veuillez entrer le nom du signataire ";
                    return false;
                }

            }
            return true;
        }

    }
}