
namespace Notes
{
    partial class DeleteUser
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
            this.comboBox_login = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.button_Deny = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_login
            // 
            this.comboBox_login.FormattingEnabled = true;
            this.comboBox_login.Location = new System.Drawing.Point(154, 135);
            this.comboBox_login.Name = "comboBox_login";
            this.comboBox_login.Size = new System.Drawing.Size(121, 21);
            this.comboBox_login.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(154, 162);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(168, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "I\'m sure I want delete this user";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(713, 415);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(75, 23);
            this.button_Apply.TabIndex = 2;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            // 
            // button_Deny
            // 
            this.button_Deny.Location = new System.Drawing.Point(632, 415);
            this.button_Deny.Name = "button_Deny";
            this.button_Deny.Size = new System.Drawing.Size(75, 23);
            this.button_Deny.TabIndex = 3;
            this.button_Deny.Text = "Deny";
            this.button_Deny.UseVisualStyleBackColor = true;
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Deny);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox_login);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_login;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Button button_Deny;
    }
}