namespace postgrepsToSql
{
    partial class MainForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTargetServer = new System.Windows.Forms.TextBox();
            this.textBoxTargetDatabase = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxTargetPort = new System.Windows.Forms.TextBox();
            this.textBoxTargetUserId = new System.Windows.Forms.TextBox();
            this.textBoxTargetPassword = new System.Windows.Forms.TextBox();
            this.comboBoxTarget = new System.Windows.Forms.ComboBox();
            this.labelTargetTableName = new System.Windows.Forms.Label();
            this.textBoxTargetTable = new System.Windows.Forms.TextBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.labelSourceTableName = new System.Windows.Forms.Label();
            this.textBoxSourceTable = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.uiButtonExecute = new Sunny.UI.UIButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Server:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Database:";
            // 
            // textBoxTargetServer
            // 
            this.textBoxTargetServer.Location = new System.Drawing.Point(150, 57);
            this.textBoxTargetServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTargetServer.Name = "textBoxTargetServer";
            this.textBoxTargetServer.Size = new System.Drawing.Size(202, 34);
            this.textBoxTargetServer.TabIndex = 17;
            this.textBoxTargetServer.Text = "localhost";
            // 
            // textBoxTargetDatabase
            // 
            this.textBoxTargetDatabase.Location = new System.Drawing.Point(150, 138);
            this.textBoxTargetDatabase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTargetDatabase.Name = "textBoxTargetDatabase";
            this.textBoxTargetDatabase.Size = new System.Drawing.Size(202, 34);
            this.textBoxTargetDatabase.TabIndex = 18;
            this.textBoxTargetDatabase.Text = "GoodBooksDb";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 27);
            this.label8.TabIndex = 19;
            this.label8.Text = "TARGET:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 105);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 27);
            this.label9.TabIndex = 21;
            this.label9.Text = "Port:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 181);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 27);
            this.label10.TabIndex = 22;
            this.label10.Text = "User Id:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 225);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 27);
            this.label11.TabIndex = 23;
            this.label11.Text = "Password:";
            // 
            // textBoxTargetPort
            // 
            this.textBoxTargetPort.Location = new System.Drawing.Point(150, 98);
            this.textBoxTargetPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTargetPort.Name = "textBoxTargetPort";
            this.textBoxTargetPort.Size = new System.Drawing.Size(202, 34);
            this.textBoxTargetPort.TabIndex = 24;
            // 
            // textBoxTargetUserId
            // 
            this.textBoxTargetUserId.Location = new System.Drawing.Point(150, 178);
            this.textBoxTargetUserId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTargetUserId.Name = "textBoxTargetUserId";
            this.textBoxTargetUserId.Size = new System.Drawing.Size(202, 34);
            this.textBoxTargetUserId.TabIndex = 25;
            // 
            // textBoxTargetPassword
            // 
            this.textBoxTargetPassword.Location = new System.Drawing.Point(150, 218);
            this.textBoxTargetPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTargetPassword.Name = "textBoxTargetPassword";
            this.textBoxTargetPassword.PasswordChar = '*';
            this.textBoxTargetPassword.Size = new System.Drawing.Size(202, 34);
            this.textBoxTargetPassword.TabIndex = 26;
            // 
            // comboBoxTarget
            // 
            this.comboBoxTarget.FormattingEnabled = true;
            this.comboBoxTarget.Items.AddRange(new object[] {
            "PostgreSql",
            "MSSql"});
            this.comboBoxTarget.Location = new System.Drawing.Point(150, 15);
            this.comboBoxTarget.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxTarget.Name = "comboBoxTarget";
            this.comboBoxTarget.Size = new System.Drawing.Size(202, 35);
            this.comboBoxTarget.TabIndex = 28;
            this.comboBoxTarget.SelectedIndexChanged += new System.EventHandler(this.comboBoxTarget_SelectedIndexChanged);
            // 
            // labelTargetTableName
            // 
            this.labelTargetTableName.AutoSize = true;
            this.labelTargetTableName.Location = new System.Drawing.Point(53, 265);
            this.labelTargetTableName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTargetTableName.Name = "labelTargetTableName";
            this.labelTargetTableName.Size = new System.Drawing.Size(68, 27);
            this.labelTargetTableName.TabIndex = 31;
            this.labelTargetTableName.Text = "Table:";
            // 
            // textBoxTargetTable
            // 
            this.textBoxTargetTable.Location = new System.Drawing.Point(150, 258);
            this.textBoxTargetTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTargetTable.Name = "textBoxTargetTable";
            this.textBoxTargetTable.Size = new System.Drawing.Size(202, 34);
            this.textBoxTargetTable.TabIndex = 32;
            this.textBoxTargetTable.Text = "Books";
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(42, 64);
            this.labelServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(78, 27);
            this.labelServer.TabIndex = 0;
            this.labelServer.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Database:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(142, 57);
            this.textBoxServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(167, 34);
            this.textBoxServer.TabIndex = 6;
            this.textBoxServer.Text = "127.0.0.1";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(142, 98);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(167, 34);
            this.textBoxPort.TabIndex = 7;
            this.textBoxPort.Text = "5432";
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(142, 138);
            this.textBoxDatabase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(167, 34);
            this.textBoxDatabase.TabIndex = 8;
            this.textBoxDatabase.Text = "GoodBooksDb";
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(142, 178);
            this.textBoxUserId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(167, 34);
            this.textBoxUserId.TabIndex = 9;
            this.textBoxUserId.Text = "postgres";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(142, 218);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(167, 34);
            this.textBoxPassword.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "SOURCE:";
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Items.AddRange(new object[] {
            "PostgreSql",
            "MSSql"});
            this.comboBoxSource.Location = new System.Drawing.Point(142, 15);
            this.comboBoxSource.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(167, 35);
            this.comboBoxSource.TabIndex = 27;
            this.comboBoxSource.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelSourceTableName
            // 
            this.labelSourceTableName.AutoSize = true;
            this.labelSourceTableName.Location = new System.Drawing.Point(52, 265);
            this.labelSourceTableName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSourceTableName.Name = "labelSourceTableName";
            this.labelSourceTableName.Size = new System.Drawing.Size(68, 27);
            this.labelSourceTableName.TabIndex = 30;
            this.labelSourceTableName.Text = "Table:";
            // 
            // textBoxSourceTable
            // 
            this.textBoxSourceTable.Location = new System.Drawing.Point(142, 258);
            this.textBoxSourceTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSourceTable.Name = "textBoxSourceTable";
            this.textBoxSourceTable.Size = new System.Drawing.Size(167, 34);
            this.textBoxSourceTable.TabIndex = 33;
            this.textBoxSourceTable.Text = "Books";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.textBoxSourceTable);
            this.panel1.Controls.Add(this.labelSourceTableName);
            this.panel1.Controls.Add(this.comboBoxSource);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUserId);
            this.panel1.Controls.Add(this.textBoxDatabase);
            this.panel1.Controls.Add(this.textBoxPort);
            this.panel1.Controls.Add(this.textBoxServer);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelServer);
            this.panel1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Location = new System.Drawing.Point(32, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 333);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.textBoxTargetTable);
            this.panel2.Controls.Add(this.labelTargetTableName);
            this.panel2.Controls.Add(this.comboBoxTarget);
            this.panel2.Controls.Add(this.textBoxTargetPassword);
            this.panel2.Controls.Add(this.textBoxTargetUserId);
            this.panel2.Controls.Add(this.textBoxTargetPort);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxTargetDatabase);
            this.panel2.Controls.Add(this.textBoxTargetServer);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(378, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 333);
            this.panel2.TabIndex = 35;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(32, 390);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(713, 45);
            this.progressBar.TabIndex = 36;
            // 
            // uiButtonExecute
            // 
            this.uiButtonExecute.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButtonExecute.Location = new System.Drawing.Point(378, 457);
            this.uiButtonExecute.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonExecute.Name = "uiButtonExecute";
            this.uiButtonExecute.Size = new System.Drawing.Size(367, 45);
            this.uiButtonExecute.TabIndex = 37;
            this.uiButtonExecute.Text = "执行";
            this.uiButtonExecute.Click += new System.EventHandler(this.uiButtonExecute_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(787, 559);
            this.Controls.Add(this.uiButtonExecute);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "PostgreSql to MsSql";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 571, 418);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTargetServer;
        private System.Windows.Forms.TextBox textBoxTargetDatabase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxTargetPort;
        private System.Windows.Forms.TextBox textBoxTargetUserId;
        private System.Windows.Forms.TextBox textBoxTargetPassword;
        private System.Windows.Forms.ComboBox comboBoxTarget;
        private System.Windows.Forms.Label labelTargetTableName;
        private System.Windows.Forms.TextBox textBoxTargetTable;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.Label labelSourceTableName;
        private System.Windows.Forms.TextBox textBoxSourceTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar;
        private Sunny.UI.UIButton uiButtonExecute;
    }
}

