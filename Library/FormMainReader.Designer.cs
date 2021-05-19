
namespace Library
{
    partial class FormMainReader
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
            this.btnDelReader = new System.Windows.Forms.Button();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbReader = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(356, 408);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelReader
            // 
            this.btnDelReader.Location = new System.Drawing.Point(346, 51);
            this.btnDelReader.Name = "btnDelReader";
            this.btnDelReader.Size = new System.Drawing.Size(98, 23);
            this.btnDelReader.TabIndex = 13;
            this.btnDelReader.Text = "Delete Reader";
            this.btnDelReader.UseVisualStyleBackColor = true;
            this.btnDelReader.Click += new System.EventHandler(this.btnDelReader_Click);
            // 
            // btnAddReader
            // 
            this.btnAddReader.Location = new System.Drawing.Point(346, 22);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(98, 23);
            this.btnAddReader.TabIndex = 11;
            this.btnAddReader.Text = "Add Reader";
            this.btnAddReader.UseVisualStyleBackColor = true;
            this.btnAddReader.Click += new System.EventHandler(this.btnAddReader_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reader:";
            // 
            // lbReader
            // 
            this.lbReader.FormattingEnabled = true;
            this.lbReader.Location = new System.Drawing.Point(12, 22);
            this.lbReader.Name = "lbReader";
            this.lbReader.Size = new System.Drawing.Size(328, 407);
            this.lbReader.TabIndex = 9;
            this.lbReader.SelectedIndexChanged += new System.EventHandler(this.lbReader_SelectedIndexChanged);
            // 
            // FormMainReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 442);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelReader);
            this.Controls.Add(this.btnAddReader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbReader);
            this.Name = "FormMainReader";
            this.Text = "FormMainReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelReader;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbReader;
    }
}