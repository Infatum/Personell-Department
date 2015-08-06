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
    public partial class FormCompanyList : Form
    {
        //public static Company selectedCompany = new Company(true);
        public object SelectedCompany { get; set; }
        public FormCompanyList()
        {
            InitializeComponent();
            lbCompanyList.DataSource = Company.Items.Values.ToList();
        }


        private void SelectetItemChanged(object sender, EventArgs e)
        {

        }
        private void lbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = sender as ListBox;
            if (obj == null)
                return;
            var selectedCompany = obj.SelectedItem as Company;
            if (selectedCompany != null)
            {
                //lbCompanyList.DataSource = selectedCompany.staff;
                SelectedCompany = selectedCompany;
                lbDeps.DataSource = selectedCompany.department;
            }
        }
        /*public void FormAddCompany_Load(object sender, EventArgs e)
        {
            if (lbCompanyList.Items.Count == 0)
            {
                btnAddCompany.Enabled = false;
            }
            lbCompanyList.DataSource = Company.Items.Values.ToList();
        }*/

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            new FormAdd_Company().ShowDialog();
            RefreshlbCompanyList();
        }

        private void btnDeleteCompany_Click(object sender, EventArgs e)
        {
            Company temp = (Company)lbCompanyList.SelectedItem;
            //!Career.career.Remove(Career.career.Where(x => x.Company.Id == temp.Id).FirstOrDefault());
            //Удаляем из Career все записи о компании
            Career.career.RemoveAll(cr => cr.Company.Id == temp.Id);
            //Удаляем компанию из списка
            Company.Items.Remove(temp.Id);
            //Вместе с компанией удаляем департаменты из списка департаментов
            //и все связи с другими классами
            foreach (Department d in temp.department)
            {
                Department.Items.Remove(d.Id);
                //можно обойтись Department.RemoveReferences(d.Id);
            }
            lbCompanyList.DataSource = null;
            lbDeps.DataSource = null;
            lbCompanyList.DataSource = Company.Items.Values.ToList();
        }

        private void RefreshlbCompanyList()
        {
            lbCompanyList.DataSource = null;
            lbCompanyList.DataSource = Company.Items.Values.ToList();
            lbCompanyList.SelectedItem = SelectedCompany;
        }

        private void RefreshlbDepsList()
        {
            lbDeps.DataSource = null;
            lbDeps.DataSource = (SelectedCompany as Company).department;
            //lbCompanyList.SelectedItem = SelectedCompany;
        }

        private void btnAssignCompany_Click(object sender, EventArgs e)
        {
            new Assign_Form(SelectedCompany as Company, lbDeps.SelectedItem as Department).ShowDialog();
            //(new Assign_Form()).SetAssign(SelectedCompany as Company);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddDepartment_Form(lbCompanyList.SelectedItem as Company).ShowDialog();
            RefreshlbDepsList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Department dep = lbDeps.SelectedItem as Department;
            Department.Items.Remove(dep.Id);
            //можно обойтись Department.RemoveReferences(dep.Id);
            (SelectedCompany as Company).department.Remove(dep);
            RefreshlbDepsList();
        }
    }
}