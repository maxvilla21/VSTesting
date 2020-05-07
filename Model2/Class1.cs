using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model2
{
    public class Class1
    {
        public int Id_Class { get; set; }
        public string Name { get; set; }
        public string Teacher { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
