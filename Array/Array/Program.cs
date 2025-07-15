namespace Arrayy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[3];
            //for (int i = 0;i< 3; i++)
            //{
            //    Console.Write($"Enter number {i+1}");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine(numbers);

            //foreach(int num in numbers)
            //{
            //    Console.Write(num+", ");
            //}

            //    double[] angles = new double[3];

            //    for(int i=0; i < angles.Length; i++)
            //    {
            //        Console.Write($"Enter the angle {i+1}");
            //        bool success = double.TryParse(Console.ReadLine(), out angles[i]);
            //        if (!success) {
            //            Console.WriteLine("Enter correct angle pls");
            //            break;
            //        }
            //    }
            //    double sum=0;

            //    foreach(double angle in angles)
            //    {
            //        sum += angle;
            //    }
            //    Console.WriteLine(sum.Equals(180) ? "Traingle " : "Not triangle");

            //}

            int[] numbers =new int[] { 9,8,7,6};
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            ;

            string test = "Ronish Makaju";
            string a=test.Replace(" ", "");
            Console.WriteLine(test);
            Console.WriteLine(a);

            int p1 = 0;
            int p2 = numbers.Length - 1;
            while (p2>p1)
            {
                int temp = numbers[p1];
                numbers[p1] = numbers[p2];
                numbers[p2] = temp;
                p1++;
                p2--;
            
            }
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            int numToFind = 6;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].Equals(numToFind))
                {
                    Console.WriteLine($"index is {i}");
                } 
            }
            

        }
    }
}
