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
            this.SuspendLayout();
            // 
            // RemoveFunds_UserInputTextbox
            // 
            this.RemoveFunds_UserInputTextbox.Location = new System.Drawing.Point(12, 12);
            this.RemoveFunds_UserInputTextbox.Name = "RemoveFunds_UserInputTextbox";
            this.RemoveFunds_UserInputTextbox.Size = new System.Drawing.Size(192, 20);
            this.RemoveFunds_UserInputTextbox.TabIndex = 0;
            // 
            // RemoveFunds_ConfirmButton
            // 
            this.RemoveFunds_ConfirmButton.Location = new System.Drawing.Point(12, 38);
            this.RemoveFunds_ConfirmButton.Name = "RemoveFunds_ConfirmButton";
            this.RemoveFunds_ConfirmButton.Size = new System.Drawing.Size(192, 23);
            this.RemoveFunds_ConfirmButton.TabIndex = 1;
            this.RemoveFunds_ConfirmButton.Text = "Confirm";
            this.RemoveFunds_ConfirmButton.UseVisualStyleBackColor = true;
            this.RemoveFunds_ConfirmButton.Click += new System.EventHandler(this.RemoveFunds_ConfirmButton_Click);
            // 
            // RemoveFunds_CancelButton
            // 
            this.RemoveFunds_CancelButton.Location = new System.Drawing.Point(12, 68);
            this.RemoveFunds_CancelButton.Name = "RemoveFunds_CancelButton";
            this.RemoveFunds_CancelButton.Size = new System.Drawing.Size(192, 23);
            this.RemoveFunds_CancelButton.TabIndex = 2;
            this.RemoveFunds_CancelButton.Text = "Cancel";
            this.RemoveFunds_CancelButton.UseVisualStyleBackColor = true;
            this.RemoveFunds_CancelButton.Click += new System.EventHandler(this.RemoveFunds_CancelButton_Click);
            // 
            // RemoveFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 106);
            this.Controls.Add(this.RemoveFunds_CancelButton);
            this.Controls.Add(this.RemoveFunds_ConfirmButton);
            this.Controls.Add(this.RemoveFunds_UserInputTextbox);
            this.Name = "RemoveFunds";
            this.Text = "Remove Funds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RemoveFunds_UserInputTextbox;
        private System.Windows.Forms.Button RemoveFunds_ConfirmButton;
        private System.Windows.Forms.Button RemoveFunds_CancelButton;
    }
}