namespace WindowsFormsApp1
{
    partial class UserHome
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemoveGoal_Button = new System.Windows.Forms.Button();
            this.Cost_ListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Goal_ListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddGoal_Button = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RemoveFunds_Button = new System.Windows.Forms.Button();
            this.AddFunds_Button = new System.Windows.Forms.Button();
            this.SpendingFunds_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveList_Button = new System.Windows.Forms.Button();
            this.LoadList_Button = new System.Windows.Forms.Button();
            this.PrintList_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RemoveGoal_Button);
            this.groupBox1.Controls.Add(this.Cost_ListBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Goal_ListBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddGoal_Button);
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(320, 488);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // RemoveGoal_Button
            // 
            this.RemoveGoal_Button.Location = new System.Drawing.Point(168, 440);
            this.RemoveGoal_Button.Name = "RemoveGoal_Button";
            this.RemoveGoal_Button.Size = new System.Drawing.Size(144, 32);
            this.RemoveGoal_Button.TabIndex = 1;
            this.RemoveGoal_Button.Text = "Remove Goal";
            this.RemoveGoal_Button.UseVisualStyleBackColor = true;
            this.RemoveGoal_Button.Click += new System.EventHandler(this.RemoveGoal_Button_Click);
            // 
            // Cost_ListBox
            // 
            this.Cost_ListBox.FormattingEnabled = true;
            this.Cost_ListBox.ItemHeight = 16;
            this.Cost_ListBox.Location = new System.Drawing.Point(200, 32);
            this.Cost_ListBox.Name = "Cost_ListBox";
            this.Cost_ListBox.Size = new System.Drawing.Size(120, 388);
            this.Cost_ListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cost";
            // 
            // Goal_ListBox
            // 
            this.Goal_ListBox.FormattingEnabled = true;
            this.Goal_ListBox.ItemHeight = 16;
            this.Goal_ListBox.Location = new System.Drawing.Point(0, 32);
            this.Goal_ListBox.Name = "Goal_ListBox";
            this.Goal_ListBox.Size = new System.Drawing.Size(200, 388);
            this.Goal_ListBox.TabIndex = 3;
            this.Goal_ListBox.SelectedIndexChanged += new System.EventHandler(this.Goal_ListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Goal";
            // 
            // AddGoal_Button
            // 
            this.AddGoal_Button.Location = new System.Drawing.Point(8, 440);
            this.AddGoal_Button.Name = "AddGoal_Button";
            this.AddGoal_Button.Size = new System.Drawing.Size(144, 32);
            this.AddGoal_Button.TabIndex = 0;
            this.AddGoal_Button.Text = "Add Goal";
            this.AddGoal_Button.UseVisualStyleBackColor = true;
            this.AddGoal_Button.Click += new System.EventHandler(this.AddGoal_Button_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.RemoveFunds_Button);
            this.groupBox5.Controls.Add(this.AddFunds_Button);
            this.groupBox5.Controls.Add(this.SpendingFunds_Label);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(344, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(360, 184);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // RemoveFunds_Button
            // 
            this.RemoveFunds_Button.Location = new System.Drawing.Point(192, 144);
            this.RemoveFunds_Button.Name = "RemoveFunds_Button";
            this.RemoveFunds_Button.Size = new System.Drawing.Size(152, 32);
            this.RemoveFunds_Button.TabIndex = 5;
            this.RemoveFunds_Button.Text = "Remove Funds";
            this.RemoveFunds_Button.UseVisualStyleBackColor = true;
            this.RemoveFunds_Button.Click += new System.EventHandler(this.button4_Click);
            // 
            // AddFunds_Button
            // 
            this.AddFunds_Button.Location = new System.Drawing.Point(16, 144);
            this.AddFunds_Button.Name = "AddFunds_Button";
            this.AddFunds_Button.Size = new System.Drawing.Size(152, 32);
            this.AddFunds_Button.TabIndex = 2;
            this.AddFunds_Button.Text = "Add Funds";
            this.AddFunds_Button.UseVisualStyleBackColor = true;
            // 
            // SpendingFunds_Label
            // 
            this.SpendingFunds_Label.BackColor = System.Drawing.Color.White;
            this.SpendingFunds_Label.Location = new System.Drawing.Point(0, 40);
            this.SpendingFunds_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SpendingFunds_Label.Name = "SpendingFunds_Label";
            this.SpendingFunds_Label.Size = new System.Drawing.Size(360, 88);
            this.SpendingFunds_Label.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Spending Funds";
            // 
            // SaveList_Button
            // 
            this.SaveList_Button.Location = new System.Drawing.Point(344, 216);
            this.SaveList_Button.Name = "SaveList_Button";
            this.SaveList_Button.Size = new System.Drawing.Size(360, 32);
            this.SaveList_Button.TabIndex = 6;
            this.SaveList_Button.Text = "Save List";
            this.SaveList_Button.UseVisualStyleBackColor = true;
            // 
            // LoadList_Button
            // 
            this.LoadList_Button.Location = new System.Drawing.Point(344, 264);
            this.LoadList_Button.Name = "LoadList_Button";
            this.LoadList_Button.Size = new System.Drawing.Size(360, 32);
            this.LoadList_Button.TabIndex = 7;
            this.LoadList_Button.Text = "Load List";
            this.LoadList_Button.UseVisualStyleBackColor = true;
            // 
            // PrintList_Button
            // 
            this.PrintList_Button.Location = new System.Drawing.Point(344, 320);
            this.PrintList_Button.Name = "PrintList_Button";
            this.PrintList_Button.Size = new System.Drawing.Size(360, 32);
            this.PrintList_Button.TabIndex = 8;
            this.PrintList_Button.Text = "Print List";
            this.PrintList_Button.UseVisualStyleBackColor = true;
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.spiralBlue1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 513);
            this.Controls.Add(this.PrintList_Button);
            this.Controls.Add(this.LoadList_Button);
            this.Controls.Add(this.SaveList_Button);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RemoveGoal_Button;
        private System.Windows.Forms.Button AddGoal_Button;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button RemoveFunds_Button;
        private System.Windows.Forms.Button AddFunds_Button;
        private System.Windows.Forms.Label SpendingFunds_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveList_Button;
        private System.Windows.Forms.Button LoadList_Button;
        private System.Windows.Forms.Button PrintList_Button;
        private System.Windows.Forms.ListBox Goal_ListBox;
        private System.Windows.Forms.ListBox Cost_ListBox;
    }
}