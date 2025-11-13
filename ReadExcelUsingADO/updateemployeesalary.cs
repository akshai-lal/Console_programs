//using System;
//using System.Data.SqlClient;

//namespace EmployeeSalaryUpdate
//{
//    class Program
//    {
//        static void Main()
//        {
//            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDatabase;Integrated Security=True;";

//            Console.Write("Enter Employee ID to update salary: ");
//            int empId = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter new salary: ");
//            decimal newSalary = Convert.ToDecimal(Console.ReadLine());

//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                conn.Open();
//                string selectQuery = "SELECT FirstName, Salary FROM Employees WHERE EmployeeID = @id";
//                SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
//                selectCmd.Parameters.AddWithValue("@id", empId);

//                SqlDataReader reader = selectCmd.ExecuteReader();

//                if (!reader.Read())
//                {
//                    Console.WriteLine("Employee not found!");
//                    reader.Close();
//                    return;
//                }

//                string firstName = reader["FirstName"].ToString();
//                decimal oldSalary = Convert.ToDecimal(reader["Salary"]);
//                reader.Close();

//                Console.WriteLine($"\nEmployee: {firstName}");
//                Console.WriteLine($"Old Salary: {oldSalary}");

//                string updateQuery = "UPDATE Employees SET Salary = @newSalary WHERE EmployeeID = @id";
//                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
//                updateCmd.Parameters.AddWithValue("@newSalary", newSalary);
//                updateCmd.Parameters.AddWithValue("@id", empId);

//                int rowsAffected = updateCmd.ExecuteNonQuery();

//                if (rowsAffected > 0)
//                {
//                    SqlCommand confirmCmd = new SqlCommand("SELECT Salary FROM Employees WHERE EmployeeID = @id", conn);
//                    confirmCmd.Parameters.AddWithValue("@id", empId);

//                    decimal updatedSalary = Convert.ToDecimal(confirmCmd.ExecuteScalar());
//                    Console.WriteLine(" Salary updated successfully!");
//                    Console.WriteLine($"New Salary: {updatedSalary}");
//                }
//                else
//                {
//                    Console.WriteLine(" No rows were updated. Please check the Employee ID.");
//                }
//            }

//            Console.WriteLine("\nDone.");
//        }
//    }
//}
