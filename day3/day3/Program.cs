namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string Path = "C:\\Users\\Username\\Documents\\example.txt";
            //Console.WriteLine(Path);
            //string path = @"C:\\Users\\Username\\Documents\\example.txt";
            //Console.WriteLine(path);
            //Console.WriteLine("p1={0} \n p1={1}",Path,path);


            //Console.WriteLine("name");
            //string emp = Console.ReadLine();
            //if (emp != string.Empty)
            //{
            //    Console.WriteLine("not emp");
            //}
            //else
            //{
            //    Console.WriteLine("emp");
            //}


            //Console.Write("Enter a word:");
            //string user_Word=Console.ReadLine();
            //if (!string.IsNullOrEmpty(user_Word))
            //{
            //    int i = 0;
            //    int j = user_Word.Length-1;
            //    while (j >= 0)
            //    {

            //    }
            //}


            Console.Write("Enter the password:");
            string p1=Console.ReadLine();
            Console.Write("Enter the password again:");
            string p2=Console.ReadLine();

            if (!string.IsNullOrEmpty(p1) && !string.IsNullOrEmpty(p2)) 
            {
                if (p1.Equals(p2) && p1.Contains("@"))
                {
                    Console.WriteLine("They Match");
                }
                else {
                    Console.WriteLine("They do not Match");
                }



            }
            else
            {
                Console.WriteLine("it cannot be empty");
            }
            
        }
    }
}
