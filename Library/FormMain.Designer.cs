
namespace Library
{
    partial class FormMain
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
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRental = new System.Windows.Forms.ListBox();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAuthors = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbReaders = new System.Windows.Forms.ListBox();
            this.btnReaders = new System.Windows.Forms.Button();
            this.btnRental = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(12, 42);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(179, 316);
            this.lbBooks.TabIndex = 0;
            this.lbBooks.SelectedIndexChanged += new System.EventHandler(this.lbBooks_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Books:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Location = new System.Drawing.Point(12, 364);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(179, 23);
            this.btnBooks.TabIndex = 3;
            this.btnBooks.Text = "More about books";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 415);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rental:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbRental
            // 
            this.lbRental.FormattingEnabled = true;
            this.lbRental.Location = new System.Drawing.Point(609, 42);
            this.lbRental.Name = "lbRental";
            this.lbRental.Size = new System.Drawing.Size(179, 316);
            this.lbRental.TabIndex = 5;
            this.lbRental.SelectedIndexChanged += new System.EventHandler(this.lbRental_SelectedIndexChanged);
            // 
            // btnAuthors
            // 
            this.btnAuthors.Location = new System.Drawing.Point(211, 364);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(179, 23);
            this.btnAuthors.TabIndex = 10;
            this.btnAuthors.Text = "More about authors";
            this.btnAuthors.UseVisualStyleBackColor = true;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Authors:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbAuthors
            // 
            this.lbAuthors.FormattingEnabled = true;
            this.lbAuthors.Location = new System.Drawing.Point(211, 42);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(179, 316);
            this.lbAuthors.TabIndex = 8;
            this.lbAuthors.SelectedIndexChanged += new System.EventHandler(this.lbAuthors_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Readers:";
            // 
            // lbReaders
            // 
            this.lbReaders.FormattingEnabled = true;
            this.lbReaders.Location = new System.Drawing.Point(411, 42);
            this.lbReaders.Name = "lbReaders";
            this.lbReaders.Size = new System.Drawing.Size(179, 316);
            this.lbReaders.TabIndex = 11;
            this.lbReaders.SelectedIndexChanged += new System.EventHandler(this.lbReaders_SelectedIndexChanged);
            // 
            // btnReaders
            // 
            this.btnReaders.Location = new System.Drawing.Point(411, 364);
            this.btnReaders.Name = "btnReaders";
            this.btnReaders.Size = new System.Drawing.Size(179, 23);
            this.btnReaders.TabIndex = 13;
            this.btnReaders.Text = "More about readers";
            this.btnReaders.UseVisualStyleBackColor = true;
            this.btnReaders.Click += new System.EventHandler(this.btnReaders_Click);
            // 
            // btnRental
            // 
            this.btnRental.Location = new System.Drawing.Point(609, 364);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(179, 23);
            this.btnRental.TabIndex = 14;
            this.btnRental.Text = "More about book rental";
            this.btnRental.UseVisualStyleBackColor = true;
            this.btnRental.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(713, 415);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Exit";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRental);
            this.Controls.Add(this.btnReaders);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbReaders);
            this.Controls.Add(this.btnAuthors);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbAuthors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRental);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBooks);
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbRental;
        private System.Windows.Forms.Button btnAuthors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbAuthors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbReaders;
        private System.Windows.Forms.Button btnReaders;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button btnRefresh;
    }
}

