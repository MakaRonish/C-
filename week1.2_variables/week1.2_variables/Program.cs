namespace week1._2_variables
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //value type and refrence local variable dont have any default value but class variable has default value
            int age;
            float marks;
            string name;
            //Console.WriteLine(name);
            age = 10;
            marks = 50.59f;

            name = "ronish";

            Console.WriteLine($"Age={age}\n ");
            SayHello();

            Circle c1 =new Circle();
            int rad = c1.GetRadius();
            c1.SetRadius(30);
            Console.WriteLine(rad
                );
        }

        static void SayHello()
        {
            string day = "monday";

            Console.WriteLine($"today is { day}");
        }
    }
}
