namespace FirstApp
{
    partial class FormEditSpecialty
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
            this.IDlbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.IdNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Location = new System.Drawing.Point(23, 24);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(20, 16);
            this.IDlbl.TabIndex = 0;
            this.IDlbl.Text = "ID";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(23, 81);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(44, 16);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Name";
            // 
            // IdNumUpDown
            // 
            this.IdNumUpDown.Location = new System.Drawing.Point(26, 43);
            this.IdNumUpDown.Name = "IdNumUpDown";
            this.IdNumUpDown.Size = new System.Drawing.Size(120, 22);
            this.IdNumUpDown.TabIndex = 2;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(26, 100);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(120, 22);
            this.nameTB.TabIndex = 3;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(26, 140);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(102, 23);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // FormEditSpecialty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 434);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.IdNumUpDown);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.IDlbl);
            this.Name = "FormEditSpecialty";
            this.Text = "FormEditSpecialty";
            ((System.ComponentModel.ISupportInitialize)(this.IdNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.NumericUpDown IdNumUpDown;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button SaveBtn;
    }
}