
namespace Library
{
    partial class FormMainRental
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
            this.btnDelRental = new System.Windows.Forms.Button();
            this.btnAddRental = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRental = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(346, 406);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelRental
            // 
            this.btnDelRental.Location = new System.Drawing.Point(346, 51);
            this.btnDelRental.Name = "btnDelRental";
            this.btnDelRental.Size = new System.Drawing.Size(98, 23);
            this.btnDelRental.TabIndex = 13;
            this.btnDelRental.Text = "Delete Rental";
            this.btnDelRental.UseVisualStyleBackColor = true;
            this.btnDelRental.Click += new System.EventHandler(this.btnDelRental_Click);
            // 
            // btnAddRental
            // 
            this.btnAddRental.Location = new System.Drawing.Point(346, 22);
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.Size = new System.Drawing.Size(98, 23);
            this.btnAddRental.TabIndex = 11;
            this.btnAddRental.Text = "Add Rental";
            this.btnAddRental.UseVisualStyleBackColor = true;
            this.btnAddRental.Click += new System.EventHandler(this.btnAddRental_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rentals:";
            // 
            // lbRental
            // 
            this.lbRental.FormattingEnabled = true;
            this.lbRental.Location = new System.Drawing.Point(12, 22);
            this.lbRental.Name = "lbRental";
            this.lbRental.Size = new System.Drawing.Size(328, 407);
            this.lbRental.TabIndex = 9;
            // 
            // FormMainRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelRental);
            this.Controls.Add(this.btnAddRental);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRental);
            this.Name = "FormMainRental";
            this.Text = "FormBookRental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelRental;
        private System.Windows.Forms.Button btnAddRental;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbRental;
    }
}