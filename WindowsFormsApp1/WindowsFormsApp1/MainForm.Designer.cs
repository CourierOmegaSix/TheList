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
            this.signInButton.Location = new System.Drawing.Point(40, 176);
            this.signInButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(104, 48);
            this.signInButton.TabIndex = 0;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // joinButton
            // 
            this.joinButton.Location = new System.Drawing.Point(184, 176);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(88, 48);
            this.joinButton.TabIndex = 1;
            this.joinButton.Text = "Join";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // usrName
            // 
            this.usrName.Location = new System.Drawing.Point(168, 48);
            this.usrName.Name = "usrName";
            this.usrName.Size = new System.Drawing.Size(136, 30);
            this.usrName.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(168, 88);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(136, 30);
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
            this.infoGroup.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoGroup.ForeColor = System.Drawing.Color.Black;
            this.infoGroup.Location = new System.Drawing.Point(56, 56);
            this.infoGroup.Name = "infoGroup";
            this.infoGroup.Size = new System.Drawing.Size(320, 280);
            this.infoGroup.TabIndex = 4;
            this.infoGroup.TabStop = false;
            this.infoGroup.Text = "User Info";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(32, 96);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(120, 32);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Location = new System.Drawing.Point(32, 48);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(120, 32);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username:";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.spiralBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 414);
            this.Controls.Add(this.infoGroup);
            this.HelpButton = true;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "userInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Budget List";
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

