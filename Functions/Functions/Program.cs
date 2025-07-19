using System.Formats.Asn1;
using System.Runtime.InteropServices;

namespace Functions
{
    class Test
    {
        public  void something()
        {
            Console.WriteLine("new test");
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            welcomemessage();
            Test test = new Test();
            test.something();

            string a = "1";
            string b = "2";
            Console.WriteLine(a+" "+ b);
            (a,b)=(b,a);
            Console.WriteLine(a+" "+ b);
            Console.WriteLine($"Area of circel is {area(12)}");
            Console.WriteLine($"Area of rec is {area(12,39)}");
            Program prg= new Program();
            prg.fib();

            Console.WriteLine($"p checker {isPal("aba")}");

            
            Console.WriteLine(add(10, 90)) ;
            namedpara(b: 3, a: 1);
            

           

            
            
        }

        static void welcomemessage()
        {
            Console.WriteLine("hrllo fucker");
        }

        public static double area(double x, double y)
        {
            return x * y;
        }public static double area(double x)
        {
            return 3.14 * x * x;
        }

        public void fib()
        {
            int n1 = 0;
            int n2 = 1;
            Console.Write($"{n1} {n2} ");

            for (int i = 0; i < 10; i++)
            {
                
                int n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                Console.Write($"{n3} ");
            }
        }

        public static bool isPal(string word)
        {
           string newW="";
           for (int i = word.Length - 1; i >= 0; i--)
            {
                
                newW += word[i];
            }
           Console.WriteLine(newW);
            return word==newW;
        }

        public static (int,int) tet()
        {
            return (1,2);
        }

        static int add(int a,[Optional] int b) {  return a + b; }

       static void namedpara(int a,int b)
        {
            Console.WriteLine($"{a} {b}");
        }
    }
}
