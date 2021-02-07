namespace Test
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.note1 = new NotesLib.Note();
            this.note2 = new NotesLib.Note();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(164, 99);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // note1
            // 
            this.note1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.note1.Location = new System.Drawing.Point(37, 289);
            this.note1.Name = "note1";
            this.note1.Size = new System.Drawing.Size(138, 47);
            this.note1.TabIndex = 0;
            this.note1.Click += new System.EventHandler(this.SelectNote);
            // 
            // note2
            // 
            this.note2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.note2.Location = new System.Drawing.Point(366, 250);
            this.note2.Name = "note2";
            this.note2.Size = new System.Drawing.Size(138, 47);
            this.note2.TabIndex = 2;
            this.note2.Click += new System.EventHandler(this.SelectNote);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.note2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.note1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private NotesLib.Note note1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private NotesLib.Note note2;
    }
}

