namespace Assignment4
{
    partial class TransactionForm
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
            cmbAccount = new ComboBox();
            label3 = new Label();
            btncreate = new Button();
            txtCreateDescription = new TextBox();
            txtAmout = new TextBox();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // cmbAccount
            // 
            cmbAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccount.FormattingEnabled = true;
            cmbAccount.Location = new Point(96, 59);
            cmbAccount.Name = "cmbAccount";
            cmbAccount.Size = new Size(161, 25);
            cmbAccount.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 63);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 16;
            label3.Text = "Account:";
            // 
            // btncreate
            // 
            btncreate.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btncreate.Location = new Point(22, 268);
            btncreate.Name = "btncreate";
            btncreate.Size = new Size(75, 23);
            btncreate.TabIndex = 15;
            btncreate.Text = "Save";
            btncreate.UseVisualStyleBackColor = true;
            btncreate.Click += btncreate_Click;
            // 
            // txtCreateDescription
            // 
            txtCreateDescription.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCreateDescription.Location = new Point(22, 123);
            txtCreateDescription.Multiline = true;
            txtCreateDescription.Name = "txtCreateDescription";
            txtCreateDescription.Size = new Size(235, 114);
            txtCreateDescription.TabIndex = 14;
            // 
            // txtAmout
            // 
            txtAmout.Location = new Point(96, 26);
            txtAmout.Name = "txtAmout";
            txtAmout.Size = new Size(161, 23);
            txtAmout.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 100);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 12;
            label6.Text = "Description: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 29);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 11;
            label5.Text = "Amout: ";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(182, 268);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 344);
            Controls.Add(button1);
            Controls.Add(cmbAccount);
            Controls.Add(label3);
            Controls.Add(btncreate);
            Controls.Add(txtCreateDescription);
            Controls.Add(txtAmout);
            Controls.Add(label6);
            Controls.Add(label5);
            Name = "TransactionForm";
            Text = "Create TransactionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAccount;
        private Label label3;
        private Button btncreate;
        private TextBox txtCreateDescription;
        private TextBox txtAmout;
        private Label label6;
        private Label label5;
        private Button button1;
    }
}