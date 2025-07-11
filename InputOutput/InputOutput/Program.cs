using System.Diagnostics.CodeAnalysis;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //const int curYear= 2025;
            //string name;

            //Console.Write("Enter your name: ");

            //name = Console.ReadLine();

            //Console.Write("Age: ");
            //int age =Convert.ToInt32( Console.ReadLine());

            //Console.WriteLine($"Your name is {name} and you are {age} year old");
            //int Birthyear = curYear - age;

            //Console.Write("enter any year after your birth: ");

            //int expectedyear = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"You will be {expectedyear-Birthyear} year old in {expectedyear}");

            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //bool isprime = true;
            //for (int i=2;i<=num/2 + 1; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        isprime = false;
            //        break;
            //    }
            //}

            //if (num==0 || num == 1)
            //{
            //    Console.WriteLine("Enter number greater than 1");
            //}else if (num % 2 == 0)
            //{
            //    Console.WriteLine($"{num} is even and Prime={isprime}");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is odd and Prime={isprime}");

            //}

            //Console.Write("Enter a day of week: ");
            //int day=Convert.ToInt32(Console.ReadLine());

            //switch (day)
            //{
            //    case 1: Console.WriteLine("Mon");
            //        break;
            //    default:Console.WriteLine("it is not 1");break;

            //}
            //for (int i = 0; i <= 10; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            //bool runloop = true;

            //while (runloop)
            //{
            //    Console.WriteLine("Enter this Ronish: ");
            //    string name= Console.ReadLine();
            //    if (name == "Ronish")
            //    {
            //        break;
            //    }
            //}

            //Console.Write("age:");
            //int age =Convert.ToInt32(Console.ReadLine());

            //string adult = age > 18 ? "congrats you can go to club" : "Sorry cant let you in";
            //Console.WriteLine(adult);


            //double num = 90.091234D;
            //Console.WriteLine(num);
            //Console.WriteLine(string.Format("{0:0.0}",num));

            //double money = 100d / 3d;
            //Console.WriteLine(money.ToString("c8"));
            //Console.WriteLine(money);

            //int age;
            //bool success =int.TryParse(Console.ReadLine(), out age);
            //Console.WriteLine(success);
            //Console.WriteLine(age);


            //bool passed;
            //do
            //{
            //    Console.Write("Enter a valid number:");
            //    passed = int.TryParse(Console.ReadLine(), out int num);
            //} while (!passed);


            //while (true)
            //{
            //    Console.Write("Enter a number for table:");
            //    bool isnum = int.TryParse(Console.ReadLine(), out int num);
            //    if (isnum)
            //    {
            //        for (int i = 0; i <= 10; i++)
            //        {
            //            Console.WriteLine($"{num} * {i} = {num * i:f2}");
            //        }
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid number pls write a valid number !!!");
            //    }
            //}
            while (true)
            {
                bool success = double.TryParse(Console.ReadLine(), out double number);
                if (success)
                {
                    if (number % 3 == 0 && number % 5 == 0)
                    {
                        Console.WriteLine("fizzbuzz");
                    }
                    else if (number % 3 == 0)
                    {
                        Console.WriteLine("fizz");

                    }
                    else if (number % 5 == 0)
                    {
                        Console.WriteLine("buxx");

                    }
                    else
                    {
                        Console.WriteLine(number);
                    }
                }
            }

        }
    }
}
