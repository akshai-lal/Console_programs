using System;
using System.Data;
using System.Data.OleDb;

using System;
using System.Data;
using System.Data.OleDb;

class Readfromexcel
{
    //static void Main()
    //{ 
    //    string filePath = @"C:\Users\Akshai.Lal\OneDrive - Neudesic\Student_date.xlsx";

    //    string connectionString =
    //        $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};
    //        Extended Properties='Excel 12.0 Xml;HDR=YES;'";

    //    using (OleDbConnection connection = new OleDbConnection(connectionString))
    //    {
    //        try
    //        {
    //            connection.Open();

    //            DataTable sheets = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
    //            string sheetName = sheets.Rows[0]["TABLE_NAME"].ToString();

    //            string query  = $"SELECT Name FROM [{sheetName}] WHERE Age > 21"; ;
    //            OleDbCommand command = new OleDbCommand(query, connection);

    //            OleDbDataReader reader = command.ExecuteReader();

    //            for (int i = 0; i < reader.FieldCount; i++)
    //            {
    //                Console.Write(reader.GetName(i) + "\t");
    //            }
    //            Console.WriteLine();
    //            Console.WriteLine("-------------------------------");

    //            while (reader.Read())
    //            {
    //                for (int i = 0; i < reader.FieldCount; i++)
    //                {
    //                    Console.Write(reader[i].ToString() + "\t");
    //                }
    //                Console.WriteLine();
    //            }

    //            reader.Close();
    //            connection.Close();
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Error: " + ex.Message);
    //        }
    //    }

    //    Console.ReadLine();
    //}
}
