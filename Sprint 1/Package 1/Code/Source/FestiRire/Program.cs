using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FestiRire
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var context = new Modele.PE2_OfficielEntities())
            {
                var m = (from r in context.tblAdresse
                         where r.adresse != null
                         where r.dateSupprime == null
                         orderby r.noAdresse descending
                        select r
                        );
            }
            Application.Run(new SommaireCategoriesArtiste());
        }
    }
}
