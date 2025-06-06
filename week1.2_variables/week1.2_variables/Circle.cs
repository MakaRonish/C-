using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1._2_variables
{
    internal class Circle
    {
        private int radius;
        //we dont use getter and setter in c#

        public int GetRadius()
        {
            return radius;
        }

        public void SetRadius(int radius)

        {
            //this represent the global
            this.radius = radius;
            
        }
    }
}
