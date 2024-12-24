using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using YourNamespace;

namespace WindowsFormsApp1
{
    public partial class LogginForm : Form
    {
        private DatabaseConnection dbConnection;
        public LogginForm()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users WHERE username = @username AND password = @password";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                dbConnection.OpenConnection();
                NpgsqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["role"].ToString();
                    dbConnection.CloseConnection();

                    MainForm mainForm = new MainForm(role);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                    dbConnection.CloseConnection();
                }
            }



        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}