using System;
using System.Windows.Forms;
using Npgsql;
using YourNamespace;

namespace YourNamespace
{
    public partial class EditErrorForm : Form
    {
        private DatabaseConnection dbConnection;
        private int errorId;

        public EditErrorForm(int errorId)
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            this.errorId = errorId;
            LoadErrorDetails();
        }

  

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ComboBox cmbSeverity;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSave;

        private void LoadErrorDetails()
        {
            string query = "SELECT * FROM error_messages WHERE id = @id";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@id", errorId);
                dbConnection.OpenConnection();
                NpgsqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtMessage.Text = reader["message"].ToString();
                    cmbSeverity.SelectedItem = reader["severity"].ToString();
                    cmbStatus.SelectedItem = reader["status"].ToString();
                }

                dbConnection.CloseConnection();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "UPDATE error_messages SET message = @message, severity = @severity, status = @status WHERE id = @id";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@message", txtMessage.Text);
                cmd.Parameters.AddWithValue("@severity", cmbSeverity.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@id", errorId);

                dbConnection.OpenConnection();
                cmd.ExecuteNonQuery();
                dbConnection.CloseConnection();

                MessageBox.Show("Error message updated successfully!");
                this.Close();
            }
        }
    }
}
