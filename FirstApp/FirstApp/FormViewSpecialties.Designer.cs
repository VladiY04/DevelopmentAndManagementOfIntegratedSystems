namespace FirstApp
{
    partial class FormViewSpecialties
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
            this.FormViewSpecialityDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FormViewSpecialityDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // FormViewSpecialityDGV
            // 
            this.FormViewSpecialityDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FormViewSpecialityDGV.Location = new System.Drawing.Point(12, 12);
            this.FormViewSpecialityDGV.Name = "FormViewSpecialityDGV";
            this.FormViewSpecialityDGV.RowHeadersWidth = 51;
            this.FormViewSpecialityDGV.RowTemplate.Height = 24;
            this.FormViewSpecialityDGV.Size = new System.Drawing.Size(880, 487);
            this.FormViewSpecialityDGV.TabIndex = 0;
            // 
            // FormViewSpecialties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 553);
            this.Controls.Add(this.FormViewSpecialityDGV);
            this.Name = "FormViewSpecialties";
            this.Text = "FormViewSpecialties";
            this.Load += new System.EventHandler(this.FormViewSpecialties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormViewSpecialityDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FormViewSpecialityDGV;
    }
}