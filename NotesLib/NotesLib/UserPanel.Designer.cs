
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
            this.UserAvatar = new System.Windows.Forms.PictureBox();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.buttonSelectUser = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.textBoxDecription = new NotesLib.TextBoxWithPlaceholder();
            ((System.ComponentModel.ISupportInitialize)(this.UserAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // UserAvatar
            // 
            this.UserAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserAvatar.Image = global::NotesLib.Properties.Resources.NoImage;
            this.UserAvatar.InitialImage = null;
            this.UserAvatar.Location = new System.Drawing.Point(1, 1);
            this.UserAvatar.Name = "UserAvatar";
            this.UserAvatar.Size = new System.Drawing.Size(55, 55);
            this.UserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserAvatar.TabIndex = 0;
            this.UserAvatar.TabStop = false;
            this.UserAvatar.Click += new System.EventHandler(this.pictureBox_Click);
            this.UserAvatar.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.UserAvatar.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserLogin.Location = new System.Drawing.Point(62, 4);
            this.labelUserLogin.Margin = new System.Windows.Forms.Padding(3);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(83, 20);
            this.labelUserLogin.TabIndex = 1;
            this.labelUserLogin.Text = "Username";
            // 
            // buttonSelectUser
            // 
            this.buttonSelectUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSelectUser.FlatAppearance.BorderSize = 0;
            this.buttonSelectUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonSelectUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonSelectUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectUser.Location = new System.Drawing.Point(208, 30);
            this.buttonSelectUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.buttonSelectUser.Name = "buttonSelectUser";
            this.buttonSelectUser.Size = new System.Drawing.Size(61, 23);
            this.buttonSelectUser.TabIndex = 2;
            this.buttonSelectUser.Text = "Select";
            this.buttonSelectUser.UseVisualStyleBackColor = false;
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEditUser.FlatAppearance.BorderSize = 0;
            this.buttonEditUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditUser.Location = new System.Drawing.Point(208, 2);
            this.buttonEditUser.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(61, 23);
            this.buttonEditUser.TabIndex = 4;
            this.buttonEditUser.Text = "Edit";
            this.buttonEditUser.UseVisualStyleBackColor = false;
            // 
            // textBoxDecription
            // 
            this.textBoxDecription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDecription.ForeColor = System.Drawing.Color.Gray;
            this.textBoxDecription.Location = new System.Drawing.Point(62, 30);
            this.textBoxDecription.Name = "textBoxDecription";
            this.textBoxDecription.Placeholder = "Short description";
            this.textBoxDecription.Size = new System.Drawing.Size(141, 20);
            this.textBoxDecription.TabIndex = 3;
            this.textBoxDecription.Text = "Short description";
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.textBoxDecription);
            this.Controls.Add(this.buttonSelectUser);
            this.Controls.Add(this.labelUserLogin);
            this.Controls.Add(this.UserAvatar);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UserPanel";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(273, 57);
            ((System.ComponentModel.ISupportInitialize)(this.UserAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UserAvatar;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.Button buttonSelectUser;
        private TextBoxWithPlaceholder textBoxDecription;
        private System.Windows.Forms.Button buttonEditUser;
    }
}
