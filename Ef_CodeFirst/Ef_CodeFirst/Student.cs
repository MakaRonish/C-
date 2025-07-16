using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_CodeFirst
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public int StandardId { get; set; }

        //refrence nac

        public Standard? Standard { get; set; }
    }
}
