﻿namespace WindowsFormsApp1
{
    partial class Form1
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
            this.switchWinForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // switchWinForm
            // 
            this.switchWinForm.Location = new System.Drawing.Point(133, 287);
            this.switchWinForm.Name = "switchWinForm";
            this.switchWinForm.Size = new System.Drawing.Size(385, 142);
            this.switchWinForm.TabIndex = 0;
            this.switchWinForm.Text = "Switch to winform2";
            this.switchWinForm.UseVisualStyleBackColor = true;
            this.switchWinForm.Click += new System.EventHandler(this.switchWinForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 550);
            this.Controls.Add(this.switchWinForm);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button switchWinForm;
    }
}

