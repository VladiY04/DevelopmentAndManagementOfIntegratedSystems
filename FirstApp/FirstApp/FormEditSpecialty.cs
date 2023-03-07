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
    public partial class FormEditSpecialty : Form
    {

        private int id;
        public FormEditSpecialty()
        {
            InitializeComponent();
        }

        public void Init(int id, string name)
        {
            this.id = id;
            this.IdNumUpDown.Value = id;
            this.nameTB.Text = name;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            configurator.UpdateSpecialty(this.id, (int)this.IdNumUpDown.Value,
            this.nameTB.Text);
        }
    }
}
