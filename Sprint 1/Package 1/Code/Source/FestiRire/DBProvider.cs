using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using FestiRire.Modele;

namespace FestiRire
{
    class DBProvider
    {
        private static Modele.PE2_OfficielEntities BD;
        public DBProvider()
        {
            if(BD == null)
            {
                BD = new Modele.PE2_OfficielEntities();
            }
        }

        public tblAgence SelectAgence(string _noAgence)
        {
            return BD.tblAgence.SingleOrDefault(a => a.noAgence == _noAgence);
        }


        //-----Requête sur la table Agence----
        public void InsertAgence(Modele.tblAgence agence)
        {
            BD.tblAgence.Add(agence);
            BD.SaveChanges();
        }

        //-----Requête sur la table adresse----
        public void InsertAdresse(Modele.tblAdresse adresse)
        {
            BD.tblAdresse.Add(adresse);
            BD.SaveChanges();
        }

        public void Save()
        {
            BD.SaveChanges();
        }

        public List<Modele.vueSomAgence> ToutVueAgence()
        {
            return (from item in BD.vueSomAgence
                   select item).ToList();
        }

        public List<Modele.vueSomArtiste> ToutVueArtiste()
        {
            return (from item in BD.vueSomArtiste
                   select item).ToList();
        }

        public List<Modele.vueSomCatArtiste> ToutVueCategorieArtiste()
        {
            return (from item in BD.vueSomCatArtiste
                   select item).ToList();
        }

        public List<Modele.vueSomContrat> ToutVueContrats()
        {
            return (from item in BD.vueSomContrat
                   select item).ToList();
        }
    }
}
