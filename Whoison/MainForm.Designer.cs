﻿namespace Externals
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbUserList = new System.Windows.Forms.TextBox();
            this.btShowUsers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUserList
            // 
            this.tbUserList.Location = new System.Drawing.Point(12, 36);
            this.tbUserList.Multiline = true;
            this.tbUserList.Name = "tbUserList";
            this.tbUserList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbUserList.Size = new System.Drawing.Size(260, 174);
            this.tbUserList.TabIndex = 0;
            // 
            // btShowUsers
            // 
            this.btShowUsers.Location = new System.Drawing.Point(104, 226);
            this.btShowUsers.Name = "btShowUsers";
            this.btShowUsers.Size = new System.Drawing.Size(75, 23);
            this.btShowUsers.TabIndex = 1;
            this.btShowUsers.Text = "Show Users";
            this.btShowUsers.UseVisualStyleBackColor = true;
            this.btShowUsers.Click += new System.EventHandler(this.btShowUsers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connected users:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btShowUsers);
            this.Controls.Add(this.tbUserList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Who is on?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserList;
        private System.Windows.Forms.Button btShowUsers;
        private System.Windows.Forms.Label label1;

    }
}

