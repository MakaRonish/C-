namespace week2_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string check_test = "Hello";
            bool hasPeriod, hasComma;
            TestString(check_test, out hasPeriod, out hasComma);

            if (hasPeriod && hasComma)
            {
                Console.WriteLine("It has both . and ,");

            }
            else if (hasComma)
            {
                Console.WriteLine("It has  ,");
            }
            else if (hasPeriod)
            {
                Console.WriteLine("It has .");
            }
            else
            {
                Console.WriteLine("It has none");
            }

            Display();
            Display(name:"hii",age:88);


        }
        static void TestString(string str, out bool hasPeriod, out bool hasComma)
        {
            hasPeriod = str.Contains('.');
            hasComma = str.Contains(',');
        }
        static void Display(string name="ronish",int age = 90)
        {
            Console.WriteLine($"name = {name} \nAge = {age}");
        }
    }
}
