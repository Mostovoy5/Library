
namespace Library
{
    partial class FormAddRental
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
            this.btnReader = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudRentalPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOfCapture = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudRentalPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReader
            // 
            this.btnReader.Location = new System.Drawing.Point(249, 196);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(75, 23);
            this.btnReader.TabIndex = 17;
            this.btnReader.Text = "Add Rental";
            this.btnReader.UseVisualStyleBackColor = true;
            this.btnReader.Click += new System.EventHandler(this.btnReader_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Rental Price";
            // 
            // nudRentalPrice
            // 
            this.nudRentalPrice.Location = new System.Drawing.Point(14, 153);
            this.nudRentalPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudRentalPrice.Name = "nudRentalPrice";
            this.nudRentalPrice.Size = new System.Drawing.Size(310, 20);
            this.nudRentalPrice.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date Return";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date Of Capture";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(12, 27);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(312, 20);
            this.textName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpDateReturn
            // 
            this.dtpDateReturn.Location = new System.Drawing.Point(12, 110);
            this.dtpDateReturn.Name = "dtpDateReturn";
            this.dtpDateReturn.Size = new System.Drawing.Size(312, 20);
            this.dtpDateReturn.TabIndex = 18;
            // 
            // dtpDateOfCapture
            // 
            this.dtpDateOfCapture.Location = new System.Drawing.Point(12, 71);
            this.dtpDateOfCapture.Name = "dtpDateOfCapture";
            this.dtpDateOfCapture.Size = new System.Drawing.Size(312, 20);
            this.dtpDateOfCapture.TabIndex = 19;
            // 
            // FormRentalAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 231);
            this.Controls.Add(this.dtpDateOfCapture);
            this.Controls.Add(this.dtpDateReturn);
            this.Controls.Add(this.btnReader);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudRentalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Name = "FormRentalAdd";
            this.Text = "FormRentalAdd";
            ((System.ComponentModel.ISupportInitialize)(this.nudRentalPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudRentalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateReturn;
        private System.Windows.Forms.DateTimePicker dtpDateOfCapture;
    }
}