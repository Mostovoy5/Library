
namespace Library
{
    partial class FormAddBooks
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
            this.btmAddBooks = new System.Windows.Forms.Button();
            this.dtpBook = new System.Windows.Forms.DateTimePicker();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numBookPages = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numBookPages)).BeginInit();
            this.SuspendLayout();
            // 
            // btmAddBooks
            // 
            this.btmAddBooks.Location = new System.Drawing.Point(140, 137);
            this.btmAddBooks.Name = "btmAddBooks";
            this.btmAddBooks.Size = new System.Drawing.Size(75, 23);
            this.btmAddBooks.TabIndex = 0;
            this.btmAddBooks.Text = "Add books";
            this.btmAddBooks.UseVisualStyleBackColor = true;
            this.btmAddBooks.Click += new System.EventHandler(this.btmAddBooks_Click);
            // 
            // dtpBook
            // 
            this.dtpBook.Location = new System.Drawing.Point(12, 111);
            this.dtpBook.Name = "dtpBook";
            this.dtpBook.Size = new System.Drawing.Size(203, 20);
            this.dtpBook.TabIndex = 3;
            this.dtpBook.ValueChanged += new System.EventHandler(this.dtpBook_ValueChanged);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(12, 29);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(203, 20);
            this.textName.TabIndex = 6;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pages book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Year of publication";
            // 
            // numBookPages
            // 
            this.numBookPages.Location = new System.Drawing.Point(12, 68);
            this.numBookPages.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numBookPages.Name = "numBookPages";
            this.numBookPages.Size = new System.Drawing.Size(204, 20);
            this.numBookPages.TabIndex = 5;
            this.numBookPages.ValueChanged += new System.EventHandler(this.numBookPages_ValueChanged);
            this.numBookPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numBookPages_KeyPress);
            // 
            // FormBooksAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 166);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.numBookPages);
            this.Controls.Add(this.dtpBook);
            this.Controls.Add(this.btmAddBooks);
            this.Name = "FormBooksAdd";
            this.Text = "Add Book";
            this.Load += new System.EventHandler(this.FormBooksAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBookPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmAddBooks;
        private System.Windows.Forms.DateTimePicker dtpBook;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numBookPages;
    }
}