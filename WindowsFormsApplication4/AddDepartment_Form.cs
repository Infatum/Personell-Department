using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class AddDepartment_Form : Form
    {
        private Company C;

        public AddDepartment_Form()
        {
            InitializeComponent();
        }

        public AddDepartment_Form(Company InCompany):this()
        {
            C = InCompany;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите название департамента!");
                return;
            }
            C.department.Add(new Department {Name=textBox1.Text });
            this.DialogResult = DialogResult.OK;
        }
    }
}
