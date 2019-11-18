namespace WindowsFormsApp1
{
    partial class RemoveFunds
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
            this.RemoveFunds_UserInputTextbox = new System.Windows.Forms.TextBox();
            this.RemoveFunds_ConfirmButton = new System.Windows.Forms.Button();
            this.RemoveFunds_CancelButton = new System.Windows.Forms.Button();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RemoveFunds_UserInputTextbox
            // 
            this.RemoveFunds_UserInputTextbox.Location = new System.Drawing.Point(152, 40);
            this.RemoveFunds_UserInputTextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.RemoveFunds_UserInputTextbox.Name = "RemoveFunds_UserInputTextbox";
            this.RemoveFunds_UserInputTextbox.Size = new System.Drawing.Size(196, 30);
            this.RemoveFunds_UserInputTextbox.TabIndex = 0;
            // 
            // RemoveFunds_ConfirmButton
            // 
            this.RemoveFunds_ConfirmButton.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveFunds_ConfirmButton.Location = new System.Drawing.Point(56, 104);
            this.RemoveFunds_ConfirmButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.RemoveFunds_ConfirmButton.Name = "RemoveFunds_ConfirmButton";
            this.RemoveFunds_ConfirmButton.Size = new System.Drawing.Size(104, 42);
            this.RemoveFunds_ConfirmButton.TabIndex = 1;
            this.RemoveFunds_ConfirmButton.Text = "Confirm";
            this.RemoveFunds_ConfirmButton.UseVisualStyleBackColor = true;
            this.RemoveFunds_ConfirmButton.Click += new System.EventHandler(this.RemoveFunds_ConfirmButton_Click);
            // 
            // RemoveFunds_CancelButton
            // 
            this.RemoveFunds_CancelButton.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveFunds_CancelButton.Location = new System.Drawing.Point(240, 104);
            this.RemoveFunds_CancelButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.RemoveFunds_CancelButton.Name = "RemoveFunds_CancelButton";
            this.RemoveFunds_CancelButton.Size = new System.Drawing.Size(104, 42);
            this.RemoveFunds_CancelButton.TabIndex = 2;
            this.RemoveFunds_CancelButton.Text = "Cancel";
            this.RemoveFunds_CancelButton.UseVisualStyleBackColor = true;
            this.RemoveFunds_CancelButton.Click += new System.EventHandler(this.RemoveFunds_CancelButton_Click);
            // 
            // fNameLabel
            // 
            this.fNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.fNameLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.fNameLabel.Location = new System.Drawing.Point(24, 40);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(128, 31);
            this.fNameLabel.TabIndex = 3;
            this.fNameLabel.Text = "Amount:";
            this.fNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.veryLightSpiralBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(395, 177);
            this.Controls.Add(this.fNameLabel);
            this.Controls.Add(this.RemoveFunds_CancelButton);
            this.Controls.Add(this.RemoveFunds_ConfirmButton);
            this.Controls.Add(this.RemoveFunds_UserInputTextbox);
            this.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoveFunds";
            this.Text = "Remove Funds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RemoveFunds_UserInputTextbox;
        private System.Windows.Forms.Button RemoveFunds_ConfirmButton;
        private System.Windows.Forms.Button RemoveFunds_CancelButton;
        private System.Windows.Forms.Label fNameLabel;
    }
}