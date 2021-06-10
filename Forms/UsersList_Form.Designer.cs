
namespace Notes.Forms
{
    partial class UsersList_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersList_Form));
			this.users_FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonExit = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.SuspendLayout();
			// 
			// users_FlowPanel
			// 
			this.users_FlowPanel.AutoScroll = true;
			this.users_FlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.users_FlowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.users_FlowPanel.Location = new System.Drawing.Point(0, 25);
			this.users_FlowPanel.Margin = new System.Windows.Forms.Padding(0);
			this.users_FlowPanel.Name = "users_FlowPanel";
			this.users_FlowPanel.Size = new System.Drawing.Size(290, 436);
			this.users_FlowPanel.TabIndex = 0;
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
			this.buttonExit.Location = new System.Drawing.Point(267, 0);
			this.buttonExit.Margin = new System.Windows.Forms.Padding(1);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(23, 23);
			this.buttonExit.TabIndex = 9;
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
			this.menuStrip1.Size = new System.Drawing.Size(290, 25);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip";
			this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseDown);
			// 
			// UsersList_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 461);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.users_FlowPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "UsersList_Form";
			this.Text = "UsersList_Form";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsersList_Form_FormClosing);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel users_FlowPanel;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}