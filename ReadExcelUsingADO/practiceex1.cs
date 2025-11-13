//using System;
//using System.Data.SqlClient;

//class Program
//{
//    static void Main()
//    {
//        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDatabase;Integrated Security=True;";
//        SqlConnection conn = new SqlConnection(connectionString);

//        conn.Open();

//        // 1️⃣ Prepare SQL command
//        string query = "SELECT * FROM FoodProducts";
//        SqlCommand cmd = new SqlCommand(query, conn);

//        // 2️⃣ Execute command and read data
//        SqlDataReader reader = cmd.ExecuteReader();

//        // 3️⃣ Loop through rows
//        while (reader.Read())
//        {
//            Console.WriteLine($"{reader["ProductID"]} - {reader["ProductName"]} - {reader["Category"]} - {reader["Price"]}");
//        }

//        reader.Close();
//        conn.Close();
//    }
//}
