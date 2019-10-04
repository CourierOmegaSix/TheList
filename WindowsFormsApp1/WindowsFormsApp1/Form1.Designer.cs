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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.infoGroup = new System.Windows.Forms.GroupBox();
            this.infoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(16, 144);
            this.signInButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(72, 32);
            this.signInButton.TabIndex = 0;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.switchWinForm_Click);
            // 
            // joinButton
            // 
            this.joinButton.Location = new System.Drawing.Point(104, 144);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(80, 32);
            this.joinButton.TabIndex = 1;
            this.joinButton.Text = "Join";
            this.joinButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 3;
            // 
            // infoGroup
            // 
            this.infoGroup.BackColor = System.Drawing.Color.Transparent;
            this.infoGroup.Controls.Add(this.textBox1);
            this.infoGroup.Controls.Add(this.signInButton);
            this.infoGroup.Controls.Add(this.joinButton);
            this.infoGroup.Controls.Add(this.textBox2);
            this.infoGroup.Location = new System.Drawing.Point(80, 56);
            this.infoGroup.Name = "infoGroup";
            this.infoGroup.Size = new System.Drawing.Size(208, 232);
            this.infoGroup.TabIndex = 4;
            this.infoGroup.TabStop = false;
            this.infoGroup.Text = "Info";
            // 
            // userInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.spiralBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 362);
            this.Controls.Add(this.infoGroup);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox infoGroup;
    }
}

