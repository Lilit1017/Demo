namespace YourNamespace
{
    partial class ReportErrorForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 12);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(260, 100);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // cmbSeverity
            // 
            this.cmbSeverity.FormattingEnabled = true;
            this.cmbSeverity.Items.AddRange(new object[] {
            "low",
            "medium",
            "high"});
            this.cmbSeverity.Location = new System.Drawing.Point(12, 120);
            this.cmbSeverity.Name = "cmbSeverity";
            this.cmbSeverity.Size = new System.Drawing.Size(121, 21);
            this.cmbSeverity.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 150);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ReportErrorForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbSeverity);
            this.Controls.Add(this.txtMessage);
            this.Name = "ReportErrorForm";
            this.Text = "Report Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}