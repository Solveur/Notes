
namespace NotesLib
{
    partial class AddUser_Panel
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
			this.pictureBoxUserAvatar = new System.Windows.Forms.PictureBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			this.textBoxDescription = new NotesLib.TextBoxWithPlaceholder();
			this.textBoxLogin = new NotesLib.TextBoxWithPlaceholder();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserAvatar)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxUserAvatar
			// 
			this.pictureBoxUserAvatar.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxUserAvatar.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBoxUserAvatar.Image = global::NotesLib.Properties.Resources.NoImage;
			this.pictureBoxUserAvatar.Location = new System.Drawing.Point(1, 1);
			this.pictureBoxUserAvatar.Name = "pictureBoxUserAvatar";
			this.pictureBoxUserAvatar.Size = new System.Drawing.Size(56, 56);
			this.pictureBoxUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxUserAvatar.TabIndex = 1;
			this.pictureBoxUserAvatar.TabStop = false;
			this.pictureBoxUserAvatar.Click += new System.EventHandler(this.pictureBox_Click);
			this.pictureBoxUserAvatar.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
			this.pictureBoxUserAvatar.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
			this.buttonCancel.FlatAppearance.BorderSize = 0;
			this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonCancel.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.buttonCancel.Location = new System.Drawing.Point(209, 31);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(60, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = false;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			this.buttonCancel.MouseEnter += new System.EventHandler(this.buttonCancel_MouseEnter);
			this.buttonCancel.MouseLeave += new System.EventHandler(this.buttonCancel_MouseLeave);
			// 
			// buttonApply
			// 
			this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonApply.BackColor = System.Drawing.Color.Transparent;
			this.buttonApply.FlatAppearance.BorderSize = 0;
			this.buttonApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.buttonApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonApply.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonApply.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.buttonApply.Location = new System.Drawing.Point(209, 4);
			this.buttonApply.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(60, 23);
			this.buttonApply.TabIndex = 4;
			this.buttonApply.Text = "Apply";
			this.buttonApply.UseVisualStyleBackColor = false;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			this.buttonApply.MouseEnter += new System.EventHandler(this.buttonApply_MouseEnter);
			this.buttonApply.MouseLeave += new System.EventHandler(this.buttonApply_MouseLeave);
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxDescription.Font = new System.Drawing.Font("Cambria", 12F);
			this.textBoxDescription.ForeColor = System.Drawing.Color.Gray;
			this.textBoxDescription.Location = new System.Drawing.Point(63, 33);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Placeholder = "Short description";
			this.textBoxDescription.Size = new System.Drawing.Size(140, 19);
			this.textBoxDescription.TabIndex = 5;
			this.textBoxDescription.Text = "Short description";
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxLogin.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLogin.ForeColor = System.Drawing.Color.Gray;
			this.textBoxLogin.Location = new System.Drawing.Point(63, 4);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Placeholder = "Login";
			this.textBoxLogin.Size = new System.Drawing.Size(140, 23);
			this.textBoxLogin.TabIndex = 0;
			this.textBoxLogin.Text = "Login";
			// 
			// AddUser_Panel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.pictureBoxUserAvatar);
			this.Controls.Add(this.textBoxLogin);
			this.Margin = new System.Windows.Forms.Padding(1);
			this.Name = "AddUser_Panel";
			this.Padding = new System.Windows.Forms.Padding(1);
			this.Size = new System.Drawing.Size(273, 58);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserAvatar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private TextBoxWithPlaceholder textBoxLogin;
        private System.Windows.Forms.PictureBox pictureBoxUserAvatar;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonApply;
        private TextBoxWithPlaceholder textBoxDescription;
	}
}
