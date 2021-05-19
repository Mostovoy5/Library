
namespace Library
{
    partial class FormReader
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
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textMiddleName = new System.Windows.Forms.TextBox();
            this.nudHallNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReader = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHallNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(13, 30);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(312, 20);
            this.textName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(13, 74);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(312, 20);
            this.textSurname.TabIndex = 3;
            this.textSurname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Middle name";
            // 
            // textMiddleName
            // 
            this.textMiddleName.Location = new System.Drawing.Point(12, 113);
            this.textMiddleName.Name = "textMiddleName";
            this.textMiddleName.Size = new System.Drawing.Size(313, 20);
            this.textMiddleName.TabIndex = 5;
            // 
            // nudHallNumber
            // 
            this.nudHallNumber.Location = new System.Drawing.Point(12, 156);
            this.nudHallNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHallNumber.Name = "nudHallNumber";
            this.nudHallNumber.Size = new System.Drawing.Size(313, 20);
            this.nudHallNumber.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hall number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnReader
            // 
            this.btnReader.Location = new System.Drawing.Point(250, 199);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(75, 23);
            this.btnReader.TabIndex = 8;
            this.btnReader.Text = "Add reader";
            this.btnReader.UseVisualStyleBackColor = true;
            this.btnReader.Click += new System.EventHandler(this.btnReader_Click);
            // 
            // FormReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 236);
            this.Controls.Add(this.btnReader);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudHallNumber);
            this.Controls.Add(this.textMiddleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Name = "FormReader";
            this.Text = "FormReader";
            ((System.ComponentModel.ISupportInitialize)(this.nudHallNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMiddleName;
        private System.Windows.Forms.NumericUpDown nudHallNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReader;
    }
}