using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class ProjectIWFA : Form
    {
        public ProjectIWFA()
        {
            InitializeComponent();
        }

        private void specialityTSMI_Click(object sender, EventArgs e)
        {
            FormSpecialty fSpecialty = new FormSpecialty();
            fSpecialty.ShowDialog();
        }

        private void subjectTSMI_Click(object sender, EventArgs e)
        {
            FormSubject fSubject = new FormSubject();
            fSubject.ShowDialog();
        }

        private void studentTSMI_Click(object sender, EventArgs e)
        {
            FormStudent fStudent = new FormStudent();
            fStudent.ShowDialog();
        }

        private void gradeTSMI_Click(object sender, EventArgs e)
        {
            FormGrade fGrade = new FormGrade();
            fGrade.ShowDialog();
        }

        private void specialityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewSpecialties formEditSpecialty = new FormViewSpecialties();
            formEditSpecialty.ShowDialog();
        }

        private void exitTSMI_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //private void specialityToolStripMenuItem(object sender, EventArgs e)
        //{
        //    FormEditSpecialty fEditSpeciality = new FormEditSpecialty();
        //    fEditSpeciality.ShowDialog();
        //}

    }
}
