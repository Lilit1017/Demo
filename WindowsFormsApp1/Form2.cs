using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourNamespace;

namespace WindowsFormsApp1
{
    public partial class AddTaskForm : Form
    {
        private DatabaseConnection dbConnection;

        public AddTaskForm()
        {
 
            InitializeComponent();
            dbConnection = new DatabaseConnection();
        }

        private void btnAddTask_Click_1(object sender, EventArgs e)
        {
            string query = "INSERT INTO tasks (task_number, creation_date, project_name, description, priority, executor, status) VALUES(@taskNumber, @creationDate, @projectName, @description, @priority, @executor, @status)";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@taskNumber", txtTaskNumber.Text);
                cmd.Parameters.AddWithValue("@creationDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@projectName", txtProjectName.Text);
                cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@priority", cmbPriority.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@executor", txtExecutor.Text);
                cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());

                dbConnection.OpenConnection();
                cmd.ExecuteNonQuery();
                dbConnection.CloseConnection();

                MessageBox.Show("Task added successfully!");
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
    }
}
