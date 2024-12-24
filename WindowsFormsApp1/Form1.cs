using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using QRCoder;
using YourNamespace;

    
namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private DatabaseConnection dbConnection;
        private string userRole;
        public MainForm(string role)
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            LoadTasks();
            userRole = role;
            SetPermissions();
        }

        private void btnGenerateQRCode_Click_1(object sender, EventArgs e)
        {
            string url = "https://github.com/Lilit1017";
            GenerateQRCode(url);
        }

        private void GenerateQRCode(string url)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    Bitmap qrCodeImage = qrCode.GetGraphic(20);
                    pictureBoxQRCode.Image = qrCodeImage;
                }
            }
        }


        private void SetPermissions()
        {
            switch (userRole)
            {
                case "director":
                    // Директор имеет полный доступ
                    btnAddTask.Enabled = true;
                    btnEditTask.Enabled = true;
                    btnManageUsers.Enabled = true;
                    btnManageErrors.Enabled = true;
                    break;
                case "admin":
                    // Админ имеет доступ к добавлению и редактированию задач
                    btnAddTask.Enabled = true;
                    btnEditTask.Enabled = true;
                    btnManageUsers.Enabled = true;
                    btnManageErrors.Enabled = true;
                    break;
                case "user":
                    // Пользователь имеет доступ только к просмотру задач
                    btnAddTask.Enabled = false;
                    btnEditTask.Enabled = false;
                    btnManageUsers.Enabled = false;
                    btnManageErrors.Enabled = false;
                    break;
                default:
                    // По умолчанию ограничиваем доступ
                    btnAddTask.Enabled = false;
                    btnEditTask.Enabled = false;
                    btnManageUsers.Enabled = false;
                    btnManageErrors.Enabled = false;
                    break;
            }
        }

        private void LoadTasks()
        {
            string query = "SELECT * FROM tasks";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
            {
                dbConnection.OpenConnection();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewTasks.DataSource = dt;
                dbConnection.CloseConnection();
            }
        }
        private void btnAddTask_Click_1(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm();
            addTaskForm.ShowDialog();
            LoadTasks();
        }
        private void btnEditTask_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                int taskId = (int)dataGridViewTasks.SelectedRows[0].Cells["id"].Value;
                EditTaskForm editTaskForm = new EditTaskForm(taskId);
                editTaskForm.ShowDialog();
                LoadTasks();
            }
        }


        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tasks WHERE 1=1";

            if (!string.IsNullOrEmpty(txtTaskNumber.Text))
            {
                query += " AND task_number LIKE @taskNumber";
            }

            if (!string.IsNullOrEmpty(txtExecutor.Text))
            {
                query += " AND executor LIKE @executor";
            }

            if (cmbPriority.SelectedItem != null && !string.IsNullOrEmpty(cmbPriority.SelectedItem.ToString()))
            {
                query += " AND priority = @priority";
            }

            if (cmbStatus.SelectedItem != null && !string.IsNullOrEmpty(cmbStatus.SelectedItem.ToString()))
            {
                query += " AND status = @status";
            }

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, dbConnection.GetConnection()))
            {
                if (!string.IsNullOrEmpty(txtTaskNumber.Text))
                {
                    cmd.Parameters.AddWithValue("@taskNumber", "%" + txtTaskNumber.Text + "%");
                }

                if (!string.IsNullOrEmpty(txtExecutor.Text))
                {
                    cmd.Parameters.AddWithValue("@executor", "%" + txtExecutor.Text + "%");
                }

                if (cmbPriority.SelectedItem != null && !string.IsNullOrEmpty(cmbPriority.SelectedItem.ToString()))
                {
                    cmd.Parameters.AddWithValue("@priority", cmbPriority.SelectedItem.ToString());
                }

                if (cmbStatus.SelectedItem != null && !string.IsNullOrEmpty(cmbStatus.SelectedItem.ToString()))
                {
                    cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());
                }

                dbConnection.OpenConnection();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewTasks.DataSource = dt;
                dbConnection.CloseConnection();
            }
        }

        private void btnManageUsers_Click_1(object sender, EventArgs e)
        {
            ErrorManagementForm errorManagementForm = new ErrorManagementForm();
            errorManagementForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ErrorManagementForm errorManagementForm = new ErrorManagementForm();
            errorManagementForm.ShowDialog();
        }

        private void btnReportError_Click(object sender, EventArgs e)
        {
            ReportErrorForm reportErrorForm = new ReportErrorForm();
            reportErrorForm.ShowDialog();
        }
    }
}

   
