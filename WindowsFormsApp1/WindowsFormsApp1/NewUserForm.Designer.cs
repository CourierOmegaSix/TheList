namespace WindowsFormsApp1
{
    partial class NewUserForm
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
            this.fNameLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.newUserInfoGroup = new System.Windows.Forms.GroupBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.zipcodeBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.zipcodeLabel = new System.Windows.Forms.Label();
            this.dobBox = new System.Windows.Forms.DateTimePicker();
            this.confirmPassBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.confirmPassLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userInstructionLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.newUserInfoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // fNameLabel
            // 
            this.fNameLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.fNameLabel.Location = new System.Drawing.Point(26, 52);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(156, 39);
            this.fNameLabel.TabIndex = 0;
            this.fNameLabel.Text = "First Name:";
            this.fNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lNameLabel
            // 
            this.lNameLabel.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLabel.Location = new System.Drawing.Point(26, 117);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(143, 39);
            this.lNameLabel.TabIndex = 1;
            this.lNameLabel.Text = "Last Name:";
            this.lNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dobLabel
            // 
            this.dobLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(520, 52);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(70, 39);
            this.dobLabel.TabIndex = 2;
            this.dobLabel.Text = "DOB:";
            this.dobLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newUserInfoGroup
            // 
            this.newUserInfoGroup.BackColor = System.Drawing.Color.Transparent;
            this.newUserInfoGroup.Controls.Add(this.addressBox);
            this.newUserInfoGroup.Controls.Add(this.label1);
            this.newUserInfoGroup.Controls.Add(this.resetButton);
            this.newUserInfoGroup.Controls.Add(this.zipcodeBox);
            this.newUserInfoGroup.Controls.Add(this.submitButton);
            this.newUserInfoGroup.Controls.Add(this.zipcodeLabel);
            this.newUserInfoGroup.Controls.Add(this.dobBox);
            this.newUserInfoGroup.Controls.Add(this.confirmPassBox);
            this.newUserInfoGroup.Controls.Add(this.passwordBox);
            this.newUserInfoGroup.Controls.Add(this.usernameBox);
            this.newUserInfoGroup.Controls.Add(this.lNameBox);
            this.newUserInfoGroup.Controls.Add(this.fNameBox);
            this.newUserInfoGroup.Controls.Add(this.confirmPassLabel);
            this.newUserInfoGroup.Controls.Add(this.passwordLabel);
            this.newUserInfoGroup.Controls.Add(this.userNameLabel);
            this.newUserInfoGroup.Controls.Add(this.fNameLabel);
            this.newUserInfoGroup.Controls.Add(this.dobLabel);
            this.newUserInfoGroup.Controls.Add(this.lNameLabel);
            this.newUserInfoGroup.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserInfoGroup.Location = new System.Drawing.Point(90, 150);
            this.newUserInfoGroup.Name = "newUserInfoGroup";
            this.newUserInfoGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newUserInfoGroup.Size = new System.Drawing.Size(780, 470);
            this.newUserInfoGroup.TabIndex = 3;
            this.newUserInfoGroup.TabStop = false;
            this.newUserInfoGroup.Text = "Create Profile";
            this.newUserInfoGroup.Enter += new System.EventHandler(this.newUserInfoGroup_Enter);
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.Location = new System.Drawing.Point(598, 117);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(166, 30);
            this.addressBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "Address:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(481, 377);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 43);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // zipcodeBox
            // 
            this.zipcodeBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipcodeBox.Location = new System.Drawing.Point(598, 182);
            this.zipcodeBox.Name = "zipcodeBox";
            this.zipcodeBox.Size = new System.Drawing.Size(166, 30);
            this.zipcodeBox.TabIndex = 17;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(221, 377);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 43);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // zipcodeLabel
            // 
            this.zipcodeLabel.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipcodeLabel.Location = new System.Drawing.Point(481, 182);
            this.zipcodeLabel.Name = "zipcodeLabel";
            this.zipcodeLabel.Size = new System.Drawing.Size(107, 39);
            this.zipcodeLabel.TabIndex = 16;
            this.zipcodeLabel.Text = "Zipcode:";
            this.zipcodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dobBox
            // 
            this.dobBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobBox.Location = new System.Drawing.Point(598, 52);
            this.dobBox.MaxDate = new System.DateTime(2019, 10, 5, 0, 0, 0, 0);
            this.dobBox.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dobBox.Name = "dobBox";
            this.dobBox.Size = new System.Drawing.Size(140, 30);
            this.dobBox.TabIndex = 12;
            this.dobBox.Value = new System.DateTime(2019, 10, 5, 0, 0, 0, 0);
            this.dobBox.ValueChanged += new System.EventHandler(this.dobBox_ValueChanged);
            // 
            // confirmPassBox
            // 
            this.confirmPassBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassBox.Location = new System.Drawing.Point(598, 247);
            this.confirmPassBox.Name = "confirmPassBox";
            this.confirmPassBox.Size = new System.Drawing.Size(170, 30);
            this.confirmPassBox.TabIndex = 11;
            this.confirmPassBox.UseSystemPasswordChar = true;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(182, 247);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.ReadOnly = true;
            this.passwordBox.Size = new System.Drawing.Size(182, 30);
            this.passwordBox.TabIndex = 10;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(182, 182);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.ReadOnly = true;
            this.usernameBox.Size = new System.Drawing.Size(182, 30);
            this.usernameBox.TabIndex = 9;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // lNameBox
            // 
            this.lNameBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameBox.Location = new System.Drawing.Point(182, 117);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(182, 30);
            this.lNameBox.TabIndex = 7;
            // 
            // fNameBox
            // 
            this.fNameBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameBox.Location = new System.Drawing.Point(182, 52);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(182, 30);
            this.fNameBox.TabIndex = 6;
            this.fNameBox.TextChanged += new System.EventHandler(this.fNameBox_TextChanged);
            // 
            // confirmPassLabel
            // 
            this.confirmPassLabel.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassLabel.Location = new System.Drawing.Point(368, 247);
            this.confirmPassLabel.Name = "confirmPassLabel";
            this.confirmPassLabel.Size = new System.Drawing.Size(230, 39);
            this.confirmPassLabel.TabIndex = 5;
            this.confirmPassLabel.Text = "Confirm Password:";
            this.confirmPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(26, 247);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(143, 39);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(26, 182);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(143, 39);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "Username:";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userInstructionLabel
            // 
            this.userInstructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.userInstructionLabel.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInstructionLabel.Location = new System.Drawing.Point(90, 100);
            this.userInstructionLabel.Name = "userInstructionLabel";
            this.userInstructionLabel.Size = new System.Drawing.Size(780, 30);
            this.userInstructionLabel.TabIndex = 4;
            this.userInstructionLabel.Text = "Please fill out the information below to finish creating your account.";
            this.userInstructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(240, 10);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(480, 80);
            this.welcomeLabel.TabIndex = 5;
            this.welcomeLabel.Text = "Welcome to Budget List";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.veryLightSpiralBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 665);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.userInstructionLabel);
            this.Controls.Add(this.newUserInfoGroup);
            this.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUserForm";
            this.Text = "New Profile";
            this.newUserInfoGroup.ResumeLayout(false);
            this.newUserInfoGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.GroupBox newUserInfoGroup;
        private System.Windows.Forms.TextBox confirmPassBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.Label confirmPassLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userInstructionLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.DateTimePicker dobBox;
        private System.Windows.Forms.TextBox zipcodeBox;
        private System.Windows.Forms.Label zipcodeLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label1;
    }
}