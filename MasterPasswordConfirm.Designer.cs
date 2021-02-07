
namespace Notes
{
    partial class MasterPasswordConfirm
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
            this.textBox_MasterPassword = new System.Windows.Forms.TextBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.button_Deny = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_MasterPassword
            // 
            this.textBox_MasterPassword.Location = new System.Drawing.Point(96, 116);
            this.textBox_MasterPassword.Name = "textBox_MasterPassword";
            this.textBox_MasterPassword.Size = new System.Drawing.Size(100, 20);
            this.textBox_MasterPassword.TabIndex = 0;
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(713, 415);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(75, 23);
            this.button_Apply.TabIndex = 1;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            // 
            // button_Deny
            // 
            this.button_Deny.Location = new System.Drawing.Point(632, 415);
            this.button_Deny.Name = "button_Deny";
            this.button_Deny.Size = new System.Drawing.Size(75, 23);
            this.button_Deny.TabIndex = 2;
            this.button_Deny.Text = "Deny";
            this.button_Deny.UseVisualStyleBackColor = true;
            // 
            // MasterPasswordConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Deny);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.textBox_MasterPassword);
            this.Name = "MasterPasswordConfirm";
            this.Text = "MasterPasswordConfirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_MasterPassword;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Button button_Deny;
    }
}