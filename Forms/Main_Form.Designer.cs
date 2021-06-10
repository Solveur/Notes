
namespace Notes
{
	partial class Main_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
			this.panelNote = new System.Windows.Forms.Panel();
			this.richTextBox_NoteText = new System.Windows.Forms.RichTextBox();
			this.labelNoteDoesNotSelected = new System.Windows.Forms.Label();
			this.panelNotesList = new System.Windows.Forms.Panel();
			this.flowLayoutPanel_Notes = new System.Windows.Forms.FlowLayoutPanel();
			this.button_AddNote = new System.Windows.Forms.Button();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showUsersControlPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonExit = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.labelCurrentUser = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.panelNote.SuspendLayout();
			this.panelNotesList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelNote
			// 
			this.panelNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
			this.panelNote.Controls.Add(this.button3);
			this.panelNote.Controls.Add(this.richTextBox_NoteText);
			this.panelNote.Controls.Add(this.labelNoteDoesNotSelected);
			this.panelNote.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelNote.Location = new System.Drawing.Point(0, 0);
			this.panelNote.Margin = new System.Windows.Forms.Padding(0);
			this.panelNote.Name = "panelNote";
			this.panelNote.Size = new System.Drawing.Size(454, 357);
			this.panelNote.TabIndex = 7;
			// 
			// richTextBox_NoteText
			// 
			this.richTextBox_NoteText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
			this.richTextBox_NoteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox_NoteText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox_NoteText.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBox_NoteText.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.richTextBox_NoteText.Location = new System.Drawing.Point(0, 0);
			this.richTextBox_NoteText.Margin = new System.Windows.Forms.Padding(0);
			this.richTextBox_NoteText.Name = "richTextBox_NoteText";
			this.richTextBox_NoteText.Size = new System.Drawing.Size(454, 357);
			this.richTextBox_NoteText.TabIndex = 0;
			this.richTextBox_NoteText.Text = "";
			this.richTextBox_NoteText.Visible = false;
			this.richTextBox_NoteText.TextChanged += new System.EventHandler(this.RichTextBox_NoteText_TextChanged);
			// 
			// labelNoteDoesNotSelected
			// 
			this.labelNoteDoesNotSelected.AutoSize = true;
			this.labelNoteDoesNotSelected.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelNoteDoesNotSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.labelNoteDoesNotSelected.Location = new System.Drawing.Point(62, 141);
			this.labelNoteDoesNotSelected.Margin = new System.Windows.Forms.Padding(62, 141, 63, 141);
			this.labelNoteDoesNotSelected.Name = "labelNoteDoesNotSelected";
			this.labelNoteDoesNotSelected.Size = new System.Drawing.Size(329, 75);
			this.labelNoteDoesNotSelected.TabIndex = 1;
			this.labelNoteDoesNotSelected.Text = "Select note";
			// 
			// panelNotesList
			// 
			this.panelNotesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.panelNotesList.Controls.Add(this.flowLayoutPanel_Notes);
			this.panelNotesList.Controls.Add(this.button_AddNote);
			this.panelNotesList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelNotesList.Location = new System.Drawing.Point(0, 0);
			this.panelNotesList.Margin = new System.Windows.Forms.Padding(0);
			this.panelNotesList.MaximumSize = new System.Drawing.Size(170, 0);
			this.panelNotesList.MinimumSize = new System.Drawing.Size(170, 0);
			this.panelNotesList.Name = "panelNotesList";
			this.panelNotesList.Size = new System.Drawing.Size(170, 357);
			this.panelNotesList.TabIndex = 7;
			// 
			// flowLayoutPanel_Notes
			// 
			this.flowLayoutPanel_Notes.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.flowLayoutPanel_Notes.AutoScroll = true;
			this.flowLayoutPanel_Notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.flowLayoutPanel_Notes.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel_Notes.Location = new System.Drawing.Point(0, 33);
			this.flowLayoutPanel_Notes.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel_Notes.Name = "flowLayoutPanel_Notes";
			this.flowLayoutPanel_Notes.Size = new System.Drawing.Size(170, 324);
			this.flowLayoutPanel_Notes.TabIndex = 0;
			// 
			// button_AddNote
			// 
			this.button_AddNote.BackColor = System.Drawing.Color.Transparent;
			this.button_AddNote.FlatAppearance.BorderSize = 0;
			this.button_AddNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(60)))), ((int)(((byte)(12)))));
			this.button_AddNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(74)))), ((int)(((byte)(22)))));
			this.button_AddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_AddNote.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_AddNote.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.button_AddNote.Location = new System.Drawing.Point(3, 3);
			this.button_AddNote.Name = "button_AddNote";
			this.button_AddNote.Size = new System.Drawing.Size(164, 27);
			this.button_AddNote.TabIndex = 1;
			this.button_AddNote.Text = "+Note";
			this.button_AddNote.UseVisualStyleBackColor = false;
			this.button_AddNote.Click += new System.EventHandler(this.Button_AddNote_Click);
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer.IsSplitterFixed = true;
			this.splitContainer.Location = new System.Drawing.Point(0, 24);
			this.splitContainer.Margin = new System.Windows.Forms.Padding(0);
			this.splitContainer.MinimumSize = new System.Drawing.Size(474, 342);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.panelNotesList);
			this.splitContainer.Panel1MinSize = 170;
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.splitContainer.Panel2.Controls.Add(this.panelNote);
			this.splitContainer.Panel2MinSize = 300;
			this.splitContainer.Size = new System.Drawing.Size(625, 357);
			this.splitContainer.SplitterDistance = 170;
			this.splitContainer.SplitterWidth = 1;
			this.splitContainer.TabIndex = 0;
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.menuStrip.GripMargin = new System.Windows.Forms.Padding(0);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new System.Windows.Forms.Padding(0);
			this.menuStrip.Size = new System.Drawing.Size(625, 24);
			this.menuStrip.TabIndex = 1;
			this.menuStrip.Text = "menuStrip1";
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.usersToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showUsersControlPanelToolStripMenuItem});
			this.usersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
			this.usersToolStripMenuItem.Text = "Users";
			// 
			// showUsersControlPanelToolStripMenuItem
			// 
			this.showUsersControlPanelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.showUsersControlPanelToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.showUsersControlPanelToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.showUsersControlPanelToolStripMenuItem.Name = "showUsersControlPanelToolStripMenuItem";
			this.showUsersControlPanelToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.showUsersControlPanelToolStripMenuItem.Text = "Show users control panel";
			this.showUsersControlPanelToolStripMenuItem.Click += new System.EventHandler(this.showUsersControlPanelToolStripMenuItem_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
			this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonExit.FlatAppearance.BorderSize = 0;
			this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
			this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
			this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonExit.Location = new System.Drawing.Point(600, 1);
			this.buttonExit.Margin = new System.Windows.Forms.Padding(1);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(22, 22);
			this.buttonExit.TabIndex = 2;
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(554, 1);
			this.button1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(22, 22);
			this.button1.TabIndex = 3;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(577, 1);
			this.button2.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(22, 22);
			this.button2.TabIndex = 8;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// labelCurrentUser
			// 
			this.labelCurrentUser.AutoSize = true;
			this.labelCurrentUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCurrentUser.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.labelCurrentUser.Location = new System.Drawing.Point(44, 2);
			this.labelCurrentUser.Name = "labelCurrentUser";
			this.labelCurrentUser.Size = new System.Drawing.Size(102, 19);
			this.labelCurrentUser.TabIndex = 9;
			this.labelCurrentUser.Text = "Current user:";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(208, 66);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Main_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
			this.ClientSize = new System.Drawing.Size(625, 381);
			this.Controls.Add(this.labelCurrentUser);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(590, 381);
			this.Name = "Main_Form";
			this.Text = "Notes";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
			this.panelNote.ResumeLayout(false);
			this.panelNote.PerformLayout();
			this.panelNotesList.ResumeLayout(false);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelNote;
		private System.Windows.Forms.RichTextBox richTextBox_NoteText;
		private System.Windows.Forms.Panel panelNotesList;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Notes;
		private System.Windows.Forms.Button button_AddNote;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showUsersControlPanelToolStripMenuItem;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label labelNoteDoesNotSelected;
		private System.Windows.Forms.Label labelCurrentUser;
		private System.Windows.Forms.Button button3;
	}
}

