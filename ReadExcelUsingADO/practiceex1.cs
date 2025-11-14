using System;
using System.Data.SqlClient;

public class Practiceex1

{
   public static void practiceex()
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDatabase;Integrated Security=True;";
        SqlConnection conn = new SqlConnection(connectionString);

        conn.Open();

        string query = "SELECT * FROM FoodProducts";
        SqlCommand cmd = new SqlCommand(query, conn);

        SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"{reader["ProductID"]} - {reader["ProductName"]} - {reader["Category"]} - {reader["Price"]}");
        }

        reader.Close();
        conn.Close();
    }
}
