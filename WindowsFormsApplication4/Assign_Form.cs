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
    public partial class Assign_Form : Form
    {
        private Company C;
        private Department D;
        private bool formIsLoad = false;

        public Assign_Form()
        {
            InitializeComponent();

        }
        public Assign_Form(Company c, Department d): this()
        {
            C = c;
            D = d;
            //chblCompany.Items.AddRange(Staff.Items.Values.ToArray());
            chblCompany.DataSource = Staff.Items.Values.ToList();
            for (int i = 0; i < chblCompany.Items.Count; i++)
            {
                if ((chblCompany.Items[i] as Staff).Departments.Contains(D))
                    chblCompany.SetItemChecked(i, true);
            }
            formIsLoad = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* foreach (var s in chblCompany.CheckedItems)
            {
                Career cr = new Career(s as Staff, C);
            }*/
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void chblCompany_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!formIsLoad) return;

            if (e.CurrentValue == CheckState.Checked)
            {
                Career.career.RemoveAll(cr => (cr.Staff.Id == (chblCompany.SelectedItem as Staff).Id) && (cr.Company.Id == C.Id));
                (chblCompany.SelectedItem as Staff).Departments.Remove(D);
            }
            else
            {
                //Проверяем наличие в списке Career комбинации Сотрудника и Компании
                if (!Career.career.Exists(cr => (cr.Staff.Id == (chblCompany.SelectedItem as Staff).Id) && (cr.Company.Id == C.Id)))
                    Career.career.Add(new Career(chblCompany.SelectedItem as Staff, C));
                (chblCompany.SelectedItem as Staff).Departments.Add(D);
            }
        }
    }
}
