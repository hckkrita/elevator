using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevatorproject
{
    internal class Database
    {
        string connectionString = @"Server = DESKTOP-002K9SR\HEROHIRALAL;Database = Krita; Trusted_Connection = True;";

        public void InsertLogsIntoDB(DataTable dt)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"Insert into logs (LogTime, EventDescription) values (@Time, @Log)";

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.InsertCommand = new SqlCommand(query, conn);
                        adapter.InsertCommand.Parameters.Add("@Time", SqlDbType.DateTime, 0, "LogTime"); // LogTime parameter
                        adapter.InsertCommand.Parameters.Add("@Log", SqlDbType.NVarChar, 255, "EventDescription"); // EventDescription parameter

                        conn.Open();

                        adapter.Update(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving logs to DB: " + ex.Message);
            }
        }

        public void loadLogsFromDB(DataTable dt, DataGridView dataGridViewLogs)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"Select LogTime, EventDescription from logs order by LogTime desc";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        dt.Rows.Clear();

                        adapter.Fill(dt);

                        dataGridViewLogs.Rows.Clear();

                        foreach (DataRow row in dt.Rows)
                        {
                            // Format LogTime to display only time (hh:mm:ss format)
                            string currentTime = Convert.ToDateTime(row["LogTime"]).ToString("hh:mm:ss");
                            // Get the event description from the current row
                            string events = row["EventDescription"].ToString();

                            dataGridViewLogs.Rows.Add(currentTime, events);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading logs from DB: " + ex.Message);
            }

        }
        public void truncateLogsTable(DataGridView dataGridView1)
        {
            try
            {
                // Establishing connection with the database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // SQL query to delete all records from 'logs' table
                    string query = @"DELETE FROM logs";  // Using DELETE instead of TRUNCATE for testing

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Open the connection to the database
                        conn.Open();
                        // Execute the command to delete the records from the table
                        cmd.ExecuteNonQuery();

                        // Clear rows in the DataGridView after deleting logs from the database
                        dataGridView1.Rows.Clear();

                        // Display a message confirming the table has been cleared
                        MessageBox.Show("Logs table has been cleared.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Show error message if an exception occurs during the deletion process
                MessageBox.Show("Error clearing logs table: " + ex.Message);
            }
        }
    }
}
