using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using YourNamespace;

namespace YourNamespace
{
    public partial class UserManagementForm : Form
    {
        private DatabaseConnection dbConnection;

        public UserManagementForm()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            LoadUsers();
        }

   

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;

        private void LoadUsers()
        {
            string query = "SELECT * FROM users";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
            {
                dbConnection.OpenConnection();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewUsers.DataSource = dt;
                dbConnection.CloseConnection();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
            LoadUsers();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int userId = (int)dataGridViewUsers.SelectedRows[0].Cells["id"].Value;
                EditUserForm editUserForm = new EditUserForm(userId);
                editUserForm.ShowDialog();
                LoadUsers();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int userId = (int)dataGridViewUsers.SelectedRows[0].Cells["id"].Value;
                string query = "DELETE FROM users WHERE id = @id";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    dbConnection.OpenConnection();
                    cmd.ExecuteNonQuery();
                    dbConnection.CloseConnection();
                }

                LoadUsers();
            }
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
