using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public class Career
    {
        static public List<Career> career = new List<Career>();
        private Guid _staffId;
        private Guid _companyId;
        private Guid _departmentId;

        public Staff Staff
        {
            get
            {
                return Staff.Items[_staffId];
            }
            set {_staffId = value.Id;}
            }
        public Company Company
        {
            get 
            {
                return Company.Items[_companyId];
            }
            set
            { _companyId = value.Id; }
        }
        public Department Departments
        {
            get
            {
                return Department.Items[_departmentId];
            }
            set 
            {
                _departmentId = value.Id;
            }
        }

        public Career( Staff  s, Company  c)
         {
             Staff = s; Company = c; //Departments = d;
             career.Add(this);
         }

         }
}
   
 


