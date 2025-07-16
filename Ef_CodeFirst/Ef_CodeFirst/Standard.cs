using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_CodeFirst
{
    public class Standard
    {
        public int StandardId {  get; set; }    
        public string? StandardName { get; set; }

        //Navigation

        public ICollection<Student>? Students { get; set; }
    }
}
