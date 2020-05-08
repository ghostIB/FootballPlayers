namespace WindowsFormsApp4
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(407, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(407, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамілія";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Клас";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(407, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Save_Student);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(61, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Книга";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(97, 282);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(144, 20);
            this.textBox6.TabIndex = 13;
            this.textBox6.Visible = false;
            this.textBox6.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 38);
            this.button2.TabIndex = 14;
            this.button2.Text = "Видати книгу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.Give_Book);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(456, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 41);
            this.button3.TabIndex = 15;
            this.button3.Text = "Додати Зображення";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Show_FileDialog);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(177, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 38);
            this.button4.TabIndex = 16;
            this.button4.Text = "Забрати книгу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.Return_Book);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(303, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 38);
            this.button5.TabIndex = 17;
            this.button5.Text = "Книги учня";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.Book_List);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 420);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
    }
}