namespace Employees_Management_3112
{
    partial class employer_Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkPassword = new System.Windows.Forms.CheckBox();
            this.enterPassword = new System.Windows.Forms.TextBox();
            this.employer_password = new System.Windows.Forms.Label();
            this.enterUser = new System.Windows.Forms.TextBox();
            this.employer_user = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.employee_login = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(269, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkPassword
            // 
            this.checkPassword.AutoSize = true;
            this.checkPassword.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPassword.Location = new System.Drawing.Point(402, 274);
            this.checkPassword.Name = "checkPassword";
            this.checkPassword.Size = new System.Drawing.Size(128, 22);
            this.checkPassword.TabIndex = 15;
            this.checkPassword.Text = "Show Password";
            this.checkPassword.UseVisualStyleBackColor = true;
            this.checkPassword.CheckedChanged += new System.EventHandler(this.checkPassword_CheckedChanged);
            // 
            // enterPassword
            // 
            this.enterPassword.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPassword.Location = new System.Drawing.Point(269, 238);
            this.enterPassword.Multiline = true;
            this.enterPassword.Name = "enterPassword";
            this.enterPassword.PasswordChar = '*';
            this.enterPassword.Size = new System.Drawing.Size(261, 30);
            this.enterPassword.TabIndex = 14;
            this.enterPassword.TextChanged += new System.EventHandler(this.enterPassword_TextChanged);
            // 
            // employer_password
            // 
            this.employer_password.AutoSize = true;
            this.employer_password.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employer_password.Location = new System.Drawing.Point(265, 214);
            this.employer_password.Name = "employer_password";
            this.employer_password.Size = new System.Drawing.Size(82, 21);
            this.employer_password.TabIndex = 13;
            this.employer_password.Text = "Password:";
            // 
            // enterUser
            // 
            this.enterUser.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterUser.Location = new System.Drawing.Point(269, 168);
            this.enterUser.Multiline = true;
            this.enterUser.Name = "enterUser";
            this.enterUser.Size = new System.Drawing.Size(261, 30);
            this.enterUser.TabIndex = 12;
            this.enterUser.TextChanged += new System.EventHandler(this.enterUser_TextChanged);
            // 
            // employer_user
            // 
            this.employer_user.AutoSize = true;
            this.employer_user.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employer_user.Location = new System.Drawing.Point(265, 144);
            this.employer_user.Name = "employer_user";
            this.employer_user.Size = new System.Drawing.Size(85, 21);
            this.employer_user.TabIndex = 11;
            this.employer_user.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Supervisor Log In";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.employee_login);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 400);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(57, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Employee Login";
            // 
            // employee_login
            // 
            this.employee_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employee_login.Location = new System.Drawing.Point(26, 357);
            this.employee_login.Name = "employee_login";
            this.employee_login.Size = new System.Drawing.Size(189, 30);
            this.employee_login.TabIndex = 3;
            this.employee_login.Text = "LOGIN";
            this.employee_login.UseVisualStyleBackColor = true;
            this.employee_login.Click += new System.EventHandler(this.employee_login_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(33, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Management System";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(543, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 21);
            this.exit.TabIndex = 17;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // employer_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 400);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkPassword);
            this.Controls.Add(this.enterPassword);
            this.Controls.Add(this.employer_password);
            this.Controls.Add(this.enterUser);
            this.Controls.Add(this.employer_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employer_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employer_Login";
            this.Load += new System.EventHandler(this.employer_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkPassword;
        private System.Windows.Forms.TextBox enterPassword;
        private System.Windows.Forms.Label employer_password;
        private System.Windows.Forms.TextBox enterUser;
        private System.Windows.Forms.Label employer_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button employee_login;
    }
}