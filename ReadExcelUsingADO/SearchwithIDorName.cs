using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace DataValidation
{
    public class SearchwithIDorName
    {
        public static void searchWithNameOrId()
        {
            String filepath = @"C:\Users\Akshai.Lal\OneDrive - Neudesic\Student_date.xlsx";
            if(File.Exists(filepath))
            {
                Console.WriteLine("File found");
            }
            else
            {
                Console.WriteLine("File not found");
            }

            String connectionString= $@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = {filepath}; Extended Properties = 'Excel 12.0 Xml;HDR=YES;'";
            Dictionary<int, (String name, int age)> employee = new Dictionary<int, (string name, int age)>();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                String query = "SELECT * FROM [Sheet1$]";
                OleDbCommand cmd=new OleDbCommand(query, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
               
                while(reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    String name = reader["Name"].ToString();
                    int age = Convert.ToInt32(reader["Age"]);

                    employee[id] = (name, age);
                }
                reader.Close();
            }

            Console.WriteLine("Enter the id or string to search");
            String input = Console.ReadLine();
            if(int.TryParse(input, out int ids))
            {
                if(employee.ContainsKey(ids))
                {
                    var emp= employee[ids];
                    Console.WriteLine($"Employee is found with id : {ids} name : {emp.name} age : {emp.age}");
                }
                else
                {
                    Console.WriteLine("Employee is not found");
                }
            }
            else
            {
                Boolean flag = false;
                foreach(var kvp in employee)
                {
                    if(kvp.Value.name.Contains(input))
                    {
                        flag = true;
                        Console.WriteLine("Employee found");
                        break;
                    }
                }

                if(!flag)
                {
                    Console.WriteLine("Employee not found");
                }
            }
        }
    }
}
