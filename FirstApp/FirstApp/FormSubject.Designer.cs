namespace FirstApp
{
    partial class FormSubject
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
            this.Idlabel = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.IDNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.Location = new System.Drawing.Point(23, 27);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(20, 16);
            this.Idlabel.TabIndex = 0;
            this.Idlabel.Text = "ID";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(23, 92);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(44, 16);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Name";
            // 
            // IDNumUpDown
            // 
            this.IDNumUpDown.Location = new System.Drawing.Point(26, 46);
            this.IDNumUpDown.Name = "IDNumUpDown";
            this.IDNumUpDown.Size = new System.Drawing.Size(120, 22);
            this.IDNumUpDown.TabIndex = 5;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(26, 111);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(120, 22);
            this.NameTB.TabIndex = 6;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(26, 152);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(86, 29);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // FormSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 321);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.IDNumUpDown);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.Idlabel);
            this.Name = "FormSubject";
            this.Text = "FormSubject";
            ((System.ComponentModel.ISupportInitialize)(this.IDNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.NumericUpDown IDNumUpDown;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button SaveBtn;
    }
}