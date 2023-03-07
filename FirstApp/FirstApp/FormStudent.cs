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
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            DataTable dTable = configurator.LoadSpecialties();
            this.SpecialityCB.DataSource = dTable;
            this.SpecialityCB.ValueMember = "id";
            this.SpecialityCB.DisplayMember = "name";
        }
        private void SaveBTN_Click(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            configurator.SaveStudent((int)this.facultyNumUpDown.Value,
            Convert.ToInt32(this.SpecialityCB.SelectedValue), this.FirstNameTB.Text,
            this.MiddleNameTB.Text, this.LastNameTB.Text, this.AddressTB.Text,
            this.PhoneTB.Text, this.EmailTB.Text);
        }
    }
}
