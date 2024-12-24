using System;
using System.Windows.Forms;
using Npgsql;
using YourNamespace;

namespace YourNamespace
{
    public partial class ReportErrorForm : Form
    {
        private DatabaseConnection dbConnection;

        public ReportErrorForm()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
        }

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ComboBox cmbSeverity;
        private System.Windows.Forms.Button btnSubmit;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO error_messages (message, severity, status) VALUES (@message, @severity, 'open')";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@message", txtMessage.Text);
                cmd.Parameters.AddWithValue("@severity", cmbSeverity.SelectedItem.ToString());

                dbConnection.OpenConnection();
                cmd.ExecuteNonQuery();
                dbConnection.CloseConnection();

                MessageBox.Show("Error message submitted successfully!");
                this.Close();
            }
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
