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
    public partial class FormAdd_Company : Form
    {
        public FormAdd_Company()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Company() { 
                Name = tbName.Text,
                Date = dateTimePicker1.Value, 
                ServiceSector = tbServiceSector.Text, 
            };
            Close();
        }
    }
}
        
   