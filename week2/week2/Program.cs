namespace week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter subtotal: ");
            string amount = Console.ReadLine();

            Console.WriteLine("enter disocunt: ");
            string discount =Console.ReadLine();

            float discountAmount = (float.Parse( amount) * float.Parse(discount)) / 100;
            float total = (float.Parse(amount) - discountAmount);

            Console.WriteLine("Discount :" + discountAmount);
            Console.WriteLine("Total :" + (float.Parse(amount) - discountAmount).ToString("c"));
         

        }

        public void printtt(int a, int b)
        {
            Console.WriteLine(a + " " + b);
        }

    }
}
