using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public class Staff : Base<Staff>
    {
        static public List<Staff> staff = new List<Staff>();
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Expirience { get; set; }
        public int Sallary { get; set; }
        public string JobTitle { get; set; }
        public List<string> Shedule = new List<string>();
        public List<string> Skills = new List<string>();

       /* public Staff(bool looseInstance)
        {
            if (looseInstance == true)
                Id = Guid.NewGuid();
        }*/
        public List<Company> Companies 
        {
            get
            {
            var result = new List<Company>();
            foreach ( var job in Career.career )
                {
                    if (job.Staff == this)
                        result.Add(job.Company);
                }
            return result;
            }
        }
        public List<Department> Departments = new List<Department>();
        /*{
            get
            {
                var result = new List<Department>();
                foreach(var dep in Career.career)
                 {
                    if (dep.Staff == this)
                        result.Add(dep.Departments);
                 }
                return result;
          }
      }*/
        public override string ToString()
        {
            return Name + ' ' + LastName;
        }
    }
}
