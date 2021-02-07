
namespace Notes
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.comboBox_login = new System.Windows.Forms.ComboBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.checkBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.button_Apply = new System.Windows.Forms.Button();
            this.button_Deny = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_login
            // 
            this.comboBox_login.FormattingEnabled = true;
            this.comboBox_login.Location = new System.Drawing.Point(12, 12);
            this.comboBox_login.Name = "comboBox_login";
            this.comboBox_login.Size = new System.Drawing.Size(121, 21);
            this.comboBox_login.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(12, 39);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(121, 20);
            this.textBox_password.TabIndex = 1;
            // 
            // checkBox_ShowPassword
            // 
            this.checkBox_ShowPassword.AutoSize = true;
            this.checkBox_ShowPassword.Location = new System.Drawing.Point(12, 65);
            this.checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            this.checkBox_ShowPassword.Size = new System.Drawing.Size(101, 17);
            this.checkBox_ShowPassword.TabIndex = 2;
            this.checkBox_ShowPassword.Text = "Show password";
            this.checkBox_ShowPassword.UseVisualStyleBackColor = true;
            // 
            // button_AddUser
            // 
            this.button_AddUser.Location = new System.Drawing.Point(12, 88);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(75, 23);
            this.button_AddUser.TabIndex = 3;
            this.button_AddUser.Text = "Add user";
            this.button_AddUser.UseVisualStyleBackColor = true;
            this.button_AddUser.Click += new System.EventHandler(this.Button_AddUser_Click);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(187, 117);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(75, 23);
            this.button_Apply.TabIndex = 4;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.Button_Apply_Click);
            // 
            // button_Deny
            // 
            this.button_Deny.Location = new System.Drawing.Point(106, 117);
            this.button_Deny.Name = "button_Deny";
            this.button_Deny.Size = new System.Drawing.Size(75, 23);
            this.button_Deny.TabIndex = 5;
            this.button_Deny.Text = "Deny";
            this.button_Deny.UseVisualStyleBackColor = true;
            this.button_Deny.Click += new System.EventHandler(this.Button_Deny_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 152);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Deny);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.button_AddUser);
            this.Controls.Add(this.checkBox_ShowPassword);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.comboBox_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.CheckBox checkBox_ShowPassword;
        private System.Windows.Forms.Button button_AddUser;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Button button_Deny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}