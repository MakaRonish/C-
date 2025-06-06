using System.Collections;

namespace week5_generic_collectionp1
{
    internal class Program
    {
        //Generic Collection
        //1:array
            //pros: type safe
            //static in size
        //2:ArrayList
            //PROS:DYNAMIC
            //DIS:UNBOXING BOXING

        //3:LIST
            //PROS:
            //DIS:
        static void Main(string[] args)
        {
            int[] intvalues = { 1, 2, 3 };

            intvalues[0]= 10;
            //intvalues[1]= "h"; compile time error

            //intvalues[3]= 20; //run time error index out of bound


            ArrayList mylist= new ArrayList();
            mylist.Add(10);
            mylist.Add("HELLO");

            List<int> mylsit = new List<int>();
            mylsit.Add(10);
            mylsit.Add(20);

            Console.WriteLine(mylsit);

            foreach (int value in mylsit) {
                Console.WriteLine(value);
            }


            List<string> strlist = new List<string>() { "1","2","hello","world"};

            foreach (string val in strlist)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine(strlist.Count);

            strlist.Add("new");
            strlist.Add("new1");
            strlist.Add("new2");
            strlist.Add("new3");
            strlist.Add("new5");

            Console.WriteLine("before remoe");
            foreach (string val in strlist)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine(strlist.Count);

            Console.WriteLine(strlist.Capacity);
            Console.WriteLine(strlist[0]);

            Console.WriteLine(strlist.Remove("new"));
            Console.WriteLine("after remoe");

            foreach (string val in strlist)
            {
                Console.WriteLine(val);
            }

            








        }
    }
}
