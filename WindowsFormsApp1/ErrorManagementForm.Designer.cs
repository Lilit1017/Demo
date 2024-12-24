namespace YourNamespace
{
    partial class ErrorManagementForm
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
            this.dataGridViewErrors = new System.Windows.Forms.DataGridView();
            this.btnEditError = new System.Windows.Forms.Button();
            this.btnCloseError = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErrors)).BeginInit();
            this.SuspendLayout();
            //
            // dataGridViewErrors
            //
            this.dataGridViewErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewErrors.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewErrors.Name = "dataGridViewErrors";
            this.dataGridViewErrors.Size = new System.Drawing.Size(776, 250);
            this.dataGridViewErrors.TabIndex = 0;
            //
            // btnEditError
            //
            this.btnEditError.Location = new System.Drawing.Point(12, 270);
            this.btnEditError.Name = "btnEditError";
            this.btnEditError.Size = new System.Drawing.Size(75, 23);
            this.btnEditError.TabIndex = 1;
            this.btnEditError.Text = "Edit Error";
            this.btnEditError.UseVisualStyleBackColor = true;
            this.btnEditError.Click += new System.EventHandler(this.btnEditError_Click);
            //
            // btnCloseError
            //
            this.btnCloseError.Location = new System.Drawing.Point(93, 270);
            this.btnCloseError.Name = "btnCloseError";
            this.btnCloseError.Size = new System.Drawing.Size(75, 23);
            this.btnCloseError.TabIndex = 2;
            this.btnCloseError.Text = "Close Error";
            this.btnCloseError.UseVisualStyleBackColor = true;
            this.btnCloseError.Click += new System.EventHandler(this.btnCloseError_Click);
            //
            // ErrorManagementForm
            //
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCloseError);
            this.Controls.Add(this.btnEditError);
            this.Controls.Add(this.dataGridViewErrors);
            this.Name = "ErrorManagementForm";
            this.Text = "Error Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErrors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}