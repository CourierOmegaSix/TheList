namespace WindowsFormsApp1
{
    partial class RemoveGoalForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.removeGoalButton = new System.Windows.Forms.Button();
            this.amountSpentBox = new System.Windows.Forms.TextBox();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.removeGoalButton);
            this.groupBox1.Controls.Add(this.amountSpentBox);
            this.groupBox1.Controls.Add(this.fNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(248, 120);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 43);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // removeGoalButton
            // 
            this.removeGoalButton.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGoalButton.Location = new System.Drawing.Point(24, 120);
            this.removeGoalButton.Name = "removeGoalButton";
            this.removeGoalButton.Size = new System.Drawing.Size(168, 43);
            this.removeGoalButton.TabIndex = 8;
            this.removeGoalButton.Text = "Remove Goal";
            this.removeGoalButton.UseVisualStyleBackColor = true;
            this.removeGoalButton.Click += new System.EventHandler(this.removeGoalButton_Click);
            // 
            // amountSpentBox
            // 
            this.amountSpentBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountSpentBox.Location = new System.Drawing.Point(216, 40);
            this.amountSpentBox.Name = "amountSpentBox";
            this.amountSpentBox.Size = new System.Drawing.Size(182, 23);
            this.amountSpentBox.TabIndex = 7;
            // 
            // fNameLabel
            // 
            this.fNameLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.fNameLabel.Location = new System.Drawing.Point(8, 32);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(200, 39);
            this.fNameLabel.TabIndex = 1;
            this.fNameLabel.Text = "Amount Spent:";
            this.fNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveGoalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.veryLightSpiralBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(440, 195);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoveGoalForm";
            this.Text = "Remove Goal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.TextBox amountSpentBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button removeGoalButton;
    }
}