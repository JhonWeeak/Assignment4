namespace Assignment4
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnLogin = new Button();
            txtPd = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panelUser = new Panel();
            label3 = new Label();
            btncreate = new Button();
            lstAccountList = new ListBox();
            dataGridView1 = new DataGridView();
            TransactionId = new DataGridViewTextBoxColumn();
            TransactionDate = new DataGridViewTextBoxColumn();
            Amout = new DataGridViewTextBoxColumn();
            AccountType = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Operate = new DataGridViewButtonColumn();
            lblUserName = new Label();
            panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.Name = "btnLogin";
            // 
            // txtPd
            // 
            resources.ApplyResources(txtPd, "txtPd");
            txtPd.Name = "txtPd";
            // 
            // txtEmail
            // 
            resources.ApplyResources(txtEmail, "txtEmail");
            txtEmail.Name = "txtEmail";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // panelUser
            // 
            resources.ApplyResources(panelUser, "panelUser");
            panelUser.Controls.Add(label3);
            panelUser.Controls.Add(btncreate);
            panelUser.Controls.Add(lstAccountList);
            panelUser.Controls.Add(dataGridView1);
            panelUser.Controls.Add(lblUserName);
            panelUser.Name = "panelUser";
            panelUser.Paint += panelUser_Paint;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // btncreate
            // 
            resources.ApplyResources(btncreate, "btncreate");
            btncreate.Name = "btncreate";
            btncreate.UseVisualStyleBackColor = true;
            btncreate.Click += btncreate_Click;
            // 
            // lstAccountList
            // 
            resources.ApplyResources(lstAccountList, "lstAccountList");
            lstAccountList.FormattingEnabled = true;
            lstAccountList.Name = "lstAccountList";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TransactionId, TransactionDate, Amout, AccountType, Description, Operate });
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TransactionId
            // 
            resources.ApplyResources(TransactionId, "TransactionId");
            TransactionId.Name = "TransactionId";
            TransactionId.ReadOnly = true;
            // 
            // TransactionDate
            // 
            resources.ApplyResources(TransactionDate, "TransactionDate");
            TransactionDate.Name = "TransactionDate";
            TransactionDate.ReadOnly = true;
            // 
            // Amout
            // 
            resources.ApplyResources(Amout, "Amout");
            Amout.Name = "Amout";
            Amout.ReadOnly = true;
            // 
            // AccountType
            // 
            resources.ApplyResources(AccountType, "AccountType");
            AccountType.Name = "AccountType";
            AccountType.ReadOnly = true;
            // 
            // Description
            // 
            resources.ApplyResources(Description, "Description");
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // Operate
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.NullValue = "Delete";
            dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = Color.IndianRed;
            Operate.DefaultCellStyle = dataGridViewCellStyle1;
            Operate.FlatStyle = FlatStyle.Flat;
            resources.ApplyResources(Operate, "Operate");
            Operate.Name = "Operate";
            Operate.ReadOnly = true;
            Operate.Resizable = DataGridViewTriState.True;
            Operate.Text = "Delete";
            // 
            // lblUserName
            // 
            resources.ApplyResources(lblUserName, "lblUserName");
            lblUserName.Name = "lblUserName";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelUser);
            Name = "MainForm";
            Load += MainForm_Load;
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox txtPd;
        private TextBox txtEmail;
        private Label label2;
        private Button btnLogin;
        private Panel panelUser;
        private DataGridView dataGridView1;
        private Label lblUserName;
        private ListBox lstAccountList;
        private Button btncreate;
        private Label label3;
        private DataGridViewTextBoxColumn TransactionId;
        private DataGridViewTextBoxColumn TransactionDate;
        private DataGridViewTextBoxColumn Amout;
        private DataGridViewTextBoxColumn AccountType;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewButtonColumn Operate;
    }
}
