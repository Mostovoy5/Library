
namespace Library
{
    partial class FormAddAuthors
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
            this.Middel = new System.Windows.Forms.Label();
            this.textMiddleName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPseudonym = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Middel
            // 
            this.Middel.AutoSize = true;
            this.Middel.Location = new System.Drawing.Point(11, 86);
            this.Middel.Name = "Middel";
            this.Middel.Size = new System.Drawing.Size(67, 13);
            this.Middel.TabIndex = 17;
            this.Middel.Text = "Middle name";
            // 
            // textMiddleName
            // 
            this.textMiddleName.Location = new System.Drawing.Point(11, 102);
            this.textMiddleName.Name = "textMiddleName";
            this.textMiddleName.Size = new System.Drawing.Size(243, 20);
            this.textMiddleName.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(180, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Add Author";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pseudonym";
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(11, 47);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(49, 13);
            this.text.TabIndex = 13;
            this.text.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // textPseudonym
            // 
            this.textPseudonym.Location = new System.Drawing.Point(11, 141);
            this.textPseudonym.Name = "textPseudonym";
            this.textPseudonym.Size = new System.Drawing.Size(243, 20);
            this.textPseudonym.TabIndex = 11;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(12, 63);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(243, 20);
            this.textSurname.TabIndex = 10;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(11, 24);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(243, 20);
            this.textName.TabIndex = 9;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // FormAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 212);
            this.Controls.Add(this.Middel);
            this.Controls.Add(this.textMiddleName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPseudonym);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Name = "FormAuthors";
            this.Text = "FormAuthors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Middel;
        private System.Windows.Forms.TextBox textMiddleName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPseudonym;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textName;
    }
}