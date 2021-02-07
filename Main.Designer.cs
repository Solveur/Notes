
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button_AddNote = new System.Windows.Forms.Button();
            this.richTextBox_NoteText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_User = new System.Windows.Forms.Label();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.button_RemoveUser = new System.Windows.Forms.Button();
            this.button_DeleteNote = new System.Windows.Forms.Button();
            this.button_ChangeUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
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
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.button_ChangeUser);
            this.splitContainer.Panel2.Controls.Add(this.button_DeleteNote);
            this.splitContainer.Panel2.Controls.Add(this.button_RemoveUser);
            this.splitContainer.Panel2.Controls.Add(this.button_AddUser);
            this.splitContainer.Panel2.Controls.Add(this.label_User);
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Panel2.Controls.Add(this.richTextBox_NoteText);
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 266;
            this.splitContainer.TabIndex = 0;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 43);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(266, 407);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // button_AddNote
            // 
            this.button_AddNote.Location = new System.Drawing.Point(238, 12);
            this.button_AddNote.Name = "button_AddNote";
            this.button_AddNote.Size = new System.Drawing.Size(25, 25);
            this.button_AddNote.TabIndex = 1;
            this.button_AddNote.Text = "+";
            this.button_AddNote.UseVisualStyleBackColor = true;
            this.button_AddNote.Click += new System.EventHandler(this.Button_AddNote_Click);
            // 
            // richTextBox_NoteText
            // 
            this.richTextBox_NoteText.Location = new System.Drawing.Point(3, 145);
            this.richTextBox_NoteText.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.richTextBox_NoteText.Name = "richTextBox_NoteText";
            this.richTextBox_NoteText.Size = new System.Drawing.Size(518, 302);
            this.richTextBox_NoteText.TabIndex = 0;
            this.richTextBox_NoteText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User: ";
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_User.Location = new System.Drawing.Point(51, 9);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(0, 13);
            this.label_User.TabIndex = 2;
            // 
            // button_AddUser
            // 
            this.button_AddUser.Location = new System.Drawing.Point(340, 3);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(50, 50);
            this.button_AddUser.TabIndex = 3;
            this.button_AddUser.UseVisualStyleBackColor = true;
            // 
            // button_RemoveUser
            // 
            this.button_RemoveUser.Location = new System.Drawing.Point(396, 3);
            this.button_RemoveUser.Name = "button_RemoveUser";
            this.button_RemoveUser.Size = new System.Drawing.Size(50, 50);
            this.button_RemoveUser.TabIndex = 4;
            this.button_RemoveUser.UseVisualStyleBackColor = true;
            // 
            // button_DeleteNote
            // 
            this.button_DeleteNote.Location = new System.Drawing.Point(468, 3);
            this.button_DeleteNote.Name = "button_DeleteNote";
            this.button_DeleteNote.Size = new System.Drawing.Size(50, 50);
            this.button_DeleteNote.TabIndex = 5;
            this.button_DeleteNote.UseVisualStyleBackColor = true;
            // 
            // button_ChangeUser
            // 
            this.button_ChangeUser.Location = new System.Drawing.Point(284, 3);
            this.button_ChangeUser.Name = "button_ChangeUser";
            this.button_ChangeUser.Size = new System.Drawing.Size(50, 50);
            this.button_ChangeUser.TabIndex = 6;
            this.button_ChangeUser.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
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
    }
}

