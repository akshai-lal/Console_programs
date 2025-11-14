using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataValidation
{
    public class ExcelToDatabase
    {
        public static void excelToDatabase()
        {
            String filepath = @"C:\Users\Akshai.Lal\OneDrive - Neudesic\Student_date.xlsx";
            if (File.Exists(filepath))
            {
                Console.WriteLine("Excel file is found");
            }
            else
            {
                Console.WriteLine("File not found");
            }

            String excelconnectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filepath};Extended Properties='Excel 12.0 Xml;HDR=YES;'";
            String sqlconnectionString=@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDatabase;Integrated Security=True;";

            DataTable dt2 = new DataTable();
            using (OleDbConnection oledbconn=new OleDbConnection(excelconnectionString))
            {
                oledbconn.Open();

                String excelquery = "SELECT TOP 5 * FROM [Sheet1$]";
                //OleDbCommand cmd = new OleDbCommand(excelquery, oledbconn);
                OleDbDataAdapter adapter=new OleDbDataAdapter(excelquery, oledbconn);
                adapter.Fill(dt2);
            }
            Console.WriteLine("Top 5 records from excel:\n");

            using (SqlConnection sqlconn=new SqlConnection(sqlconnectionString))
            {
                sqlconn.Open();
                foreach(DataRow row in dt2.Rows)
                {
                    int id = Convert.ToInt32(row["ID"]);
                    String name = row["Name"].ToString();
                    int age = Convert.ToInt32(row["Age"]);

                    String[] parts = name.Split(" ");
                    String firstname=parts[0];
                    String lastname = parts.Length > 1 ? parts[1] : "";
                    Console.WriteLine($"ID={id} Firstname={firstname} LastName={lastname} Age={age}");

                    String insertquery = "Insert into Employee(EmployeeID, FirstName, LastName, Age)" + "VALUES(@id, @firstname, @lastname,@age)";
                    using (SqlCommand cmd = new SqlCommand(insertquery, sqlconn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            Console.WriteLine("\nSuccessfully inserted to Database");
        }
    }
}
