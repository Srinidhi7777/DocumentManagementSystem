using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentManagementSystem
{
    internal static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //string sourceConnectionString = "Data Source=DESKTOP-C0JKHT1\\SQLEXPRESS;Initial Catalog=DocumentSystem;Integrated Security=True;";
            //string destinationConnectionString = "Data Source=DESKTOP-C0JKHT1\\SQLEXPRESS;Initial Catalog=Destination;Integrated Security=True;";

            ////Establish connections 
            //using (SqlConnection sourceConnection = new SqlConnection(sourceConnectionString))
            //using (SqlConnection destinationConnection = new SqlConnection(destinationConnectionString))
            //{
            //    sourceConnection.Open();
            //    destinationConnection.Open();

            //    //retrive data from source table
            //    using (SqlCommand command = new SqlCommand("Select * From Document", sourceConnection))
            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        //Insert data into destination table
            //        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(destinationConnection))
            //        {
            //            bulkCopy.DestinationTableName = "destinationTable";
            //            bulkCopy.WriteToServer(reader);
            //        }
            //    }
            //}
        }
      
    }
}
