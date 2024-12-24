using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using YourNamespace;

namespace YourNamespace
{
    public partial class ErrorManagementForm : Form
    {
        private DatabaseConnection dbConnection;

        public ErrorManagementForm()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            LoadErrorMessages();
        }

  

        private System.Windows.Forms.DataGridView dataGridViewErrors;
        private System.Windows.Forms.Button btnEditError;
        private System.Windows.Forms.Button btnCloseError;

        private void LoadErrorMessages()
        {
            string query = "SELECT * FROM error_messages";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
            {
                dbConnection.OpenConnection();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewErrors.DataSource = dt;
                dbConnection.CloseConnection();
            }
        }

        private void btnEditError_Click(object sender, EventArgs e)
        {
            if (dataGridViewErrors.SelectedRows.Count > 0)
            {
                int errorId = (int)dataGridViewErrors.SelectedRows[0].Cells["id"].Value;
                EditErrorForm editErrorForm = new EditErrorForm(errorId);
                editErrorForm.ShowDialog();
                LoadErrorMessages();
            }
        }

        private void btnCloseError_Click(object sender, EventArgs e)
        {
            if (dataGridViewErrors.SelectedRows.Count > 0)
            {
                int errorId = (int)dataGridViewErrors.SelectedRows[0].Cells["id"].Value;
                string query = "UPDATE error_messages SET status = 'closed' WHERE id = @id";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", errorId);
                    dbConnection.OpenConnection();
                    cmd.ExecuteNonQuery();
                    dbConnection.CloseConnection();
                }

                LoadErrorMessages();
            }
        }
    }
}
