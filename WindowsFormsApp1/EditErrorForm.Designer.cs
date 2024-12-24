namespace YourNamespace
{
    partial class EditErrorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.cmbSeverity = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // txtMessage
            //
            this.txtMessage.Location = new System.Drawing.Point(12, 12);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(200, 20);
            this.txtMessage.TabIndex = 0;
            //
            // cmbSeverity
            //
            this.cmbSeverity.FormattingEnabled = true;
            this.cmbSeverity.Items.AddRange(new object[] {
            "low",
            "medium",
            "high"});
            this.cmbSeverity.Location = new System.Drawing.Point(12, 38);
            this.cmbSeverity.Name = "cmbSeverity";
            this.cmbSeverity.Size = new System.Drawing.Size(200, 21);
            this.cmbSeverity.TabIndex = 1;
            //
            // cmbStatus
            //
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "open",
            "in_progress",
            "closed"});
            this.cmbStatus.Location = new System.Drawing.Point(12, 65);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 2;
            //
            // btnSave
            //
            this.btnSave.Location = new System.Drawing.Point(12, 92);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            // EditErrorForm
            //
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbSeverity);
            this.Controls.Add(this.txtMessage);
            this.Name = "EditErrorForm";
            this.Text = "Edit Error";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewErrors;
        private System.Windows.Forms.Button btnEditError;
        private System.Windows.Forms.Button btnCloseError;
        #endregion
    }
}