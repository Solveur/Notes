
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
            this.usersFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // usersFlowPanel
            // 
            this.usersFlowPanel.AutoScroll = true;
            this.usersFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.usersFlowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.usersFlowPanel.Name = "usersFlowPanel";
            this.usersFlowPanel.Size = new System.Drawing.Size(290, 461);
            this.usersFlowPanel.TabIndex = 0;
            // 
            // UsersList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 461);
            this.Controls.Add(this.usersFlowPanel);
            this.Name = "UsersList_Form";
            this.Text = "UsersList_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel usersFlowPanel;
    }
}