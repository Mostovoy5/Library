
namespace Library
{
    partial class FormMainAuthors
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelAuthor = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(353, 416);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelAuthor
            // 
            this.btnDelAuthor.Location = new System.Drawing.Point(346, 60);
            this.btnDelAuthor.Name = "btnDelAuthor";
            this.btnDelAuthor.Size = new System.Drawing.Size(98, 23);
            this.btnDelAuthor.TabIndex = 13;
            this.btnDelAuthor.Text = "Delete Author";
            this.btnDelAuthor.UseVisualStyleBackColor = true;
            this.btnDelAuthor.Click += new System.EventHandler(this.btnDelAuthor_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(346, 31);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(98, 23);
            this.btnAddAuthor.TabIndex = 11;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Authors:";
            // 
            // lbAuthor
            // 
            this.lbAuthor.FormattingEnabled = true;
            this.lbAuthor.Location = new System.Drawing.Point(12, 31);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(328, 251);
            this.lbAuthor.TabIndex = 9;
            this.lbAuthor.SelectedIndexChanged += new System.EventHandler(this.lbAuthor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Books:";
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(12, 305);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(328, 134);
            this.lbBooks.TabIndex = 16;
            this.lbBooks.SelectedIndexChanged += new System.EventHandler(this.lbBooks_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add Author";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMainAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbBooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelAuthor);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAuthor);
            this.Name = "FormMainAuthors";
            this.Text = "FormMainAuthors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button button1;
    }
}