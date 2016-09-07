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
            using (var context = new Modele.PE2_TestEntities())
            {
                var m = (from r in context.tblAdresse
                        select r).ToList();
                MessageBox.Show(m[0].adresse);
            }
            //Application.Run(new SommaireArtiste());
        }
    }
}
