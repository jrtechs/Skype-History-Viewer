namespace Skype_History_Viewer
{
    partial class FrmMain
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
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.lstChat = new System.Windows.Forms.ListBox();
            this.cmdExportAll = new System.Windows.Forms.Button();
            this.cmdExport = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.chTime = new System.Windows.Forms.CheckBox();
            this.chUser = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(25, 15);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(180, 264);
            this.lstUsers.TabIndex = 0;
            // 
            // lstChat
            // 
            this.lstChat.FormattingEnabled = true;
            this.lstChat.Location = new System.Drawing.Point(227, 14);
            this.lstChat.Name = "lstChat";
            this.lstChat.Size = new System.Drawing.Size(969, 615);
            this.lstChat.TabIndex = 1;
            // 
            // cmdExportAll
            // 
            this.cmdExportAll.Location = new System.Drawing.Point(25, 568);
            this.cmdExportAll.Name = "cmdExportAll";
            this.cmdExportAll.Size = new System.Drawing.Size(152, 61);
            this.cmdExportAll.TabIndex = 2;
            this.cmdExportAll.Text = "Export All To Text File";
            this.cmdExportAll.UseVisualStyleBackColor = true;
            this.cmdExportAll.Click += new System.EventHandler(this.cmdExportAll_Click);
            // 
            // cmdExport
            // 
            this.cmdExport.Location = new System.Drawing.Point(25, 501);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(152, 61);
            this.cmdExport.TabIndex = 3;
            this.cmdExport.Text = "Export Selected to Text File";
            this.cmdExport.UseVisualStyleBackColor = true;
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(25, 367);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(152, 61);
            this.cmdAdd.TabIndex = 4;
            this.cmdAdd.Text = "View History for Selected User";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(25, 434);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(152, 61);
            this.cmdClear.TabIndex = 5;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // chTime
            // 
            this.chTime.AutoSize = true;
            this.chTime.Location = new System.Drawing.Point(13, 297);
            this.chTime.Name = "chTime";
            this.chTime.Size = new System.Drawing.Size(129, 17);
            this.chTime.TabIndex = 6;
            this.chTime.Text = "Include a Time Stamp";
            this.chTime.UseVisualStyleBackColor = true;
            // 
            // chUser
            // 
            this.chUser.AutoSize = true;
            this.chUser.Location = new System.Drawing.Point(13, 320);
            this.chUser.Name = "chUser";
            this.chUser.Size = new System.Drawing.Size(208, 17);
            this.chUser.TabIndex = 7;
            this.chUser.Text = "Include a User Tag Infront of Message";
            this.chUser.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 640);
            this.Controls.Add(this.chUser);
            this.Controls.Add(this.chTime);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdExport);
            this.Controls.Add(this.cmdExportAll);
            this.Controls.Add(this.lstChat);
            this.Controls.Add(this.lstUsers);
            this.Name = "FrmMain";
            this.Text = "Skype History Viewer by Jrtechs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.ListBox lstChat;
        private System.Windows.Forms.Button cmdExportAll;
        private System.Windows.Forms.Button cmdExport;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.CheckBox chTime;
        private System.Windows.Forms.CheckBox chUser;
    }
}

