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
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.messagesList = new System.Windows.Forms.ListBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsers = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.Location = new System.Drawing.Point(78, 10);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(483, 20);
            this.addressTextBox.TabIndex = 0;
            this.addressTextBox.Enter += new System.EventHandler(this.addressTextBox_Enter);
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectButton.Location = new System.Drawing.Point(593, 8);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address:";
            // 
            // messagesList
            // 
            this.messagesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagesList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.messagesList.FormattingEnabled = true;
            this.messagesList.Location = new System.Drawing.Point(15, 127);
            this.messagesList.Name = "messagesList";
            this.messagesList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.messagesList.Size = new System.Drawing.Size(734, 394);
            this.messagesList.TabIndex = 3;
            this.messagesList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.messagesList_DrawItem);
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(674, 532);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.Enabled = false;
            this.messageTextBox.Location = new System.Drawing.Point(15, 534);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(653, 20);
            this.messageTextBox.TabIndex = 4;
            this.messageTextBox.Enter += new System.EventHandler(this.messageTextBox_Enter);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(674, 8);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 6;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Users:";
            // 
            // txtUsers
            // 
            this.txtUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsers.Location = new System.Drawing.Point(78, 39);
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(483, 20);
            this.txtUsers.TabIndex = 7;
            this.txtUsers.Text = "mhor.fibo7@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(78, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(483, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "Mhor.fibo7";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(593, 42);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 46);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(674, 42);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 46);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 566);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsers);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.messagesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.addressTextBox);
            this.Name = "ChatForm";
            this.Text = "SignalR Chat Sample";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox messagesList;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
    }
}

