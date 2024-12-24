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
    public partial class EditTaskForm : Form
    {
        private DatabaseConnection dbConnection;
        private int taskId;

        public EditTaskForm(int taskId)
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            this.taskId = taskId;
            LoadTaskDetails();
        }
        private void LoadTaskDetails()
        {
            string query = "SELECT * FROM tasks WHERE id = @taskId";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@taskId", taskId);
                dbConnection.OpenConnection();
                NpgsqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtTaskNumber.Text = reader["task_number"].ToString();
                    txtProjectName.Text = reader["project_name"].ToString();
                    txtDescription.Text = reader["description"].ToString();
                    cmbPriority.SelectedItem = reader["priority"].ToString();
                    txtExecutor.Text = reader["executor"].ToString();
                    cmbStatus.SelectedItem = reader["status"].ToString();
                }

                dbConnection.CloseConnection();
            }
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string query = "UPDATE tasks SET task_number = @taskNumber, project_name = @projectName, description = @description, priority = @priority, executor = @executor, status = @status WHERE id = @taskId";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@taskNumber", txtTaskNumber.Text);
                cmd.Parameters.AddWithValue("@projectName", txtProjectName.Text);
                cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@priority", cmbPriority.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@executor", txtExecutor.Text);
                cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@taskId", taskId);

                dbConnection.OpenConnection();
                cmd.ExecuteNonQuery();
                dbConnection.CloseConnection();

                MessageBox.Show("Task updated successfully!");
                this.Close();
            }
        }

        private void EditTaskForm_Load(object sender, EventArgs e)
        {

        }

     
    }
}
