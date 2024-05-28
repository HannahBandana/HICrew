using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace HICrew.Services
{
    public class DatabaseService
    {
        private string connectionString = "Server=tcp:hicrewserver.database.windows.net,1433;Initial Catalog=HICrewDB;Persist Security Info=False;User ID=HICrewAdmin;Password=Klokka22;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public async Task<List<string>> GetSeafarerNamesAsync()
        {
            var seafarers = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand("SELECT p.firstName + ' ' + p.lastName FROM Person p INNER JOIN Seafarer s ON p.idPerson = s.personId", connection);
                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        seafarers.Add(reader.GetString(0)); 
                    }
                }
            }

            return seafarers;
        }
    }
}
