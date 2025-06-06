namespace week3_struct
{
    internal class Program
    {
        static void Main(string[] args)
            //call to constructor
            //create child class obje->

        {   //Parent object
            BaseClass baseObj= new BaseClass(); // when brackets are empty it calles the default constructor

            BaseClass baseObj1 = new BaseClass(10);

            //child object

            Childclass childclassd = new Childclass();
            
            Childclass childclass = new Childclass(10,11f);
            Console.WriteLine(baseObj);
            Console.WriteLine(childclass);// it calls tostring methiod that prints packagename.

            Console.WriteLine(childclass._x);
            
            
        }
    }
}
