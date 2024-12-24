namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.txtTaskNumber = new System.Windows.Forms.TextBox();
            this.txtExecutor = new System.Windows.Forms.TextBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.btnGenerateQRCode = new System.Windows.Forms.Button();
            this.btnManageErrors = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnReportError = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.Size = new System.Drawing.Size(781, 250);
            this.dataGridViewTasks.TabIndex = 0;
            // 
            // txtTaskNumber
            // 
            this.txtTaskNumber.Location = new System.Drawing.Point(485, 284);
            this.txtTaskNumber.Name = "txtTaskNumber";
            this.txtTaskNumber.Size = new System.Drawing.Size(121, 20);
            this.txtTaskNumber.TabIndex = 1;
            // 
            // txtExecutor
            // 
            this.txtExecutor.Location = new System.Drawing.Point(485, 310);
            this.txtExecutor.Name = "txtExecutor";
            this.txtExecutor.Size = new System.Drawing.Size(121, 20);
            this.txtExecutor.TabIndex = 2;
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "низкий",
            "средний",
            "высокий"});
            this.cmbPriority.Location = new System.Drawing.Point(485, 336);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(121, 21);
            this.cmbPriority.TabIndex = 3;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "в ожидании",
            "в работе",
            "выполнено"});
            this.cmbStatus.Location = new System.Drawing.Point(485, 363);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 4;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(30, 287);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(99, 23);
            this.btnAddTask.TabIndex = 5;
            this.btnAddTask.Text = "Добавить";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click_1);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Location = new System.Drawing.Point(146, 287);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(100, 23);
            this.btnEditTask.TabIndex = 6;
            this.btnEditTask.Text = "Редактировать";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click_1);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(632, 287);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(136, 43);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "Фильтр";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Исполнитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Статус";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Приоритет";
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Location = new System.Drawing.Point(632, 339);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(136, 99);
            this.pictureBoxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQRCode.TabIndex = 10;
            this.pictureBoxQRCode.TabStop = false;
            this.pictureBoxQRCode.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // btnGenerateQRCode
            // 
            this.btnGenerateQRCode.Location = new System.Drawing.Point(485, 391);
            this.btnGenerateQRCode.Name = "btnGenerateQRCode";
            this.btnGenerateQRCode.Size = new System.Drawing.Size(121, 47);
            this.btnGenerateQRCode.TabIndex = 11;
            this.btnGenerateQRCode.Text = "QR генератор";
            this.btnGenerateQRCode.UseVisualStyleBackColor = true;
            this.btnGenerateQRCode.Click += new System.EventHandler(this.btnGenerateQRCode_Click_1);
            // 
            // btnManageErrors
            // 
            this.btnManageErrors.Location = new System.Drawing.Point(12, 363);
            this.btnManageErrors.Name = "btnManageErrors";
            this.btnManageErrors.Size = new System.Drawing.Size(150, 27);
            this.btnManageErrors.TabIndex = 12;
            this.btnManageErrors.Text = "Менеджер ошибок";
            this.btnManageErrors.UseVisualStyleBackColor = true;
            this.btnManageErrors.Click += new System.EventHandler(this.btnManageUsers_Click_1);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(12, 405);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(150, 23);
            this.btnManageUsers.TabIndex = 13;
            this.btnManageUsers.Text = "Менеджер доступа";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnReportError
            // 
            this.btnReportError.Location = new System.Drawing.Point(168, 403);
            this.btnReportError.Name = "btnReportError";
            this.btnReportError.Size = new System.Drawing.Size(149, 23);
            this.btnReportError.TabIndex = 14;
            this.btnReportError.Text = "Сообщения об ошибке";
            this.btnReportError.UseVisualStyleBackColor = true;
            this.btnReportError.Click += new System.EventHandler(this.btnReportError_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.btnReportError);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnManageErrors);
            this.Controls.Add(this.btnGenerateQRCode);
            this.Controls.Add(this.pictureBoxQRCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.txtExecutor);
            this.Controls.Add(this.txtTaskNumber);
            this.Controls.Add(this.dataGridViewTasks);
            this.Name = "MainForm";
            this.Text = "Task Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.TextBox txtTaskNumber;
        private System.Windows.Forms.TextBox txtExecutor;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private System.Windows.Forms.Button btnGenerateQRCode;
        private System.Windows.Forms.Button btnManageErrors;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnReportError;
    }
}

