using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public class Base<T> : object
        where T : Base<T>
    {
        static public Dictionary<Guid, T> Items = new Dictionary<Guid, T>();
        public Guid Id { get; set; }

        public Base()
        {
            Id = Guid.NewGuid();
            Items.Add(Id, (T)this);
        }

    }
}
