namespace FirstApp
{
    partial class FormGrade
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
            this.StudentLbl = new System.Windows.Forms.Label();
            this.subjectLbl = new System.Windows.Forms.Label();
            this.finalGradeLbl = new System.Windows.Forms.Label();
            this.studentCB = new System.Windows.Forms.ComboBox();
            this.subjectCB = new System.Windows.Forms.ComboBox();
            this.numUpDownFinalGrade = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownFinalGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentLbl
            // 
            this.StudentLbl.AutoSize = true;
            this.StudentLbl.Location = new System.Drawing.Point(39, 37);
            this.StudentLbl.Name = "StudentLbl";
            this.StudentLbl.Size = new System.Drawing.Size(52, 16);
            this.StudentLbl.TabIndex = 0;
            this.StudentLbl.Text = "Student";
            // 
            // subjectLbl
            // 
            this.subjectLbl.AutoSize = true;
            this.subjectLbl.Location = new System.Drawing.Point(39, 93);
            this.subjectLbl.Name = "subjectLbl";
            this.subjectLbl.Size = new System.Drawing.Size(52, 16);
            this.subjectLbl.TabIndex = 1;
            this.subjectLbl.Text = "Subject";
            // 
            // finalGradeLbl
            // 
            this.finalGradeLbl.AutoSize = true;
            this.finalGradeLbl.Location = new System.Drawing.Point(39, 150);
            this.finalGradeLbl.Name = "finalGradeLbl";
            this.finalGradeLbl.Size = new System.Drawing.Size(75, 16);
            this.finalGradeLbl.TabIndex = 2;
            this.finalGradeLbl.Text = "Final grade";
            // 
            // studentCB
            // 
            this.studentCB.FormattingEnabled = true;
            this.studentCB.Location = new System.Drawing.Point(42, 56);
            this.studentCB.Name = "studentCB";
            this.studentCB.Size = new System.Drawing.Size(121, 24);
            this.studentCB.TabIndex = 3;
            // 
            // subjectCB
            // 
            this.subjectCB.FormattingEnabled = true;
            this.subjectCB.Location = new System.Drawing.Point(42, 112);
            this.subjectCB.Name = "subjectCB";
            this.subjectCB.Size = new System.Drawing.Size(121, 24);
            this.subjectCB.TabIndex = 4;
            // 
            // numUpDownFinalGrade
            // 
            this.numUpDownFinalGrade.Location = new System.Drawing.Point(42, 170);
            this.numUpDownFinalGrade.Name = "numUpDownFinalGrade";
            this.numUpDownFinalGrade.Size = new System.Drawing.Size(120, 22);
            this.numUpDownFinalGrade.TabIndex = 5;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(42, 209);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // FormGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 383);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.numUpDownFinalGrade);
            this.Controls.Add(this.subjectCB);
            this.Controls.Add(this.studentCB);
            this.Controls.Add(this.finalGradeLbl);
            this.Controls.Add(this.subjectLbl);
            this.Controls.Add(this.StudentLbl);
            this.Name = "FormGrade";
            this.Text = "FormGrade";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownFinalGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentLbl;
        private System.Windows.Forms.Label subjectLbl;
        private System.Windows.Forms.Label finalGradeLbl;
        private System.Windows.Forms.ComboBox studentCB;
        private System.Windows.Forms.ComboBox subjectCB;
        private System.Windows.Forms.NumericUpDown numUpDownFinalGrade;
        private System.Windows.Forms.Button saveBtn;
    }
}