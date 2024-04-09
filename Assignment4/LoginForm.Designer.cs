namespace Assignment4
{
    partial class LoginForm
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
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(168, 147);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 36);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(168, 90);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(183, 28);
            txtPassword.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(168, 44);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 28);
            txtEmail.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(76, 90);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 6;
            label2.Text = "Password: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(111, 47);
            label1.Name = "label1";
            label1.Size = new Size(64, 22);
            label1.TabIndex = 5;
            label1.Text = "Email: ";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 240);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
    }
}