using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Details
{
    class DetailContrat : DetailBaseSimple
    {
        public Modele.tblContrat SelectContrat(string idContrat)
        {
            return provider.SelectContrat(idContrat);
        }

        public Modele.tblResponsable ResponsableAgence(string idContrat)
        {
            return provider.SelectResponsableAgence(idContrat);
        }

        public Modele.tblResponsable ResponsableDiffuseur(string idContrat)
        {
            return provider.SelectResponsableDiffuseur(idContrat);
        }

        public Modele.tblResponsable EnregistrerResponsable(string IdAcienContrat, string nomRespoAge, string prenomRespoAge, string courr, string cel, string tel, string poste, string signataireRespo, DateTime dateSignatire, bool idem, string noAge, int? noDiff)
        {
            if (IdAcienContrat != null)
            {
                Modele.tblResponsable ResponsableMAJ = provider.SelectResponsableAgence(IdAcienContrat);
                if (ResponsableMAJ != null)//On fait une MAJ
                {
                    ResponsableMAJ.nom = SanitariserTexte(nomRespoAge);
                    ResponsableMAJ.prenom = SanitariserTexte(prenomRespoAge);
                    ResponsableMAJ.courriel = SanitariserCourriel(courr);
                    ResponsableMAJ.telCellulaire = SanitariserTelephone(cel);
                    ResponsableMAJ.telBureau = SanitariserTelephone(tel);
                    ResponsableMAJ.extension = SanitariserTexte(poste);
                    ResponsableMAJ.dateSignature = dateSignatire;
                    ResponsableMAJ.noAgence = SanitariserTexte(noAge);
                    ResponsableMAJ.noDiffuseur = noDiff;
                    ResponsableMAJ.idem = idem;
                    provider.Save();
                    return ResponsableMAJ;
                }
                else //On enregistre un nouveau
                {
                    var RespoAge = new Modele.tblResponsable { nom = SanitariserTexte(nomRespoAge), prenom = SanitariserTexte(prenomRespoAge), courriel = SanitariserCourriel(courr), signataire = signataireRespo, dateSignature = dateSignatire, telBureau = SanitariserTelephone(tel), telCellulaire = SanitariserTelephone(cel), extension = poste, idem = idem, noAgence = noAge, noDiffuseur = noDiff };
                    provider.InsertResponsable(RespoAge);
                    return RespoAge;
                }
            }
            return null;
        }

        private int ReturnNoSatut(string nom)
        {
            return provider.SelectStatut(nom).noStatut;
        }
        public bool EnregistrerContrat(string IdAcienContrat, string IdNouveauContrat, string nomContrat, string lieu, string com, string desc, string nomStatut, string noAgence, Modele.tblResponsable respAgence, Modele.tblResponsable respDiff, List<Modele.tblArtiste> tblArtiste, out string noContratAjoute)
        {
            int noStatut = -1;
            if (nomStatut != "Supprimé")
            {
                noStatut = ReturnNoSatut(nomStatut);
            }

            Modele.tblContrat contratMAJ = provider.SelectContrat(IdAcienContrat);
            if (contratMAJ != null)
            {
                if (noStatut == -1)
                {
                    contratMAJ.dateSupprime = DateTime.Now;
                }
                else
                {
                    contratMAJ.noStatut = noStatut;
                }
                contratMAJ.nom = nomContrat;
                contratMAJ.lieu = lieu;
                contratMAJ.commentaire = com;
                contratMAJ.description = desc;
                contratMAJ.noAgence = noAgence;
                contratMAJ.tblArtiste = tblArtiste;
                foreach (var item in contratMAJ.tblResponsable)
                {
                    item.dateSupprime = DateTime.Now;
                }
                contratMAJ.tblResponsable.Clear();
                contratMAJ.tblResponsable.Add(respAgence);
                contratMAJ.tblResponsable.Add(respDiff);
                provider.Save();
                noContratAjoute = null;
                return false;
            }
            else
            {
                var contrat = new Modele.tblContrat { noContrat = IdNouveauContrat, lieu = lieu, nom = nomContrat, description = desc, commentaire = com, noStatut = noStatut, noAgence = noAgence, tblArtiste = tblArtiste };
                if (noStatut == -1)
                {
                    contrat.dateSupprime = DateTime.Now;
                }
                contrat.tblResponsable.Add(respAgence);
                contrat.tblResponsable.Add(respDiff);
                provider.InsertContrat(contrat);
                noContratAjoute = contrat.noContrat;
                return true;
            }
        }
    }
}