
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox_NoteText = new System.Windows.Forms.RichTextBox();
            this.label_User = new System.Windows.Forms.Label();
            this.button_DeleteNote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_DeleteUser = new System.Windows.Forms.Button();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button_AddNote = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.comboBox_User = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_User);
            this.panel1.Controls.Add(this.richTextBox_NoteText);
            this.panel1.Controls.Add(this.label_User);
            this.panel1.Controls.Add(this.button_DeleteNote);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_DeleteUser);
            this.panel1.Controls.Add(this.button_AddUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(496, 342);
            this.panel1.TabIndex = 7;
            // 
            // richTextBox_NoteText
            // 
            this.richTextBox_NoteText.BackColor = System.Drawing.Color.Gainsboro;
            this.richTextBox_NoteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_NoteText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox_NoteText.Location = new System.Drawing.Point(2, 59);
            this.richTextBox_NoteText.Name = "richTextBox_NoteText";
            this.richTextBox_NoteText.Size = new System.Drawing.Size(492, 281);
            this.richTextBox_NoteText.TabIndex = 0;
            this.richTextBox_NoteText.Text = "";
            this.richTextBox_NoteText.TextChanged += new System.EventHandler(this.RichTextBox_NoteText_TextChanged);
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_User.Location = new System.Drawing.Point(53, 11);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(0, 13);
            this.label_User.TabIndex = 2;
            // 
            // button_DeleteNote
            // 
            this.button_DeleteNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DeleteNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_DeleteNote.Location = new System.Drawing.Point(432, 5);
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
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User: ";
            // 
            // button_DeleteUser
            // 
            this.button_DeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_DeleteUser.Location = new System.Drawing.Point(346, 5);
            this.button_DeleteUser.Name = "button_DeleteUser";
            this.button_DeleteUser.Size = new System.Drawing.Size(50, 50);
            this.button_DeleteUser.TabIndex = 4;
            this.button_DeleteUser.UseVisualStyleBackColor = true;
            this.button_DeleteUser.Click += new System.EventHandler(this.Button_DeleteUser_Click);
            // 
            // button_AddUser
            // 
            this.button_AddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_AddUser.Location = new System.Drawing.Point(290, 5);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(50, 50);
            this.button_AddUser.TabIndex = 3;
            this.button_AddUser.UseVisualStyleBackColor = true;
            this.button_AddUser.Click += new System.EventHandler(this.Button_AddUser_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.notesFlowPanel);
            this.panel2.Controls.Add(this.button_AddNote);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.MaximumSize = new System.Drawing.Size(170, 0);
            this.panel2.MinimumSize = new System.Drawing.Size(170, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 342);
            this.panel2.TabIndex = 7;
            // 
            // notesFlowPanel
            // 
            this.notesFlowPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.notesFlowPanel.AutoScroll = true;
            this.notesFlowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.notesFlowPanel.Location = new System.Drawing.Point(0, 31);
            this.notesFlowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.notesFlowPanel.Name = "notesFlowPanel";
            this.notesFlowPanel.Size = new System.Drawing.Size(170, 311);
            this.notesFlowPanel.TabIndex = 0;
            // 
            // button_AddNote
            // 
            this.button_AddNote.Location = new System.Drawing.Point(121, 3);
            this.button_AddNote.Name = "button_AddNote";
            this.button_AddNote.Size = new System.Drawing.Size(45, 25);
            this.button_AddNote.TabIndex = 1;
            this.button_AddNote.Text = "+Note";
            this.button_AddNote.UseVisualStyleBackColor = true;
            this.button_AddNote.Click += new System.EventHandler(this.Button_AddNote_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer.MinimumSize = new System.Drawing.Size(474, 342);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panel2);
            this.splitContainer.Panel1MinSize = 170;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Panel2MinSize = 300;
            this.splitContainer.Size = new System.Drawing.Size(667, 342);
            this.splitContainer.SplitterDistance = 170;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // comboBox_User
            // 
            this.comboBox_User.FormattingEnabled = true;
            this.comboBox_User.Location = new System.Drawing.Point(15, 27);
            this.comboBox_User.Name = "comboBox_User";
            this.comboBox_User.Size = new System.Drawing.Size(121, 21);
            this.comboBox_User.TabIndex = 7;
            this.comboBox_User.SelectionChangeCommitted += new System.EventHandler(this.СomboBox_User_SelectionChangeCommitted);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 342);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(590, 381);
            this.Name = "Main";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox richTextBox_NoteText;
		private System.Windows.Forms.Label label_User;
		private System.Windows.Forms.Button button_DeleteNote;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_DeleteUser;
		private System.Windows.Forms.Button button_AddUser;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.FlowLayoutPanel notesFlowPanel;
		private System.Windows.Forms.Button button_AddNote;
		private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ComboBox comboBox_User;
    }
}

