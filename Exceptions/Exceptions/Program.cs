namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("number");
            //        int a = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine(a); 
            //        break;

            //    }
            //    //catch (FormatException)
            //    //{
            //    //    Console.WriteLine("pls only enter number");
            //    //}
            //    //catch (OverflowException)
            //    //{
            //    //    Console.WriteLine("pls enter number less than 2 billion");
            //    //}
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);

            //    }
            //}


            
            bool converted = false;
            int num=0;
            while (!converted)
            {
                Console.Write("Enter a number :");
                converted = tryp(Console.ReadLine(), out  num);
            }

            Console.WriteLine($"THe number you entered is {num}");
             
            

            static bool tryp(string word,out int num)
            {
                num = default;
                try
                {
                    num = Convert.ToInt32(word);
                    return true;
                }
                catch (Exception e) {
                    Console.WriteLine($"Error : {e.Message}");
                    return false;
                }
            }
        }
    }
}
