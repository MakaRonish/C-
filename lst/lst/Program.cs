namespace lst
{
    public class Program
    {
        static void Main(string[] args)
        {
            // List<int> ListNumber = new List<int>()
            // {
            //     1,2,3,4,5
            // };

            // foreach(int i in ListNumber)
            // {
            //     Console.WriteLine(i);
            // }


            // Dictionary<string, string> names = new Dictionary<string, string>()
            // {
            //     {"1","a" },
            //     {"2","b" },
            //     {"3","c" },
            // };

            // names.Add("new", "d");

            //foreach(var name in names.Values)
            // {
            //     Console.WriteLine(name);
            // }


            // bool success=names.Remove("1");
            // Console.WriteLine(success);

            //List<int> even = new List<int>();
            //List<int> odd = new List<int>();

            //Console.Write("Enter the start of the range :");
            //bool success = int.TryParse(Console.ReadLine(), out int startIndex);
            //Console.Write("Enter the end of the range :");
            //bool success2 = int.TryParse(Console.ReadLine(), out int endIndex);

            //if ((success && success2)&& (startIndex<endIndex))
            //{
            //    for(int i = startIndex; i < endIndex + 1; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            even.Add(i);
            //        }
            //        else
            //        {
            //            odd.Add(i);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect indexs");
            //}

            //Console.WriteLine("Even numbers");
            //foreach(int i in even)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Odd numbers");
            //foreach(int i in odd)
            //{
            //    Console.WriteLine(i);
            //}

            Console.Write("Enter the number :");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Length :");
            int Length=Convert.ToInt32(Console.ReadLine()); 
            List<int> multi = new List<int>();

            for (int i = 1; i <= Length; i++)
            {
                multi.Add(num * i);
            }

            foreach (int i in multi)
            {
                Console.Write(i + " ");
            }
            
           

        }
    }
}
