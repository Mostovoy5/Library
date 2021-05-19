
namespace Library
{
    partial class FormMainBooks
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
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDelBook = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbAuthors = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(12, 25);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(328, 251);
            this.lbBooks.TabIndex = 0;
            this.lbBooks.SelectedIndexChanged += new System.EventHandler(this.lbBooks_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Books:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(346, 25);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(98, 23);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDelBook
            // 
            this.btnDelBook.Location = new System.Drawing.Point(346, 54);
            this.btnDelBook.Name = "btnDelBook";
            this.btnDelBook.Size = new System.Drawing.Size(98, 23);
            this.btnDelBook.TabIndex = 7;
            this.btnDelBook.Text = "Delete book";
            this.btnDelBook.UseVisualStyleBackColor = true;
            this.btnDelBook.Click += new System.EventHandler(this.btnDelBook_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(346, 421);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbAuthors
            // 
            this.lbAuthors.FormattingEnabled = true;
            this.lbAuthors.Location = new System.Drawing.Point(12, 310);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(328, 134);
            this.lbAuthors.TabIndex = 9;
            this.lbAuthors.SelectedIndexChanged += new System.EventHandler(this.lbAuthors_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Authors:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Author";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMainBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAuthors);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBooks);
            this.Name = "FormMainBooks";
            this.Text = "FormBooks";
            this.Load += new System.EventHandler(this.FormMainBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDelBook;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lbAuthors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}