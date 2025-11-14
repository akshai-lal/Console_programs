using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace DataValidation
{
    public class ExceltoDictionary
    {
        public static void excelToDictionary()
        {
            String filepath = @"C:\Users\Akshai.Lal\OneDrive - Neudesic\Student_date.xlsx";
            string sheetName = "Sheet1$";

            if (!File.Exists(filepath))
            {
                Console.WriteLine("File not Found");
            }
            else
            {
                Console.WriteLine("File Found");
            }

            Dictionary<int, (String name, int age)> employee = new Dictionary<int, (string, int)>();
            string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filepath};Extended Properties='Excel 12.0 Xml;HDR=YES;'";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                String query = $"SELECT * FROM [{sheetName}]";
                OleDbCommand cmd=new OleDbCommand(query, conn);
                OleDbDataReader reader= cmd.ExecuteReader();
                Console.WriteLine("datas from the excel :\n  ");
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    String name = reader["Name"].ToString();
                    int age = Convert.ToInt32(reader["Age"]);
                    employee[id]=(name, age);
                }

                reader.Close();
            }

            foreach (var kvp in employee)
            {
                Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value.name}, Age: {kvp.Value.age}");
            }

        }
    }
}
