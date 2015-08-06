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
    public partial class FormMain : Form
    {
        public static bool authenticated = false;
        //public static bool MainFormDetailedState = false;
        public FormMain()
        {
            InitializeComponent();
            CreateObjects();

            lbStaff.DataSource = Staff.Items.Values.ToList();
            //lbCompany.DataSource = Company.Items.Values.ToList();
            lbStaff.SelectedIndex = 0;
            lblAge.Text = Department.Items.Last().Value.ToString();
            //if (authenticated == false) Application.Exit();
        }

        private void CreateObjects()
        {
            Staff s1 = new Staff
            {
                Name = "Alexandr",
                LastName = "Kuznyak",
                Age = 30,
                Expirience = 9,
                Sallary = 2000,
                JobTitle = "Software Developer",
                Shedule = new List<string>
       {
           "Monday",
           "Tuesday",
           "Wednesday",
           "Friday",
           "Saturday",
       },
                Skills = new List<string>
       {
           "C#",
           ".NET Framework",
           "MS SQL",
       }
            };
            Staff s2 = new Staff
            {
                Name = "Marina",
                LastName = "Homa",
                Age = 20,
                Expirience = 2,
                Sallary = 500,
                JobTitle = "Saller",
                Shedule = new List<string>
       {
           "Monday",
           "Tuesday",
           "Wednesday",
           "Thursday",
           "Friday",
           "Saturday",
       },
                Skills = new List<string>
       {
           "Communicativeness",
            "Amiability",
           "Organizational skills",
       }
            };
            Staff s3 = new Staff
            {
                Name = "Alla",
                LastName = "Petrenko",
                Age = 25,
                Expirience = 3,
                Sallary = 1500,
                JobTitle = "Recruiter",
                Shedule = new List<string>
       {
           "Monday",
           "Tuesday",
           "Wednesday",
           "Friday",
           "Saturday",
       },
                Skills = new List<string>
       {
           "Organizational skills",
           "Amiability",
           "Leadership",
       }
            };
            Staff s4 = new Staff
            {
                Name = "Alexandra",
                LastName = "Alexandriyskaya",
                Age = 28,
                Expirience = 3,
                Sallary = 1500,
                JobTitle = "Marketolog",
                Shedule = new List<string>
       {
           "Monday",
           "Tuesday",
           "Wednesday",
           "Thursday",
           "Friday",
       },
                Skills = new List<string>
       {
           "Google Adwords",
           "Google Analytics",
           "Yandex Direct",
           "Universal Analytics",
       }
            };
            Staff s5 = new Staff
            {
                Name = "Michail",
                LastName = "Tsukerman",
                Age = 35,
                Expirience = 3,
                Sallary = 10000,
                JobTitle = "Team Lider",
                Shedule = new List<string>
       {
           "Monday",
           "Wednesday",
           "Thursday",
       },
                Skills = new List<string>
       {
           "C#",
           "ASP.NET", "ASP", "LINQ",
           "SQL Server 2005/2008",
           "XML and Web Services",
       }
            };

            Company c1 = new Company { Name = "Microsoft", Country = "USA", Date = new DateTime(1975, 05, 04), ServiceSector = "IT" };
            Company c2 = new Company { Name = "Macdonald's", Country = "USA", Date = new DateTime(1948, 05, 04), ServiceSector = "Catering" };
            Company c3 = new Company { Name = "Google", Country = "USA", Date = new DateTime(1975, 05, 04), ServiceSector = "IT" };

            Department d1 = new Department { Name = "IT Department" };
            Department d2 = new Department { Name = "Marketing Department" };
            Department d3 = new Department { Name = "Accounting department" };
            Department d4 = new Department { Name = "Board of directors" };
            Department d5 = new Department { Name = "Personnel Department" };
            Department d6 = new Department { Name = "Research and Development Department" };
            Department d7 = new Department { Name = "Purchasing Department" };
            Department d8 = new Department { Name = "Sales Department" };
            Department d9 = new Department { Name = "Production Department" };

            c1.department.Add(d1); c1.department.Add(d3); c1.department.Add(d8);
            c2.department.Add(d2); c2.department.Add(d4); c2.department.Add(d5);
            c3.department.Add(d6); c3.department.Add(d7); c3.department.Add(d9);

            s1.Departments.Add(c3.department[0]);
            s1.Departments.Add(c1.department[2]);
            s2.Departments.Add(c2.department[1]);
            s3.Departments.Add(c1.department[0]);
            s4.Departments.Add(c3.department[1]);
            s5.Departments.Add(c1.department[2]);

            Career cr1 = new Career(s1, c3);
            Career cr2 = new Career(s2, c2);
            Career cr3 = new Career(s3, c1);
            Career cr4 = new Career(s4, c3);
            Career cr5 = new Career(s5, c1);
            Career cr6 = new Career(s1, c1);

        }

        private void lbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = sender as ListBox;
            if (obj == null)
                return;

            var selectedStaff = obj.SelectedItem as Staff;

            if (selectedStaff != null)
            {
                //Очищаем департаменты
                lbDepartments.DataSource = null;
                lbCompany.DataSource = selectedStaff.Companies;
                //!lbDepartments.DataSource = selectedStaff.Departments;
                lblJobTitle.Text = selectedStaff.JobTitle;
                //lblSkills.ContextMenuStrip = selectedStaff.Skills;
                lblAge.Text = selectedStaff.Age.ToString();
                lblExpirience.Text = selectedStaff.Expirience.ToString();
                //lbShowShedule.Text = selectedStaff.Shedule.ToString();

            }
            else
            {
                lbShowCreationDate.Text = " ";
                lbShowServicesSector.Text = " ";
                lblJobTitle.Text = " ";
                lblSkills.Text = " ";
                lblAge.Text = " ";
                lblExpirience.Text = " ";
                //lblShedule.Text = " ";

            }
        }

        private void SelectetItemChanged(object sender, EventArgs e)
        {
            var obj = sender as ListBox;
            if (obj == null)
                return;

            var selectedCompany = obj.SelectedItem as Company;

            if (selectedCompany != null)
            {

                lbShowCreationDate.Text = selectedCompany.Date.ToString();
                lbShowServicesSector.Text = selectedCompany.ServiceSector;
            }
            else
            {
                lbShowCreationDate.Text = " ";
                lbShowServicesSector.Text = " ";
            }
        }

        private void lbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = sender as ListBox;
            if (obj == null)
                return;
            var selectedCompany = obj.SelectedItem as Company;
            if (selectedCompany != null)
            {
                //!lbStaff.DataSource = selectedCompany.staff;
                lbDepartments.DataSource = selectedCompany.department;
                //////////////////////////////////////////////////////////
                var selectedStaff = lbStaff.SelectedItem as Staff;
                for (int i = 0; i < lbDepartments.Items.Count; i++)
                    /*Меняем на один оператор
                    if (selectedStaff.Departments.Contains(lbDepartments.Items[i] as Department))
                        lbDepartments.SetItemChecked(i, true);
                    else
                        lbDepartments.SetItemChecked(i, false);
                     */
                    lbDepartments.SetItemChecked(i, selectedStaff.Departments.Contains(lbDepartments.Items[i] as Department));
                ///////////////////////////////////////////////////////////
            }
        }
        public void FormAddStaff_Load(object sender, EventArgs e)
        {
            if (lbStaff.Items.Count == 0)
            {
                btnAdd.Enabled = false;
            }
            lbStaff.DataSource = Staff.Items.Values.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Add_Staff().ShowDialog();
            RefreshlbStaff();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Staff temp = (Staff)lbStaff.SelectedItem;
            //Career.career.Remove(Career.career.Where(x => x.Staff.Id == temp.Id).FirstOrDefault());
            Career.career.RemoveAll(x => x.Staff.Id == temp.Id);
            Staff.Items.Remove(temp.Id);
            lbStaff.DataSource = null;
            lbStaff.DataSource = Staff.Items.Values.ToList();
            if (lbStaff.Items.Count == 0)
                lbCompany.DataSource = null;
        }

        private void RefreshlbStaff()
        {
            lbStaff.DataSource = null;
            lbStaff.DataSource = Staff.Items.Values.ToList();
            lbStaff.SelectedItem = selectedItems;
        }
        private void RefreshlbCompany()
        {
            lbCompany.DataSource = null;
            lbCompany.DataSource = Company.Items.Values.ToList();
            lbCompany.SelectedItem = selectedItems;
        }
        private void RefreshlbDepartments()
        {
            lbDepartments.DataSource = null;
            lbDepartments.DataSource = Department.Items.Values.ToList();
            lbDepartments.SelectedItem = selectedItems;
        }
        private void btnAddClick(object sender, EventArgs e)
        {
            new Add_Staff().ShowDialog();
            RefreshlbStaff();
        }

        //public static Staff selectedStaff = new Staff(true);


        public object selectedItems { get; set; }

        private void btAddCompany_Click(object sender, EventArgs e)
        {
            int oldIndex = lbStaff.SelectedIndex;
            new FormCompanyList().ShowDialog();
            //RefreshlbCompany();
            lbStaff_SelectedIndexChanged(lbStaff, null);
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lbDepartments_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            /*var selectedStaff = lbStaff.SelectedItem as Staff;
            if (e.NewValue == CheckState.Checked)
                selectedStaff.Departments.Add(lbDepartments.SelectedItem as Department);
        */}

        //private void lbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var obj = sender as ListBox;
        //    if (obj == null)
        //        return;
        //    var selectedDepartment = obj.SelectedItem as Department;
        //    if (selectedDepartment != null)
        //    {
        //        lbStaff.DataSource = selectedDepartment.Employers;

        //        if (selectedDepartment != null)
        //        {
        //            lbStaff.DataSource = selectedDepartment.Employers;
        //            //lbCompany.DataSource = selectedDepartment.Employers;
        //        }

        //    }
            //   }
            //private void lbCompany_SelectedIndexChanged(object sender, EventArgs e)
            //   {
            //       var obj = sender as ListBox;
            //       if (obj == null)
            //           return;
            //       var selectedCompany = obj.SelectedItem as Company;
            //    if (selectedCompany != null)
            //    {
            //        lbStaff.DataSource = selectedCompany.staff;

            //    }


        }
    }

    



          
    

