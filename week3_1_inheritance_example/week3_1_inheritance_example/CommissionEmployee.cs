using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_1_inheritance_example
{
    public class CommissionEmployee
    {
        private int _id;
        private string _name;
        private float _grossSales;
        private float _commissionRate;

        public int Id { 
            get { return _id; } 
            set { _id = value; } 
        }

        public string Name { 
            get { return _name; } 
            set { _name = value; } 
        }

        public float GrossSales { 
            get { return _grossSales; }
            set
            {
                if (value > 0)
                {
                    _grossSales = value;
                }
                else
                {
                    throw new Exception("\n Gross sales can not be negative");
                }
            }
        }

        public float CommissionRate { 
            get { return _commissionRate; } 
            set {
                if (value < 1.5 && value > 0) { _commissionRate = value; }
                else
                {
                    throw new Exception("\n commission rate  can not be negative or above 1.5");
                }
            } 
        }

        public CommissionEmployee(int id,string name,float grossSales, float commissionRate)
        {
            Id = id;
            Name = name;
            GrossSales = grossSales;   
            CommissionRate = commissionRate;

        }

        public float Earning()
        {
            return (CommissionRate * GrossSales)/100 + GrossSales;
        }

        public override string ToString()
        {
            return $"Name ={Name} \n Commision is : {_commissionRate}";
        }



    }

    

}
