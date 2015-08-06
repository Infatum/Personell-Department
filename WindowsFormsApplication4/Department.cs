using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public class Department : Base<Department>
    {
        public string Name { get; set; }
        public string DeputyHeadofUnit { get; set; }
        public List<Staff> Employers
        {
            get
            {
                var result = new List<Staff>();
                foreach (var dep in Career.career)
                {
                    if (dep.Departments == this)
                        result.Add(dep.Staff);

                }
                return result;
            }
        }
        public List<Company> company
        {
            get
            {
                var result = new List<Company>();
                foreach (var comp in Career.career)
                {
                    if (comp.Departments == this)
                        result.Add(comp.Company);
                }
                return result;
            }
        }
        public override string ToString()
        {
            return Name;
        }
        
        //Удаляет все связи с другими классами
        //или же, удаляет себя из связанных классов
        public static void RemoveReferences(Guid ID)
        {
            foreach (Staff s in Staff.Items.Values)
                s.Departments.RemoveAll(dep => dep.Id == ID);
        }
    }    
}

