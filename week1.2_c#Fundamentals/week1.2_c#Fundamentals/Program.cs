namespace week1._2_c_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable  declaratoin and initializatoin
            int? age =10; //declaratoin and initializatoin INT is NON-NUllable
            double? marks; //declaratoin  double is Non-nullable
            float var1 = 10.56f;
            decimal var2 = 10.45m;
            string name="ronish", last = "Makaju";



            //type inference
            //var value1; //error need to initialized for var

            var value1 = 34.6;
            Console.WriteLine( $"Data type is : {value1.GetType()}");


            string full = name + " " + last;
            Console.WriteLine($"first name {name} and last name {last} so full name is {full}");
            Console.WriteLine($"{name,-10} {last,10}");
            marks = 99.99;

            // ? makes it nullable datatype


            const int passinggrade = 50;

            
            age = null;
            marks = null;
            name = null;



            int num, square;
            Console.WriteLine("Number");
            num = int.Parse(Console.ReadLine());
            square = num * num;
            Console.WriteLine(square);

            //varbatim string literal / escape key
            Console.WriteLine("Type \"x\" for exit");
            Console.WriteLine("Use \\n for new line");
            Console.WriteLine(@"hello  \n \p \g \d");



            //exe 2

            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int j = 0;
            //Random rnd= new Random();
            //while (j < 10)

            //{
            //    Console.WriteLine("Random num " + j);
            //    Console.WriteLine(rnd.Next(1, 100));
            //    j++;
            //};
        }                           
    }
}
