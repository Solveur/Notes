﻿
namespace Notes
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.button_AddNote = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox_NoteText = new System.Windows.Forms.RichTextBox();
            this.label_User = new System.Windows.Forms.Label();
            this.button_DeleteNote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ChangeUser = new System.Windows.Forms.Button();
            this.button_RemoveUser = new System.Windows.Forms.Button();
            this.button_AddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.button_AddNote);
            this.splitContainer.Panel1.Controls.Add(this.flowLayoutPanel);
            this.splitContainer.Panel1MinSize = 170;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 170;
            this.splitContainer.TabIndex = 0;
            // 
            // button_AddNote
            // 
            this.button_AddNote.Location = new System.Drawing.Point(142, 3);
            this.button_AddNote.Name = "button_AddNote";
            this.button_AddNote.Size = new System.Drawing.Size(25, 25);
            this.button_AddNote.TabIndex = 1;
            this.button_AddNote.Text = "+";
            this.button_AddNote.UseVisualStyleBackColor = true;
            this.button_AddNote.Click += new System.EventHandler(this.Button_AddNote_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 34);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(170, 416);
            this.flowLayoutPanel.TabIndex = 0;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox_NoteText);
            this.panel1.Controls.Add(this.label_User);
            this.panel1.Controls.Add(this.button_DeleteNote);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_ChangeUser);
            this.panel1.Controls.Add(this.button_RemoveUser);
            this.panel1.Controls.Add(this.button_AddUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 442);
            this.panel1.TabIndex = 7;
            // 
            // richTextBox_NoteText
            // 
            this.richTextBox_NoteText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_NoteText.Location = new System.Drawing.Point(0, 61);
            this.richTextBox_NoteText.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBox_NoteText.Name = "richTextBox_NoteText";
            this.richTextBox_NoteText.Size = new System.Drawing.Size(618, 381);
            this.richTextBox_NoteText.TabIndex = 0;
            this.richTextBox_NoteText.Text = "";
            this.richTextBox_NoteText.TextChanged += new System.EventHandler(this.RichTextBox_NoteText_TextChanged);
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_User.Location = new System.Drawing.Point(51, 6);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(0, 13);
            this.label_User.TabIndex = 2;
            // 
            // button_DeleteNote
            // 
            this.button_DeleteNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DeleteNote.BackgroundImage = global::Notes.Properties.Resources.dustbin_120823;
            this.button_DeleteNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_DeleteNote.Location = new System.Drawing.Point(560, 3);
            this.button_DeleteNote.Name = "button_DeleteNote";
            this.button_DeleteNote.Size = new System.Drawing.Size(50, 50);
            this.button_DeleteNote.TabIndex = 5;
            this.button_DeleteNote.UseVisualStyleBackColor = true;
            this.button_DeleteNote.Click += new System.EventHandler(this.Button_DeleteNote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User: ";
            // 
            // button_ChangeUser
            // 
            this.button_ChangeUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ChangeUser.BackgroundImage = global::Notes.Properties.Resources.Change_User_icon_icons_com_55946;
            this.button_ChangeUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_ChangeUser.Location = new System.Drawing.Point(377, 3);
            this.button_ChangeUser.Name = "button_ChangeUser";
            this.button_ChangeUser.Size = new System.Drawing.Size(50, 50);
            this.button_ChangeUser.TabIndex = 6;
            this.button_ChangeUser.UseVisualStyleBackColor = true;
            this.button_ChangeUser.Click += new System.EventHandler(this.Button_ChangeUser_Click);
            // 
            // button_RemoveUser
            // 
            this.button_RemoveUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_RemoveUser.BackgroundImage = global::Notes.Properties.Resources.Remove_User_icon_icons_com_55828;
            this.button_RemoveUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_RemoveUser.Location = new System.Drawing.Point(433, 3);
            this.button_RemoveUser.Name = "button_RemoveUser";
            this.button_RemoveUser.Size = new System.Drawing.Size(50, 50);
            this.button_RemoveUser.TabIndex = 4;
            this.button_RemoveUser.UseVisualStyleBackColor = true;
            this.button_RemoveUser.Click += new System.EventHandler(this.Button_RemoveUser_Click);
            // 
            // button_AddUser
            // 
            this.button_AddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddUser.BackgroundImage = global::Notes.Properties.Resources.Add_User_icon_icons_com_55971;
            this.button_AddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_AddUser.Location = new System.Drawing.Point(489, 3);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(50, 50);
            this.button_AddUser.TabIndex = 3;
            this.button_AddUser.UseVisualStyleBackColor = true;
            this.button_AddUser.Click += new System.EventHandler(this.Button_AddUser_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Form1";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button button_AddNote;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.RichTextBox richTextBox_NoteText;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_RemoveUser;
        private System.Windows.Forms.Button button_AddUser;
        private System.Windows.Forms.Button button_DeleteNote;
        private System.Windows.Forms.Button button_ChangeUser;
        private System.Windows.Forms.Panel panel1;
    }
}
