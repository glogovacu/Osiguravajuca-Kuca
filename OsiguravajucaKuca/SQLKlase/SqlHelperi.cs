using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsiguravajucaKuca.SQLKlase
{
    public class SqlHelperi
    {
        public static int GetNewestKorisnikId()
        {
            int newestId = 0;

            using (SqlConnection connection = new SqlConnection(SqlConnectionString.ConnectionString))
            {
                connection.Open();

                string query = "SELECT MAX(ID_KORISNIKA) FROM KORISNIK";

                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    newestId = Convert.ToInt32(result);
                }
            }

            return newestId;
        }
        public static int GetLastUgovorId()
        {
            int lastUgovorId = 0;

            using (SqlConnection connection = new SqlConnection(SqlConnectionString.ConnectionString))
            {
                connection.Open();

                string query = "SELECT MAX(ID_UGOVORA) FROM Ugovor";
                SqlCommand command = new SqlCommand(query, connection);

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    lastUgovorId = Convert.ToInt32(result);
                }
            }

            return lastUgovorId;
        }
        public static bool IsNacinZakazivanjaNotNull(int korisnikId)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString.ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM KORISNIK WHERE ID_KORISNIKA = @KorisnikId AND NACINZAKAZIVANJA_KORISNIKA IS NOT NULL";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KorisnikId", korisnikId);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }
        public static void FillPoliseComboBox(ComboBox comboBox)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString.ConnectionString))
            {
                connection.Open();

                string query = "SELECT IME_POLISE FROM POLISE";

                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string imePolise = reader.GetString(0);
                        comboBox.Items.Add(imePolise);
                    }
                }
            }
        }
        
    }
}
