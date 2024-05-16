using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsiguravajucaKuca.SQLKlase
{
    public class SqlIzlistavanje
    {
        public SqlIzlistavanje()
        {

        }

        public DataTable GetImePoliseForKorisnik(int idKorisnik)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(SqlConnectionString.ConnectionString))
            {
                connection.Open();

                string query = "SELECT P.IME_POLISE FROM PLACANJE PL " +
                               "JOIN POLISE P ON PL.ID_POLISE = P.ID_POLISE " +
                               "WHERE PL.ID_KORISNIKA = @IdKorisnik";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdKorisnik", idKorisnik);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        public DataTable GetKorisnikeSaNacinomZakazivanje()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(SqlConnectionString.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM KorisnikeSaNacinomZakazivanjeView";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                dataTable.Load(reader);
            }

            return dataTable;
        }
        public DataTable GetTable(string imeTabele)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(SqlConnectionString.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM " + imeTabele;

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                dataTable.Load(reader);
            }
            return dataTable;
        }
    }
}
