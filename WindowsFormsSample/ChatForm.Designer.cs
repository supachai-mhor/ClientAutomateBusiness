namespace WindowsFormsSample
{
    partial class ChatForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.txtAddressHubs = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.messagesList = new System.Windows.Forms.ListBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminUsers = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOEEvalue = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtQtyYield = new System.Windows.Forms.TextBox();
            this.btnQtyPass = new System.Windows.Forms.TextBox();
            this.txtQtyInput = new System.Windows.Forms.TextBox();
            this.txtQtyExpect = new System.Windows.Forms.TextBox();
            this.txtQtyPlan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSettingTimes = new System.Windows.Forms.TextBox();
            this.txtIdleTimes = new System.Windows.Forms.TextBox();
            this.txtDownTimes = new System.Windows.Forms.TextBox();
            this.txtRunningTimes = new System.Windows.Forms.TextBox();
            this.txtSupervisorName = new System.Windows.Forms.TextBox();
            this.txtOperatorName = new System.Windows.Forms.TextBox();
            this.txtJobNo = new System.Windows.Forms.TextBox();
            this.txtMachineName = new System.Windows.Forms.TextBox();
            this.btnTrial = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.PanelAlertMessage = new System.Windows.Forms.Panel();
            this.lbAlertMessage = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbErrorReason = new System.Windows.Forms.ComboBox();
            this.btnSubmitError = new System.Windows.Forms.Button();
            this.btnMachineError = new System.Windows.Forms.Button();
            this.btnNGPart = new System.Windows.Forms.Button();
            this.btnOKPart = new System.Windows.Forms.Button();
            this.btnInputPart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.btnResetConfig = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.RuningTimer = new System.Windows.Forms.Timer(this.components);
            this.DowntimeTimer = new System.Windows.Forms.Timer(this.components);
            this.SettingTimer = new System.Windows.Forms.Timer(this.components);
            this.IdleTimer = new System.Windows.Forms.Timer(this.components);
            this.currentTimer = new System.Windows.Forms.Timer(this.components);
            this.updateChartTimer = new System.Windows.Forms.Timer(this.components);
            this.numNGqty = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.PanelAlertMessage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNGqty)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddressHubs
            // 
            this.txtAddressHubs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddressHubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtAddressHubs.Location = new System.Drawing.Point(96, 6);
            this.txtAddressHubs.Name = "txtAddressHubs";
            this.txtAddressHubs.ReadOnly = true;
            this.txtAddressHubs.Size = new System.Drawing.Size(310, 23);
            this.txtAddressHubs.TabIndex = 0;
            this.txtAddressHubs.Enter += new System.EventHandler(this.addressTextBox_Enter);
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.connectButton.ForeColor = System.Drawing.Color.Black;
            this.connectButton.Location = new System.Drawing.Point(223, 132);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(86, 33);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address:";
            // 
            // messagesList
            // 
            this.messagesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagesList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.messagesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.messagesList.FormattingEnabled = true;
            this.messagesList.Location = new System.Drawing.Point(29, 216);
            this.messagesList.Name = "messagesList";
            this.messagesList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.messagesList.Size = new System.Drawing.Size(378, 316);
            this.messagesList.TabIndex = 3;
            this.messagesList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.messagesList_DrawItem);
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Enabled = false;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.sendButton.Location = new System.Drawing.Point(29, 567);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(378, 36);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "SEND DATA";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.Enabled = false;
            this.messageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.messageTextBox.Location = new System.Drawing.Point(29, 538);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(378, 23);
            this.messageTextBox.TabIndex = 4;
            this.messageTextBox.Enter += new System.EventHandler(this.messageTextBox_Enter);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.disconnectButton.ForeColor = System.Drawing.Color.Black;
            this.disconnectButton.Location = new System.Drawing.Point(320, 132);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(86, 33);
            this.disconnectButton.TabIndex = 6;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(1, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "AdminUser:";
            // 
            // txtAdminUsers
            // 
            this.txtAdminUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdminUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtAdminUsers.Location = new System.Drawing.Point(96, 34);
            this.txtAdminUsers.Name = "txtAdminUsers";
            this.txtAdminUsers.ReadOnly = true;
            this.txtAdminUsers.Size = new System.Drawing.Size(310, 23);
            this.txtAdminUsers.TabIndex = 7;
            this.txtAdminUsers.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtPassword.Location = new System.Drawing.Point(96, 62);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(310, 23);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(29, 132);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 33);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(126, 132);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(86, 33);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Company:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtCompanyName.Location = new System.Drawing.Point(96, 90);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(310, 23);
            this.txtCompanyName.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.txtOEEvalue);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.txtQtyYield);
            this.panel1.Controls.Add(this.btnQtyPass);
            this.panel1.Controls.Add(this.txtQtyInput);
            this.panel1.Controls.Add(this.txtQtyExpect);
            this.panel1.Controls.Add(this.txtQtyPlan);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.PanelAlertMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 700);
            this.panel1.TabIndex = 16;
            // 
            // txtOEEvalue
            // 
            this.txtOEEvalue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtOEEvalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOEEvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtOEEvalue.ForeColor = System.Drawing.Color.White;
            this.txtOEEvalue.Location = new System.Drawing.Point(270, 563);
            this.txtOEEvalue.Name = "txtOEEvalue";
            this.txtOEEvalue.ReadOnly = true;
            this.txtOEEvalue.Size = new System.Drawing.Size(166, 53);
            this.txtOEEvalue.TabIndex = 21;
            this.txtOEEvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(16, 565);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(125, 54);
            this.label25.TabIndex = 20;
            this.label25.Text = "OEE";
            // 
            // txtQtyYield
            // 
            this.txtQtyYield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtQtyYield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtyYield.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtQtyYield.ForeColor = System.Drawing.Color.White;
            this.txtQtyYield.Location = new System.Drawing.Point(270, 483);
            this.txtQtyYield.Name = "txtQtyYield";
            this.txtQtyYield.ReadOnly = true;
            this.txtQtyYield.Size = new System.Drawing.Size(166, 53);
            this.txtQtyYield.TabIndex = 19;
            this.txtQtyYield.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnQtyPass
            // 
            this.btnQtyPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnQtyPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.btnQtyPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnQtyPass.ForeColor = System.Drawing.Color.White;
            this.btnQtyPass.Location = new System.Drawing.Point(270, 403);
            this.btnQtyPass.Name = "btnQtyPass";
            this.btnQtyPass.ReadOnly = true;
            this.btnQtyPass.Size = new System.Drawing.Size(166, 53);
            this.btnQtyPass.TabIndex = 18;
            this.btnQtyPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQtyInput
            // 
            this.txtQtyInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtQtyInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtQtyInput.ForeColor = System.Drawing.Color.White;
            this.txtQtyInput.Location = new System.Drawing.Point(270, 323);
            this.txtQtyInput.Name = "txtQtyInput";
            this.txtQtyInput.ReadOnly = true;
            this.txtQtyInput.Size = new System.Drawing.Size(166, 53);
            this.txtQtyInput.TabIndex = 17;
            this.txtQtyInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQtyExpect
            // 
            this.txtQtyExpect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtQtyExpect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtyExpect.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtQtyExpect.ForeColor = System.Drawing.Color.White;
            this.txtQtyExpect.Location = new System.Drawing.Point(270, 243);
            this.txtQtyExpect.Name = "txtQtyExpect";
            this.txtQtyExpect.ReadOnly = true;
            this.txtQtyExpect.Size = new System.Drawing.Size(166, 53);
            this.txtQtyExpect.TabIndex = 16;
            this.txtQtyExpect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQtyPlan
            // 
            this.txtQtyPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtQtyPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtyPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtQtyPlan.ForeColor = System.Drawing.Color.White;
            this.txtQtyPlan.Location = new System.Drawing.Point(270, 163);
            this.txtQtyPlan.Name = "txtQtyPlan";
            this.txtQtyPlan.ReadOnly = true;
            this.txtQtyPlan.Size = new System.Drawing.Size(166, 53);
            this.txtQtyPlan.TabIndex = 15;
            this.txtQtyPlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEndTime);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtStartTime);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSettingTimes);
            this.groupBox1.Controls.Add(this.txtIdleTimes);
            this.groupBox1.Controls.Add(this.txtDownTimes);
            this.groupBox1.Controls.Add(this.txtRunningTimes);
            this.groupBox1.Controls.Add(this.txtSupervisorName);
            this.groupBox1.Controls.Add(this.txtOperatorName);
            this.groupBox1.Controls.Add(this.txtJobNo);
            this.groupBox1.Controls.Add(this.txtMachineName);
            this.groupBox1.Controls.Add(this.btnTrial);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(467, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 465);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // txtEndTime
            // 
            this.txtEndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtEndTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtEndTime.ForeColor = System.Drawing.Color.Yellow;
            this.txtEndTime.Location = new System.Drawing.Point(132, 383);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(198, 19);
            this.txtEndTime.TabIndex = 36;
            this.txtEndTime.Text = "00h:00m:00s";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label24.ForeColor = System.Drawing.Color.Yellow;
            this.label24.Location = new System.Drawing.Point(22, 383);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 18);
            this.label24.TabIndex = 35;
            this.label24.Text = "END";
            // 
            // txtStartTime
            // 
            this.txtStartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtStartTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtStartTime.ForeColor = System.Drawing.Color.Cyan;
            this.txtStartTime.Location = new System.Drawing.Point(132, 358);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(198, 19);
            this.txtStartTime.TabIndex = 34;
            this.txtStartTime.Text = "08h:00m:00s";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label22.ForeColor = System.Drawing.Color.Cyan;
            this.label22.Location = new System.Drawing.Point(22, 358);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 18);
            this.label22.TabIndex = 33;
            this.label22.Text = "START";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "----------------------------------------------";
            // 
            // txtSettingTimes
            // 
            this.txtSettingTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtSettingTimes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSettingTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSettingTimes.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtSettingTimes.Location = new System.Drawing.Point(132, 236);
            this.txtSettingTimes.Name = "txtSettingTimes";
            this.txtSettingTimes.ReadOnly = true;
            this.txtSettingTimes.Size = new System.Drawing.Size(198, 19);
            this.txtSettingTimes.TabIndex = 31;
            this.txtSettingTimes.Text = "00h:00m:00s";
            // 
            // txtIdleTimes
            // 
            this.txtIdleTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtIdleTimes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdleTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtIdleTimes.ForeColor = System.Drawing.Color.Chocolate;
            this.txtIdleTimes.Location = new System.Drawing.Point(132, 208);
            this.txtIdleTimes.Name = "txtIdleTimes";
            this.txtIdleTimes.ReadOnly = true;
            this.txtIdleTimes.Size = new System.Drawing.Size(198, 19);
            this.txtIdleTimes.TabIndex = 30;
            this.txtIdleTimes.Text = "00h:00m:00s";
            // 
            // txtDownTimes
            // 
            this.txtDownTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtDownTimes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDownTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDownTimes.ForeColor = System.Drawing.Color.DarkRed;
            this.txtDownTimes.Location = new System.Drawing.Point(132, 180);
            this.txtDownTimes.Name = "txtDownTimes";
            this.txtDownTimes.ReadOnly = true;
            this.txtDownTimes.Size = new System.Drawing.Size(198, 19);
            this.txtDownTimes.TabIndex = 29;
            this.txtDownTimes.Text = "00h:00m:00s";
            // 
            // txtRunningTimes
            // 
            this.txtRunningTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtRunningTimes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRunningTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtRunningTimes.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtRunningTimes.Location = new System.Drawing.Point(132, 152);
            this.txtRunningTimes.Name = "txtRunningTimes";
            this.txtRunningTimes.ReadOnly = true;
            this.txtRunningTimes.Size = new System.Drawing.Size(198, 19);
            this.txtRunningTimes.TabIndex = 28;
            this.txtRunningTimes.Text = "00h:00m:00s";
            // 
            // txtSupervisorName
            // 
            this.txtSupervisorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtSupervisorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupervisorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSupervisorName.ForeColor = System.Drawing.Color.White;
            this.txtSupervisorName.Location = new System.Drawing.Point(132, 112);
            this.txtSupervisorName.Name = "txtSupervisorName";
            this.txtSupervisorName.ReadOnly = true;
            this.txtSupervisorName.Size = new System.Drawing.Size(198, 16);
            this.txtSupervisorName.TabIndex = 27;
            this.txtSupervisorName.Text = "Supachai Chaisongkhram";
            // 
            // txtOperatorName
            // 
            this.txtOperatorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtOperatorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOperatorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtOperatorName.ForeColor = System.Drawing.Color.White;
            this.txtOperatorName.Location = new System.Drawing.Point(132, 88);
            this.txtOperatorName.Name = "txtOperatorName";
            this.txtOperatorName.Size = new System.Drawing.Size(198, 16);
            this.txtOperatorName.TabIndex = 26;
            this.txtOperatorName.Text = "Kittiya Sumala";
            // 
            // txtJobNo
            // 
            this.txtJobNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtJobNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJobNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtJobNo.ForeColor = System.Drawing.Color.White;
            this.txtJobNo.Location = new System.Drawing.Point(132, 62);
            this.txtJobNo.Name = "txtJobNo";
            this.txtJobNo.ReadOnly = true;
            this.txtJobNo.Size = new System.Drawing.Size(198, 19);
            this.txtJobNo.TabIndex = 25;
            // 
            // txtMachineName
            // 
            this.txtMachineName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtMachineName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtMachineName.ForeColor = System.Drawing.Color.White;
            this.txtMachineName.Location = new System.Drawing.Point(132, 37);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.ReadOnly = true;
            this.txtMachineName.Size = new System.Drawing.Size(198, 19);
            this.txtMachineName.TabIndex = 24;
            this.txtMachineName.Text = "ME-001-2993";
            // 
            // btnTrial
            // 
            this.btnTrial.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnTrial.Location = new System.Drawing.Point(226, 417);
            this.btnTrial.Name = "btnTrial";
            this.btnTrial.Size = new System.Drawing.Size(81, 34);
            this.btnTrial.TabIndex = 23;
            this.btnTrial.Text = "TRIAL";
            this.btnTrial.UseVisualStyleBackColor = false;
            this.btnTrial.Click += new System.EventHandler(this.btnTrial_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Crimson;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnStop.Location = new System.Drawing.Point(123, 417);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(81, 34);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnStart.Location = new System.Drawing.Point(20, 417);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 34);
            this.btnStart.TabIndex = 21;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.White;
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtBarcode.ForeColor = System.Drawing.Color.DarkRed;
            this.txtBarcode.Location = new System.Drawing.Point(19, 279);
            this.txtBarcode.Multiline = true;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(288, 53);
            this.txtBarcode.TabIndex = 20;
            this.txtBarcode.Text = "Scan Barcode";
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBarcode_MouseClick);
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(22, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(285, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "----------------------------------------------";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label14.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label14.Location = new System.Drawing.Point(22, 236);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 18);
            this.label14.TabIndex = 13;
            this.label14.Text = "SETTING";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label13.ForeColor = System.Drawing.Color.Chocolate;
            this.label13.Location = new System.Drawing.Point(22, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "IDLE TIME";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(22, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "DOWNTIME";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.ForeColor = System.Drawing.Color.ForestGreen;
            this.label11.Location = new System.Drawing.Point(22, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "RUNNING";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(22, 132);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(285, 20);
            this.label20.TabIndex = 9;
            this.label20.Text = "----------------------------------------------";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(18, 108);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 18);
            this.label19.TabIndex = 8;
            this.label19.Text = "Supervisor:";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(18, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 18);
            this.label18.TabIndex = 7;
            this.label18.Text = "Operator:";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(18, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "Job Number:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(18, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "Machine:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 484);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 54);
            this.label10.TabIndex = 8;
            this.label10.Text = "YIELD";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 54);
            this.label9.TabIndex = 7;
            this.label9.Text = "PASS";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 54);
            this.label8.TabIndex = 6;
            this.label8.Text = "INPUT";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 54);
            this.label7.TabIndex = 5;
            this.label7.Text = "EXPECT";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 54);
            this.label6.TabIndex = 4;
            this.label6.Text = "PLAN";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtMessage);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 654);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(810, 46);
            this.panel5.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtMessage.ForeColor = System.Drawing.Color.Tomato;
            this.txtMessage.Location = new System.Drawing.Point(120, 13);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(674, 19);
            this.txtMessage.TabIndex = 26;
            this.txtMessage.Text = "Please key or scan job barcode before start process";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label23.ForeColor = System.Drawing.Color.Gold;
            this.label23.Location = new System.Drawing.Point(12, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(102, 20);
            this.label23.TabIndex = 25;
            this.label23.Text = "MESSAGE:";
            // 
            // PanelAlertMessage
            // 
            this.PanelAlertMessage.BackColor = System.Drawing.Color.DarkOrange;
            this.PanelAlertMessage.Controls.Add(this.lbAlertMessage);
            this.PanelAlertMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelAlertMessage.Location = new System.Drawing.Point(0, 0);
            this.PanelAlertMessage.Name = "PanelAlertMessage";
            this.PanelAlertMessage.Size = new System.Drawing.Size(810, 111);
            this.PanelAlertMessage.TabIndex = 0;
            // 
            // lbAlertMessage
            // 
            this.lbAlertMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAlertMessage.AutoSize = true;
            this.lbAlertMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbAlertMessage.ForeColor = System.Drawing.Color.White;
            this.lbAlertMessage.Location = new System.Drawing.Point(281, 21);
            this.lbAlertMessage.Name = "lbAlertMessage";
            this.lbAlertMessage.Size = new System.Drawing.Size(265, 63);
            this.lbAlertMessage.TabIndex = 0;
            this.lbAlertMessage.Text = "WAITING";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabControl1.Location = new System.Drawing.Point(816, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(437, 700);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.btnExit);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.ForeColor = System.Drawing.Color.Blue;
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(429, 662);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chart";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnExit.Location = new System.Drawing.Point(301, 629);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 25);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numNGqty);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.cmbErrorReason);
            this.groupBox2.Controls.Add(this.btnSubmitError);
            this.groupBox2.Controls.Add(this.btnMachineError);
            this.groupBox2.Controls.Add(this.btnNGPart);
            this.groupBox2.Controls.Add(this.btnOKPart);
            this.groupBox2.Controls.Add(this.btnInputPart);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 225);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Machine Event";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(220, 132);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(181, 25);
            this.label21.TabIndex = 28;
            this.label21.Text = "ERROR REASON";
            // 
            // cmbErrorReason
            // 
            this.cmbErrorReason.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmbErrorReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cmbErrorReason.ForeColor = System.Drawing.Color.Maroon;
            this.cmbErrorReason.FormattingEnabled = true;
            this.cmbErrorReason.Items.AddRange(new object[] {
            "Equipment Error",
            "Tool Error",
            "Program Error",
            "SetupAndAdjustment Error",
            "Material Error",
            "Human Error",
            "Other Error"});
            this.cmbErrorReason.Location = new System.Drawing.Point(219, 177);
            this.cmbErrorReason.Name = "cmbErrorReason";
            this.cmbErrorReason.Size = new System.Drawing.Size(186, 32);
            this.cmbErrorReason.TabIndex = 27;
            this.cmbErrorReason.Text = "Equipment Error";
            // 
            // btnSubmitError
            // 
            this.btnSubmitError.BackColor = System.Drawing.Color.Chocolate;
            this.btnSubmitError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSubmitError.Location = new System.Drawing.Point(21, 177);
            this.btnSubmitError.Name = "btnSubmitError";
            this.btnSubmitError.Size = new System.Drawing.Size(186, 33);
            this.btnSubmitError.TabIndex = 26;
            this.btnSubmitError.Text = "SUBMIT ERROR";
            this.btnSubmitError.UseVisualStyleBackColor = false;
            this.btnSubmitError.Click += new System.EventHandler(this.btnSubmitError_Click);
            // 
            // btnMachineError
            // 
            this.btnMachineError.BackColor = System.Drawing.Color.Red;
            this.btnMachineError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnMachineError.Location = new System.Drawing.Point(21, 125);
            this.btnMachineError.Name = "btnMachineError";
            this.btnMachineError.Size = new System.Drawing.Size(186, 42);
            this.btnMachineError.TabIndex = 25;
            this.btnMachineError.Text = "MACHINE ERROR";
            this.btnMachineError.UseVisualStyleBackColor = false;
            this.btnMachineError.Click += new System.EventHandler(this.btnMachineError_Click);
            // 
            // btnNGPart
            // 
            this.btnNGPart.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNGPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnNGPart.Location = new System.Drawing.Point(240, 42);
            this.btnNGPart.Name = "btnNGPart";
            this.btnNGPart.Size = new System.Drawing.Size(87, 42);
            this.btnNGPart.TabIndex = 24;
            this.btnNGPart.Text = "NG";
            this.btnNGPart.UseVisualStyleBackColor = false;
            this.btnNGPart.Click += new System.EventHandler(this.btnNGPart_Click);
            // 
            // btnOKPart
            // 
            this.btnOKPart.BackColor = System.Drawing.Color.Lime;
            this.btnOKPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnOKPart.Location = new System.Drawing.Point(130, 42);
            this.btnOKPart.Name = "btnOKPart";
            this.btnOKPart.Size = new System.Drawing.Size(87, 42);
            this.btnOKPart.TabIndex = 23;
            this.btnOKPart.Text = "OK";
            this.btnOKPart.UseVisualStyleBackColor = false;
            this.btnOKPart.Click += new System.EventHandler(this.btnOKPart_Click);
            // 
            // btnInputPart
            // 
            this.btnInputPart.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInputPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnInputPart.Location = new System.Drawing.Point(21, 42);
            this.btnInputPart.Name = "btnInputPart";
            this.btnInputPart.Size = new System.Drawing.Size(87, 42);
            this.btnInputPart.TabIndex = 21;
            this.btnInputPart.Text = "IN";
            this.btnInputPart.UseVisualStyleBackColor = false;
            this.btnInputPart.Click += new System.EventHandler(this.btnInputPart_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Black;
            this.chart1.BorderlineColor = System.Drawing.Color.Empty;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 38);
            this.chart1.Name = "chart1";
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.Black;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.Empty;
            series1.LabelToolTip = "#VAL{P}";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(405, 362);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.BackColor = System.Drawing.Color.Black;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.DarkOrange;
            title1.Name = "title";
            title1.Text = "      Overall Timeline Chart";
            this.chart1.Titles.Add(title1);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.OrangeRed;
            this.tabPage1.Controls.Add(this.dtEndTime);
            this.tabPage1.Controls.Add(this.dtStartTime);
            this.tabPage1.Controls.Add(this.btnResetConfig);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.btnSaveConfig);
            this.tabPage1.Controls.Add(this.messagesList);
            this.tabPage1.Controls.Add(this.messageTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtCompanyName);
            this.tabPage1.Controls.Add(this.sendButton);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.btnLogout);
            this.tabPage1.Controls.Add(this.txtAddressHubs);
            this.tabPage1.Controls.Add(this.btnLogin);
            this.tabPage1.Controls.Add(this.connectButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.disconnectButton);
            this.tabPage1.Controls.Add(this.txtAdminUsers);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.ForeColor = System.Drawing.Color.Blue;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(429, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Config";
            // 
            // dtEndTime
            // 
            this.dtEndTime.CustomFormat = "HH:mm:ss";
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndTime.Location = new System.Drawing.Point(303, 171);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.ShowUpDown = true;
            this.dtEndTime.Size = new System.Drawing.Size(103, 30);
            this.dtEndTime.TabIndex = 54;
            this.dtEndTime.Value = new System.DateTime(2020, 2, 2, 0, 0, 0, 0);
            // 
            // dtStartTime
            // 
            this.dtStartTime.CustomFormat = "HH:mm:ss";
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.Location = new System.Drawing.Point(122, 171);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.ShowUpDown = true;
            this.dtStartTime.Size = new System.Drawing.Size(103, 30);
            this.dtStartTime.TabIndex = 53;
            this.dtStartTime.Value = new System.DateTime(2020, 2, 2, 8, 0, 0, 0);
            // 
            // btnResetConfig
            // 
            this.btnResetConfig.BackColor = System.Drawing.Color.Silver;
            this.btnResetConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnResetConfig.ForeColor = System.Drawing.Color.Black;
            this.btnResetConfig.Location = new System.Drawing.Point(264, 615);
            this.btnResetConfig.Name = "btnResetConfig";
            this.btnResetConfig.Size = new System.Drawing.Size(142, 36);
            this.btnResetConfig.TabIndex = 27;
            this.btnResetConfig.Text = "Reset Config";
            this.btnResetConfig.UseVisualStyleBackColor = false;
            this.btnResetConfig.Click += new System.EventHandler(this.btnResetConfig_Click);
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label27.ForeColor = System.Drawing.Color.Yellow;
            this.label27.Location = new System.Drawing.Point(236, 174);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 25);
            this.label27.TabIndex = 40;
            this.label27.Text = "END";
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label26.ForeColor = System.Drawing.Color.Cyan;
            this.label26.Location = new System.Drawing.Point(27, 174);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 25);
            this.label26.TabIndex = 39;
            this.label26.Text = "START";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.BackColor = System.Drawing.Color.Violet;
            this.btnSaveConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSaveConfig.ForeColor = System.Drawing.Color.Black;
            this.btnSaveConfig.Location = new System.Drawing.Point(32, 615);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(142, 36);
            this.btnSaveConfig.TabIndex = 26;
            this.btnSaveConfig.Text = "SAVE Config";
            this.btnSaveConfig.UseVisualStyleBackColor = false;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // RuningTimer
            // 
            this.RuningTimer.Interval = 500;
            this.RuningTimer.Tick += new System.EventHandler(this.RunningTimer_Tick);
            // 
            // DowntimeTimer
            // 
            this.DowntimeTimer.Interval = 500;
            this.DowntimeTimer.Tick += new System.EventHandler(this.DowntimeTimer_Tick);
            // 
            // SettingTimer
            // 
            this.SettingTimer.Interval = 500;
            this.SettingTimer.Tick += new System.EventHandler(this.SettingTimer_Tick);
            // 
            // IdleTimer
            // 
            this.IdleTimer.Interval = 500;
            this.IdleTimer.Tick += new System.EventHandler(this.IdleTimer_Tick);
            // 
            // currentTimer
            // 
            this.currentTimer.Interval = 1000;
            this.currentTimer.Tick += new System.EventHandler(this.currentTimer_Tick);
            // 
            // updateChartTimer
            // 
            this.updateChartTimer.Interval = 500;
            this.updateChartTimer.Tick += new System.EventHandler(this.updateChartTimer_Tick);
            // 
            // numNGqty
            // 
            this.numNGqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.numNGqty.Location = new System.Drawing.Point(345, 47);
            this.numNGqty.Name = "numNGqty";
            this.numNGqty.Size = new System.Drawing.Size(56, 32);
            this.numNGqty.TabIndex = 30;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1253, 700);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignalR Chat Sample";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.PanelAlertMessage.ResumeLayout(false);
            this.PanelAlertMessage.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNGqty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddressHubs;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox messagesList;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel PanelAlertMessage;
        private System.Windows.Forms.Label lbAlertMessage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtQtyYield;
        private System.Windows.Forms.TextBox btnQtyPass;
        private System.Windows.Forms.TextBox txtQtyInput;
        private System.Windows.Forms.TextBox txtQtyExpect;
        private System.Windows.Forms.TextBox txtQtyPlan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnTrial;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtSettingTimes;
        private System.Windows.Forms.TextBox txtIdleTimes;
        private System.Windows.Forms.TextBox txtDownTimes;
        private System.Windows.Forms.TextBox txtRunningTimes;
        private System.Windows.Forms.TextBox txtSupervisorName;
        private System.Windows.Forms.TextBox txtOperatorName;
        private System.Windows.Forms.TextBox txtJobNo;
        private System.Windows.Forms.TextBox txtMachineName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSubmitError;
        private System.Windows.Forms.Button btnMachineError;
        private System.Windows.Forms.Button btnNGPart;
        private System.Windows.Forms.Button btnOKPart;
        private System.Windows.Forms.Button btnInputPart;
        private System.Windows.Forms.ComboBox cmbErrorReason;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Timer RuningTimer;
        private System.Windows.Forms.Timer DowntimeTimer;
        private System.Windows.Forms.Timer SettingTimer;
        private System.Windows.Forms.Timer IdleTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Timer currentTimer;
        private System.Windows.Forms.TextBox txtOEEvalue;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Timer updateChartTimer;
        private System.Windows.Forms.Button btnResetConfig;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.NumericUpDown numNGqty;
    }
}

