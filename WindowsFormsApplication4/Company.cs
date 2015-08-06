using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public class Company : Base<Company>
    {
        static public List<Company> Companies = new List<Company>();
        
        public string Name { get; set;}
        public string Country { get; set; }
        public DateTime Date { get; set; }
        public string ServiceSector { get; set; }
   
       
    /* public Company(bool looseInstance)
        {
            if (looseinstance == true)
                Id = Guid.NewGuid();
        }*/
    public List<Staff> staff
        {
    get
    {
    var result = new List<Staff>();
    foreach (var job in Career.career)
    {
        if(job.Company == this)
            result.Add(job.Staff);

     }
        return result;
        }
    }
    public List<Department> department = new List<Department>();
    /*{
        get
        {
            var result = new List<Department>();
            foreach (var job in Career.career)
            {
                if (job.Company == this)
                    result.Add(job.Departments);

            }
            return result;
        }
    }*/
     public override string ToString()
    {
       return Name;
    }

  }
}
