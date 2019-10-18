namespace Externals
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
            this.tbUserList = new System.Windows.Forms.TextBox();
            this.btShowUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUserList
            // 
            this.tbUserList.Location = new System.Drawing.Point(12, 12);
            this.tbUserList.Multiline = true;
            this.tbUserList.Name = "tbUserList";
            this.tbUserList.Size = new System.Drawing.Size(260, 198);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btShowUsers);
            this.Controls.Add(this.tbUserList);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserList;
        private System.Windows.Forms.Button btShowUsers;

    }
}

