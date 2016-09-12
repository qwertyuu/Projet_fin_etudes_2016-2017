using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Sommaires
{
    class SommaireStatut : SommaireBase
    {
        public SommaireStatut() : base()
        {
            Controleur.Sommaires.SommaireAgence conSommaireAgence;

            InitializeComponent();
            conSommaireAgence = new Controleur.Sommaires.SommaireAgence();
            dgvAgence.AutoGenerateColumns = false;
            dgvAgence.RowHeadersVisible = false;
            dgvAgence.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvAgence.AllowUserToResizeRows = false;
            dgvAgence.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgence.MultiSelect = false;
            var donnees = (from item in conSommaireAgence.Tout()
                          select new { noAgence = item.noAgence, nom = item.nom, ville = item.ville, tel = conSommaireAgence.FormatTelephone(item.telBureau ?? item.telCellulaire) }).ToList();
            dgvAgence.DataSource = donnees;
        }

        public List<Modele.tblStatut> Tout()
        {
            return provider.ToutStatus();
        }
    }
}
