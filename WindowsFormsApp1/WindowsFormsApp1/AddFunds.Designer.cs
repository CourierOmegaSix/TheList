namespace WindowsFormsApp1
{
    partial class AddFunds
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
            this.AddFunds_UserInputTextbox = new System.Windows.Forms.TextBox();
            this.AddFunds_ConfirmButton = new System.Windows.Forms.Button();
            this.AddFunds_CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddFunds_UserInputTextbox
            // 
            this.AddFunds_UserInputTextbox.Location = new System.Drawing.Point(29, 12);
            this.AddFunds_UserInputTextbox.Name = "AddFunds_UserInputTextbox";
            this.AddFunds_UserInputTextbox.Size = new System.Drawing.Size(154, 20);
            this.AddFunds_UserInputTextbox.TabIndex = 0;
            // 
            // AddFunds_ConfirmButton
            // 
            this.AddFunds_ConfirmButton.Location = new System.Drawing.Point(29, 38);
            this.AddFunds_ConfirmButton.Name = "AddFunds_ConfirmButton";
            this.AddFunds_ConfirmButton.Size = new System.Drawing.Size(154, 23);
            this.AddFunds_ConfirmButton.TabIndex = 1;
            this.AddFunds_ConfirmButton.Text = "Confirm";
            this.AddFunds_ConfirmButton.UseVisualStyleBackColor = true;
            this.AddFunds_ConfirmButton.Click += new System.EventHandler(this.AddFunds_ConfirmButton_Click);
            // 
            // AddFunds_CancelButton
            // 
            this.AddFunds_CancelButton.Location = new System.Drawing.Point(29, 67);
            this.AddFunds_CancelButton.Name = "AddFunds_CancelButton";
            this.AddFunds_CancelButton.Size = new System.Drawing.Size(154, 23);
            this.AddFunds_CancelButton.TabIndex = 2;
            this.AddFunds_CancelButton.Text = "Cancel";
            this.AddFunds_CancelButton.UseVisualStyleBackColor = true;
            this.AddFunds_CancelButton.Click += new System.EventHandler(this.AddFunds_CancelButton_Click);
            // 
            // AddFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 103);
            this.Controls.Add(this.AddFunds_CancelButton);
            this.Controls.Add(this.AddFunds_ConfirmButton);
            this.Controls.Add(this.AddFunds_UserInputTextbox);
            this.Name = "AddFunds";
            this.Text = "Add Funds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddFunds_UserInputTextbox;
        private System.Windows.Forms.Button AddFunds_ConfirmButton;
        private System.Windows.Forms.Button AddFunds_CancelButton;
    }
}