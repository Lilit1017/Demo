using System;
using System.Windows.Forms;
using Npgsql;
using YourNamespace;

namespace YourNamespace
{
    public partial class AddUserForm : Form
    {
        private DatabaseConnection dbConnection;

        public AddUserForm()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
        }



        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnAddUser;

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO users (username, password, role) VALUES (@username, @password, @role)";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString());

                dbConnection.OpenConnection();
                cmd.ExecuteNonQuery();
                dbConnection.CloseConnection();

                MessageBox.Show("User added successfully!");
                this.Close();
            }
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
