namespace WindowsFormsApp1
{
    partial class userInfo
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
            this.signInButton = new System.Windows.Forms.Button();
            this.joinButton = new System.Windows.Forms.Button();
            this.usrName = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.infoGroup = new System.Windows.Forms.GroupBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.infoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(21, 94);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(48, 21);
            this.signInButton.TabIndex = 0;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // joinButton
            // 
            this.joinButton.Location = new System.Drawing.Point(91, 94);
            this.joinButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(53, 21);
            this.joinButton.TabIndex = 1;
            this.joinButton.Text = "Join";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // usrName
            // 
            this.usrName.Location = new System.Drawing.Point(69, 26);
            this.usrName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usrName.Name = "usrName";
            this.usrName.Size = new System.Drawing.Size(68, 20);
            this.usrName.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(69, 57);
            this.pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(68, 20);
            this.pass.TabIndex = 3;
            // 
            // infoGroup
            // 
            this.infoGroup.BackColor = System.Drawing.Color.Transparent;
            this.infoGroup.Controls.Add(this.passwordLabel);
            this.infoGroup.Controls.Add(this.usernameLabel);
            this.infoGroup.Controls.Add(this.usrName);
            this.infoGroup.Controls.Add(this.signInButton);
            this.infoGroup.Controls.Add(this.joinButton);
            this.infoGroup.Controls.Add(this.pass);
            this.infoGroup.ForeColor = System.Drawing.Color.Black;
            this.infoGroup.Location = new System.Drawing.Point(37, 36);
            this.infoGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infoGroup.Name = "infoGroup";
            this.infoGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infoGroup.Size = new System.Drawing.Size(176, 151);
            this.infoGroup.TabIndex = 4;
            this.infoGroup.TabStop = false;
            this.infoGroup.Text = "Info";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(11, 62);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(11, 31);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // userInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.spiralBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(244, 235);
            this.Controls.Add(this.infoGroup);
            this.HelpButton = true;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "userInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Budget List";
            this.Load += new System.EventHandler(this.userInfo_Load);
            this.infoGroup.ResumeLayout(false);
            this.infoGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.TextBox usrName;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.GroupBox infoGroup;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
    }
}

