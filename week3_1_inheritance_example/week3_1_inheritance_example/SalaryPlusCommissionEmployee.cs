using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_1_inheritance_example
{
    public class SalaryPlusCommissionEmployee: CommissionEmployee
    {
        float _salary;

        public float Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Salary can not be negative");
                }
                else
                {
                    _salary = value;
                }
            }  
        }

        public SalaryPlusCommissionEmployee(int id,string name, float grossSales, float commrate, float salary):base(id,name,grossSales,commrate)
        {
            Salary = salary;
        }
        public float Earning()
        {
            return Salary + (base.Earning());
        }

        public override string ToString() {
            return $"{base.ToString()}\n salary :{Salary}";
        }

    }
}
