namespace week2_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x = 10; //pass by value
            float j = 100,sum;
            //float sum = 0;
            double[] d = { 1.0, 2, 3, 4.99 }; //pass by refrence
            Console.WriteLine("Before swapping ");
            Console.WriteLine("x = " + x + "y = " + j);
            swapValues(ref x,ref j);
            Console.WriteLine("After swapping ");
            Console.WriteLine("x = " + x + "y = " + j);
            calSum(x, j, out sum);
            Console.WriteLine($"Sum of {x} and {j} is {sum}");

            string name = "ronish";
            Console.WriteLine("Before calling Method ");
            Console.WriteLine("x = " + x);
            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine("d["+i+"] =" +d[i]);
            }
            Console.WriteLine("name = " + name);
            ChangeValues(x,d,name);
            Console.WriteLine("After calling Method ");

            Console.WriteLine("x = " + x);

            foreach(double val in d)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("name = " + name);

        }

        static void swapValues(ref float x,ref float y) {
            float z = x;
             x = y;
            y = z;

        }
        static void ChangeValues(float value, double[] array, string name)
        {
            value += 10;
            array[0] = 0;
            array[1] = 0;
            array[2] = 0;
            array[3] = 0;
            name = "Rrrrr edit"; 
            Console.WriteLine("inside the method " );
            Console.WriteLine("name = " + name);

        }

        static void calSum(float x, float y,out float sum)
        {
               sum = x + y;
        }


    }
}
