using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataValidation
{
    internal class updateexcelsheet
    {
        public static void updateExcelSheet()
        {
            string filePath = @"C:\Users\Akshai.Lal\OneDrive - Neudesic\Student_date.xlsx";
            string sheetName = "Sheet1$";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Excel file not found!");
                return;
            }

            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                $"Data Source={filePath};" +
                "Extended Properties='Excel 12.0 Xml;HDR=YES;'";

            Console.Write("Enter ID to update age: ");
            int idToUpdate = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter new age: ");
            int newAge = Convert.ToInt32(Console.ReadLine());

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();

                string selectQuery = $"SELECT Age FROM [{sheetName}] WHERE ID = {idToUpdate}";
                OleDbCommand selectCmd = new OleDbCommand(selectQuery, conn);

                object oldValue = selectCmd.ExecuteScalar();

                if (oldValue == null || oldValue == DBNull.Value)
                {
                    Console.WriteLine("❌ Record not found!");
                    return;
                }

                Console.WriteLine($"\nOld Age for ID {idToUpdate}: {oldValue}");

                string updateQuery = $"UPDATE [{sheetName}] SET Age = {newAge} WHERE ID = {idToUpdate}";
                OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn);
                int rowsAffected = updateCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("✅ Age updated successfully!");
                }
                else
                {
                    Console.WriteLine("⚠️ No rows updated.");
                }

                OleDbCommand confirmCmd = new OleDbCommand(selectQuery, conn);
                object newValue = confirmCmd.ExecuteScalar();

                Console.WriteLine($"New Age for ID {idToUpdate}: {newValue}");
            }
        }
    }

}

