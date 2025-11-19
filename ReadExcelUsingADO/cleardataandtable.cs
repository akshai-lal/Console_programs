using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataValidation
{
    public class cleardataandtable
    {
        public static void clearAndDeleteTable()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDatabase;Integrated Security=True;";
            Console.WriteLine("Enter the options");
            Console.WriteLine("1. Delete the datas from the table");
            Console.WriteLine("2. Drop the table");
            Console.WriteLine("3. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                switch (choice)
                {
                    case 1:
                        clearTable(conn);
                        break;
                    case 2:
                        deleteTable(conn);
                        break;
                    case 3:
                        Console.WriteLine("Exiting the program");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }


                Console.WriteLine("\nOperation complete.");

                static void clearTable(SqlConnection conn)
                {
                    String query = "DELETE FROM Employee";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int rowsaffected = cmd.ExecuteNonQuery();
                        Console.WriteLine($"Table datas are cleared affected rows : {rowsaffected}");
                    }
                }

                static void deleteTable(SqlConnection conn)
                {
                    String query = "DROP TABLE Employee";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Table is deleted");
                    }
                }
            }
        }
    }

