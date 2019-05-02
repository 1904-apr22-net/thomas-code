using System;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetDemo.Disconnected
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = SecretConfiguration.ConnectionString;

            Console.WriteLine("Enter a condition: ");
            var condition = Console.ReadLine();

            if (condition != "")
            {
                condition = " WHERE " + condition;
            }

            var dataSet = new DataSet();

            var commString = $"SELECT * FROM Movie.Genre {condition};";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(commString, connection))
                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataSet);
                }
                connection.Close();
            }
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                DataColumn idColumn = dataSet.Tables[0].Columns["GenreId"];
                Console.WriteLine($"Genre #{row[idColumn]}: {row["Name"]}");
            }
        }
    }
}
