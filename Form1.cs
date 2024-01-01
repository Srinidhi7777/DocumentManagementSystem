using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DocumentManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-C0JKHT1\SQLEXPRESS;Database=DocumentSystem;Integrated Security=true;");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            using(SqlConnection cn = GetConnection())
            {
                string query = "SELECT ID,FileName,Extension FROM Document";
                SqlDataAdapter adp = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    dgvDocument.DataSource = dt;
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvDocument.SelectedRows;
            foreach(var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                OpenFile(id);
            }
        }
        private void OpenFile(int id)
        {
            using (SqlConnection cn = GetConnection())
            {
                string query = "SELECT Data,FileName,Extension FROM Document WHERE ID =@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cn.Open();
                var reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    var name = reader["FileName"].ToString();
                    var data = (byte[])reader["data"];
                    var extn = reader["Extension"].ToString();
                    var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;

                    File.WriteAllBytes(newFileName, data);
                    System.Diagnostics.Process.Start(newFileName);
                    
                }
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn =  new  SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using(DataTable dt = new DataTable("Documents"))
                    {
                        using (SqlCommand cmd = new SqlCommand("select ID,FileName,Extension from Document where Filename like @filename +'%' or Extension like @extension + '%'", cn))
                        {
                            cmd.Parameters.AddWithValue("FileName", txtSearch.Text);
                            cmd.Parameters.AddWithValue("Extension",txtSearch.Text);
                            SqlDataAdapter adapter =  new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                            lblTotal.Text = $"Total Records: {dataGridView1.RowCount}";
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13) //enter
                btnSearch.PerformClick();
        }

        
        private void btnOpen1_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows;
            foreach(var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                OpenFile1(id);
            }
        }
        private void OpenFile1(int id)
        {
            using (SqlConnection cn = GetConnection())
            {
                string query = "SELECT Data,FileName,Extension FROM Document WHERE ID =@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var name = reader["FileName"].ToString();
                    var data = (byte[])reader["data"];
                    var extn = reader["Extension"].ToString();
                    var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;

                    File.WriteAllBytes(newFileName, data);
                    System.Diagnostics.Process.Start(newFileName);
                }

            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string sourceConnectionString = "Data Source=DESKTOP-C0JKHT1\\SQLEXPRESS;Initial Catalog=DocumentSystem;Integrated Security=True;";
            string destinationConnectionString = "Data Source=DESKTOP-C0JKHT1\\SQLEXPRESS;Initial Catalog=Destination;Integrated Security=True;";

            //Establish connections 
            using (SqlConnection sourceConnection = new SqlConnection(sourceConnectionString))
            using (SqlConnection destinationConnection = new SqlConnection(destinationConnectionString))
            {
                sourceConnection.Open();
                destinationConnection.Open();

                //retrive data from source table
                using (SqlCommand command = new SqlCommand("Select * From Document", sourceConnection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //Insert data into destination table
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(destinationConnection))
                    {
                        bulkCopy.DestinationTableName = "destinationTable";
                        bulkCopy.WriteToServer(reader);
                    }
                    MessageBox.Show("Migrated successfully");
                }
            }
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (dgvDocument.SelectedRows.Count > 0)
            {
                // Get the ID of the selected row
                int id = (int)dgvDocument.SelectedRows[0].Cells["ID"].Value;

                // Delete the record from the database
                using (SqlConnection cn = GetConnection())
                {
                    if (result == DialogResult.Yes)
                    {
                        string deleteQuery = "DELETE FROM Document WHERE ID = @id";
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, cn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cn.Open();
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Files Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Files not deleted");
                    }
                        
                }

                // Delete the associated file from the system
                using (SqlConnection cn = GetConnection())
                {
                    string selectQuery = "SELECT FileName, Extension FROM Document WHERE ID = @id";
                    using (SqlCommand cmd = new SqlCommand(selectQuery, cn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cn.Open();
                        var reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            var name = reader["FileName"].ToString();
                            var extn = reader["Extension"].ToString();
                            var filePath = Path.Combine(Environment.CurrentDirectory, name + extn);

                            if (File.Exists(filePath))
                            {
                               File.Delete(filePath);
                            }
                        }
                    }
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a file to delete.");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "All Files (*.*)|*.*";
               
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        InsertFileToDatabase(filePath);
                    }
                }
            }
        }
        private bool IsValidFileType(string extn)
        {
            List<string> allowedExtensions = new List<string> { ".txt", ".pdf", ".docx", ".jpg", ".png", ".xlsx", ".ppt", ".JPG", ".zip"};
            return allowedExtensions.Contains(extn);
        }


        private void InsertFileToDatabase(string filePath)
        {
            byte[] fileData = File.ReadAllBytes(filePath);

            using (Stream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                var fi = new FileInfo(filePath);
                string extn = fi.Extension;
                string name = fi.Name;

                if (IsValidFileType(extn))
                {
                    string connectionString = "Data Source=DESKTOP-C0JKHT1\\SQLEXPRESS;Initial Catalog=DocumentSystem;Integrated Security=True";
                    string insertQuery = "INSERT INTO Document (Data, Extension,FileName) VALUES (@data, @extn, @name)";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {

                        command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                        command.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                        command.Parameters.Add("@extn", SqlDbType.Char).Value = extn;


                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Files inserted successfully");
                }
                else
                {
                    MessageBox.Show("Invalid File type. Please choose different file.");
                }
                
            }
        }
    }
    
}

