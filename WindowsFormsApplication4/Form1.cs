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
    public partial class Add_Staff : Form
    {
        public Add_Staff()
        {
            InitializeComponent();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            new Staff() { Name = tbName.Text, LastName = tbLastName.Text, JobTitle = tbJobTitle.Text, Expirience = Int32.Parse(tbExperience.Text), Sallary = Int32.Parse(tbSallary.Text) };
            Close();

        }
    }
}
