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
    public partial class FormGrade : Form
    {
        public FormGrade()
        {
            InitializeComponent();
        }

        private void FormGrade_Load(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            DataTable dTableStudents = configurator.LoadStudents();
            this.studentCB.DataSource = dTableStudents;
            this.studentCB.ValueMember = "fnumber";
            this.studentCB.DisplayMember = "name";
            DataTable dTableSubjects = configurator.LoadSubjects();
            this.subjectCB.DataSource = dTableSubjects;
            this.subjectCB.ValueMember = "id";
            this.subjectCB.DisplayMember = "name";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            configurator.SaveGrade(Convert.ToInt32(this.studentCB.SelectedValue),
            Convert.ToInt32(this.subjectCB.SelectedValue),
            (int)this.numUpDownFinalGrade.Value);
        }
    }
}
