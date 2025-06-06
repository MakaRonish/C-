using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_struct
{

    //call to Constructor
    public class BaseClass


    {

        public float _x;
        //cunstroctor name is same as class name and no return type not even void and it will be public
        public BaseClass()
        {
            Console.WriteLine("Base Class: Default Constructor");
        }
        public BaseClass(float a)
        {
            _x= a;
            Console.WriteLine("Base Class: parameter Constructor");
        }
        //override ToString()

        public override string ToString()
        {
            return $"muji k print garra le value {_x} from baseclass";
        }
    }

    public class Childclass : BaseClass
    {
        int _val1;
        public Childclass():base()
        {
            Console.WriteLine("Child class:Default Constructor");
        }
        public Childclass(int val1,float x):base(x)
        {
            Console.WriteLine("Child class:Parameter Constructor");
            _val1 = val1;
        }

        public override string ToString()
        {
            return $"muji k print garra le value {_val1} and {_x} from childclass";
        }
    }
}
