using System;
using System.Windows.Forms;
using Npgsql;
using YourNamespace;

namespace YourNamespace
{
    public partial class EditUserForm : Form
    {
        private DatabaseConnection dbConnection;
        private int userId;

        public EditUserForm(int userId)
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            this.userId = userId;
            LoadUserDetails();
        }



        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnSave;

        private void LoadUserDetails()
        {
            string query = "SELECT * FROM users WHERE id = @id";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@id", userId);
                dbConnection.OpenConnection();
                NpgsqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtUsername.Text = reader["username"].ToString();
                    txtPassword.Text = reader["password"].ToString();
                    cmbRole.SelectedItem = reader["role"].ToString();
                }

                dbConnection.CloseConnection();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "UPDATE users SET username = @username, password = @password, role = @role WHERE id = @id";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@id", userId);

                dbConnection.OpenConnection();
                cmd.ExecuteNonQuery();
                dbConnection.CloseConnection();

                MessageBox.Show("User updated successfully!");
                this.Close();
            }
        }
    }
}
