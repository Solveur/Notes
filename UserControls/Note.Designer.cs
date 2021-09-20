namespace Notes
{
	partial class Note
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
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lbl_Header = new System.Windows.Forms.Label();
			this.lbl_Content = new System.Windows.Forms.Label();
			this.contextMenuStrip_NoteRMB = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip_NoteRMB.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_Header
			// 
			this.lbl_Header.AutoSize = true;
			this.lbl_Header.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.lbl_Header.Location = new System.Drawing.Point(5, 5);
			this.lbl_Header.Name = "lbl_Header";
			this.lbl_Header.Size = new System.Drawing.Size(60, 13);
			this.lbl_Header.TabIndex = 0;
			this.lbl_Header.Text = "Empty note";
			// 
			// lbl_Content
			// 
			this.lbl_Content.AutoSize = true;
			this.lbl_Content.ForeColor = System.Drawing.Color.DarkGray;
			this.lbl_Content.Location = new System.Drawing.Point(5, 25);
			this.lbl_Content.Name = "lbl_Content";
			this.lbl_Content.Size = new System.Drawing.Size(0, 13);
			this.lbl_Content.TabIndex = 1;
			// 
			// contextMenuStrip_NoteRMB
			// 
			this.contextMenuStrip_NoteRMB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.deleteToolStripMenuItem});
			this.contextMenuStrip_NoteRMB.Name = "contextMenuStrip_NoteRMB";
			this.contextMenuStrip_NoteRMB.Size = new System.Drawing.Size(181, 48);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// Note
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.ContextMenuStrip = this.contextMenuStrip_NoteRMB;
			this.Controls.Add(this.lbl_Content);
			this.Controls.Add(this.lbl_Header);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Name = "Note";
			this.Size = new System.Drawing.Size(150, 47);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Note_MouseDown);
			this.MouseEnter += new System.EventHandler(this.Note_MouseEnter);
			this.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Note_MouseUp);
			this.contextMenuStrip_NoteRMB.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_Header;
		private System.Windows.Forms.Label lbl_Content;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_NoteRMB;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
	}
}
