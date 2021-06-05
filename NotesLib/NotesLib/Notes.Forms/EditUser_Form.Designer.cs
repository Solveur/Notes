
namespace Notes.Forms
{
	partial class EditUser_Form
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
			if(disposing && (components != null))
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
			this.pictureBoxUserAvatar = new System.Windows.Forms.PictureBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.textBoxDescription = new NotesLib.TextBoxWithPlaceholder();
			this.textBoxLogin = new NotesLib.TextBoxWithPlaceholder();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserAvatar)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxUserAvatar
			// 
			this.pictureBoxUserAvatar.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxUserAvatar.Location = new System.Drawing.Point(9, 9);
			this.pictureBoxUserAvatar.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBoxUserAvatar.Name = "pictureBoxUserAvatar";
			this.pictureBoxUserAvatar.Size = new System.Drawing.Size(56, 56);
			this.pictureBoxUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxUserAvatar.TabIndex = 7;
			this.pictureBoxUserAvatar.TabStop = false;
			this.pictureBoxUserAvatar.Click += new System.EventHandler(this.pictureBoxUserAvatar_Click);
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
			this.buttonCancel.Location = new System.Drawing.Point(133, 78);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(0);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(51, 23);
			this.buttonCancel.TabIndex = 9;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonApply
			// 
			this.buttonApply.BackColor = System.Drawing.Color.Transparent;
			this.buttonApply.FlatAppearance.BorderSize = 0;
			this.buttonApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.buttonApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonApply.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonApply.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.buttonApply.Location = new System.Drawing.Point(184, 78);
			this.buttonApply.Margin = new System.Windows.Forms.Padding(0);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(48, 23);
			this.buttonApply.TabIndex = 10;
			this.buttonApply.Text = "Apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.buttonDelete.FlatAppearance.BorderSize = 0;
			this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDelete.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.buttonDelete.Location = new System.Drawing.Point(9, 78);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(0);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(50, 23);
			this.buttonDelete.TabIndex = 11;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = false;
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxDescription.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDescription.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.textBoxDescription.Location = new System.Drawing.Point(71, 42);
			this.textBoxDescription.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Placeholder = "Short description";
			this.textBoxDescription.Size = new System.Drawing.Size(161, 23);
			this.textBoxDescription.TabIndex = 8;
			this.textBoxDescription.Text = "Short description";
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxLogin.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.textBoxLogin.Location = new System.Drawing.Point(71, 9);
			this.textBoxLogin.Margin = new System.Windows.Forms.Padding(6, 0, 3, 3);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Placeholder = "Login";
			this.textBoxLogin.Size = new System.Drawing.Size(161, 25);
			this.textBoxLogin.TabIndex = 6;
			this.textBoxLogin.Text = "Login";
			// 
			// EditUser_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.ClientSize = new System.Drawing.Size(241, 110);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.pictureBoxUserAvatar);
			this.Controls.Add(this.textBoxLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "EditUser_Form";
			this.Text = "EditUser_Form";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditUser_Form_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserAvatar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private NotesLib.TextBoxWithPlaceholder textBoxDescription;
		private System.Windows.Forms.PictureBox pictureBoxUserAvatar;
		private NotesLib.TextBoxWithPlaceholder textBoxLogin;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.Button buttonDelete;
	}
}