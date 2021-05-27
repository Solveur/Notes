namespace NotesLib
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
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Content = new System.Windows.Forms.Label();
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
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbl_Content);
            this.Controls.Add(this.lbl_Header);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Note";
            this.Size = new System.Drawing.Size(150, 47);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Note_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Note_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Note_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Content;
    }
}
