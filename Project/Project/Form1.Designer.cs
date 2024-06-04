namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpboxPas = new GroupBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUserName = new Label();
            lblEnter = new Label();
            grpboxGrs = new GroupBox();
            grpboxPas.SuspendLayout();
            grpboxGrs.SuspendLayout();
            SuspendLayout();
            // 
            // grpboxPas
            // 
            grpboxPas.BackColor = SystemColors.ActiveCaption;
            grpboxPas.Controls.Add(btnLogin);
            grpboxPas.Controls.Add(txtPassword);
            grpboxPas.Controls.Add(txtUsername);
            grpboxPas.Controls.Add(lblPassword);
            grpboxPas.Controls.Add(lblUserName);
            grpboxPas.Controls.Add(lblEnter);
            grpboxPas.Location = new Point(332, 191);
            grpboxPas.Name = "grpboxPas";
            grpboxPas.Size = new Size(659, 376);
            grpboxPas.TabIndex = 1;
            grpboxPas.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(278, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(260, 199);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(260, 126);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 31);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(103, 199);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(103, 126);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(99, 25);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name";
            // 
            // lblEnter
            // 
            lblEnter.AutoSize = true;
            lblEnter.Location = new Point(288, 27);
            lblEnter.Name = "lblEnter";
            lblEnter.Size = new Size(52, 25);
            lblEnter.TabIndex = 0;
            lblEnter.Text = "Enter";
            lblEnter.Click += lblEnter_Click;
            // 
            // grpboxGrs
            // 
            grpboxGrs.BackColor = SystemColors.Highlight;
            grpboxGrs.Controls.Add(grpboxPas);
            grpboxGrs.Location = new Point(-2, 7);
            grpboxGrs.Name = "grpboxGrs";
            grpboxGrs.Size = new Size(1337, 721);
            grpboxGrs.TabIndex = 6;
            grpboxGrs.TabStop = false;
            grpboxGrs.Text = "Video Admin";
            grpboxGrs.Enter += grpboxGrs_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 733);
            Controls.Add(grpboxGrs);
            Name = "Form1";
            Text = "Login Page";
            grpboxPas.ResumeLayout(false);
            grpboxPas.PerformLayout();
            grpboxGrs.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpboxPas;
        private Label lblPassword;
        private Label lblUserName;
        private Label lblEnter;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private GroupBox grpboxGrs;
    }
}
