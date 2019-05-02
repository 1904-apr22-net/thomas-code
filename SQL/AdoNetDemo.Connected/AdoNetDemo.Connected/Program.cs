using System;
using System.Data.SqlClient;

namespace AdoNetDemo.Connected
{
    class Program
    {
        static void Main(string[] args)
        {
            // first, connect/authenticate to the database
            // connection strings are considered secret credentials, so we make a .gitignore for it

            var ConnectionString = SecretConfiguration.ConnectionString;

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                Console.WriteLine("Enter a condition: ");
                var condition = Console.ReadLine();

                if (condition != "")
                {
                    condition = " where " + condition;
                }

                var commString = $"SELECt * FROM Movie.Movie {condition};";

                using (var command = new SqlCommand(commString, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var id = (int)reader["MovieId"];
                            var title = (string)reader["Title"];

                            Console.WriteLine($"{id}: {title}");
                        }
                    }
                }
                connection.Close();
            }
        }
    }
}
