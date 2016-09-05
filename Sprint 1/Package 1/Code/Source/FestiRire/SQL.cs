using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire
{
    static class SQL
    {
        static string connString = "";
        public static DataTable Select(string requete, Dictionary<string, Object> valeurs)
        {
            DataTable resultats = new DataTable();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand commande = new SqlCommand(requete, connection))
                {
                    foreach (KeyValuePair<string, Object> pair in valeurs)
                    {
                        commande.Parameters.AddWithValue(pair.Key, pair.Value);
                    }
                    using (SqlDataAdapter adapteurDonnees = new SqlDataAdapter(commande))
                    {
                        adapteurDonnees.Fill(resultats);
                    }
                }
            }
               
            return resultats;
        }
    }
}
