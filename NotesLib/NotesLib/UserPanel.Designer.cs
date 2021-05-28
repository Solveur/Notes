
namespace NotesLib
{
    partial class UserPanel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.buttonSelectUser = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.UserAvatar = new System.Windows.Forms.PictureBox();
            this.textBoxDescription = new NotesLib.TextBoxWithPlaceholder();
            ((System.ComponentModel.ISupportInitialize)(this.UserAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelUserLogin.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelUserLogin.Location = new System.Drawing.Point(63, 4);
            this.labelUserLogin.Margin = new System.Windows.Forms.Padding(3);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(92, 22);
            this.labelUserLogin.TabIndex = 1;
            this.labelUserLogin.Text = "Username";
            // 
            // buttonSelectUser
            // 
            this.buttonSelectUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectUser.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelectUser.FlatAppearance.BorderSize = 0;
            this.buttonSelectUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonSelectUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(74)))), ((int)(((byte)(22)))));
            this.buttonSelectUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectUser.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSelectUser.Location = new System.Drawing.Point(209, 31);
            this.buttonSelectUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.buttonSelectUser.Name = "buttonSelectUser";
            this.buttonSelectUser.Size = new System.Drawing.Size(60, 23);
            this.buttonSelectUser.TabIndex = 2;
            this.buttonSelectUser.Text = "Select";
            this.buttonSelectUser.UseVisualStyleBackColor = false;
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditUser.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditUser.FlatAppearance.BorderSize = 0;
            this.buttonEditUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(74)))), ((int)(((byte)(22)))));
            this.buttonEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditUser.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditUser.Location = new System.Drawing.Point(209, 4);
            this.buttonEditUser.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(60, 23);
            this.buttonEditUser.TabIndex = 4;
            this.buttonEditUser.Text = "Edit";
            this.buttonEditUser.UseVisualStyleBackColor = false;
            // 
            // UserAvatar
            // 
            this.UserAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserAvatar.Image = ((System.Drawing.Image)(resources.GetObject("UserAvatar.Image")));
            this.UserAvatar.InitialImage = null;
            this.UserAvatar.Location = new System.Drawing.Point(1, 1);
            this.UserAvatar.Name = "UserAvatar";
            this.UserAvatar.Size = new System.Drawing.Size(56, 56);
            this.UserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserAvatar.TabIndex = 0;
            this.UserAvatar.TabStop = false;
            this.UserAvatar.Click += new System.EventHandler(this.pictureBox_Click);
            this.UserAvatar.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.UserAvatar.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescription.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxDescription.Location = new System.Drawing.Point(63, 32);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Placeholder = "Short description";
            this.textBoxDescription.Size = new System.Drawing.Size(140, 18);
            this.textBoxDescription.TabIndex = 5;
            this.textBoxDescription.Text = "Short description";
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.buttonSelectUser);
            this.Controls.Add(this.labelUserLogin);
            this.Controls.Add(this.UserAvatar);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UserPanel";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(273, 58);
            ((System.ComponentModel.ISupportInitialize)(this.UserAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UserAvatar;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.Button buttonSelectUser;
        private System.Windows.Forms.Button buttonEditUser;
        public TextBoxWithPlaceholder textBoxDescription;
    }
}
