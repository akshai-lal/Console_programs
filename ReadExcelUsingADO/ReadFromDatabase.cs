//using System;
//using System.Data.SqlClient;

//namespace DataValidation
//{
//    public class ReadFromDatabase
//    {
//        public static void Main()
//        {
//            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDatabase;Integrated Security=True;";

//            string query = "SELECT * FROM FoodProducts WHERE ProductID = @id";

//            Console.Write("Enter Product ID to view details: ");
//            int productId = Convert.ToInt32(Console.ReadLine());

//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                conn.Open();

//                using (SqlCommand cmd = new SqlCommand(query, conn))
//                {
//                    cmd.Parameters.AddWithValue("@id", productId);

//                    using (SqlDataReader reader = cmd.ExecuteReader())
//                    {
//                        if (reader.Read())
//                        {
//                            Console.WriteLine("\nProduct Details:\n");

//                            for (int i = 0; i < reader.FieldCount; i++)
//                            {
//                                string columnName = reader.GetName(i);
//                                object value = reader.GetValue(i);
//                                Console.WriteLine($"{columnName}: {value}");
//                            }
//                        }
//                        else
//                        {
//                            Console.WriteLine("No product found with that ID.");
//                        }
//                    }
//                }
//            }

//            Console.WriteLine("\nDone.");
//        }
//    }

//}

