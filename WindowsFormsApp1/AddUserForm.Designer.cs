namespace YourNamespace
{
    partial class AddUserForm
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
            this.SuspendLayout();
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.ResumeLayout(false);

                this.txtUsername = new System.Windows.Forms.TextBox();
                this.txtPassword = new System.Windows.Forms.TextBox();
                this.cmbRole = new System.Windows.Forms.ComboBox();
                this.btnAddUser = new System.Windows.Forms.Button();
                this.SuspendLayout();
                //
                // txtUsername
                //
                this.txtUsername.Location = new System.Drawing.Point(12, 12);
                this.txtUsername.Name = "txtUsername";
                this.txtUsername.Size = new System.Drawing.Size(200, 20);
                this.txtUsername.TabIndex = 0;
                //
                // txtPassword
                //
                this.txtPassword.Location = new System.Drawing.Point(12, 38);
                this.txtPassword.Name = "txtPassword";
                this.txtPassword.Size = new System.Drawing.Size(200, 20);
                this.txtPassword.TabIndex = 1;
                this.txtPassword.UseSystemPasswordChar = true;
                //
                // cmbRole
                //
                this.cmbRole.FormattingEnabled = true;
                this.cmbRole.Items.AddRange(new object[] {
            "director",
            "admin",
            "user"});
                this.cmbRole.Location = new System.Drawing.Point(12, 64);
                this.cmbRole.Name = "cmbRole";
                this.cmbRole.Size = new System.Drawing.Size(200, 21);
                this.cmbRole.TabIndex = 2;
                //
                // btnAddUser
                //
                this.btnAddUser.Location = new System.Drawing.Point(12, 91);
                this.btnAddUser.Name = "btnAddUser";
                this.btnAddUser.Size = new System.Drawing.Size(200, 23);
                this.btnAddUser.TabIndex = 3;
                this.btnAddUser.Text = "Add User";
                this.btnAddUser.UseVisualStyleBackColor = true;
                this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
                //
                // AddUserForm
                //
                this.ClientSize = new System.Drawing.Size(284, 126);
                this.Controls.Add(this.btnAddUser);
                this.Controls.Add(this.cmbRole);
                this.Controls.Add(this.txtPassword);
                this.Controls.Add(this.txtUsername);
                this.Name = "AddUserForm";
                this.Text = "Add User";
                this.ResumeLayout(false);
                this.PerformLayout();
            }

        }

        #endregion
    }