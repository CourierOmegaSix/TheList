namespace WindowsFormsApp1
{
    partial class UserInfo
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
            this.signInButton.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.Location = new System.Drawing.Point(48, 161);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(69, 36);
            this.signInButton.TabIndex = 0;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // joinButton
            // 
            this.joinButton.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinButton.Location = new System.Drawing.Point(176, 161);
            this.joinButton.Margin = new System.Windows.Forms.Padding(2);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(69, 36);
            this.joinButton.TabIndex = 1;
            this.joinButton.Text = "Join";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // usrName
            // 
            this.usrName.Location = new System.Drawing.Point(139, 42);
            this.usrName.Margin = new System.Windows.Forms.Padding(2);
            this.usrName.Name = "usrName";
            this.usrName.Size = new System.Drawing.Size(113, 20);
            this.usrName.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(139, 94);
            this.pass.Margin = new System.Windows.Forms.Padding(2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(113, 20);
            this.pass.TabIndex = 3;
            this.pass.UseSystemPasswordChar = true;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
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
            this.infoGroup.Location = new System.Drawing.Point(27, 21);
            this.infoGroup.Margin = new System.Windows.Forms.Padding(2);
            this.infoGroup.Name = "infoGroup";
            this.infoGroup.Padding = new System.Windows.Forms.Padding(2);
            this.infoGroup.Size = new System.Drawing.Size(320, 239);
            this.infoGroup.TabIndex = 4;
            this.infoGroup.TabStop = false;
            this.infoGroup.Text = "Info";
            this.infoGroup.Enter += new System.EventHandler(this.infoGroup_Enter);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(37, 94);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(87, 18);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(32, 42);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(92, 18);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.veryLightSpiralBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(377, 286);
            this.Controls.Add(this.infoGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInfo";
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

