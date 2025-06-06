namespace week3_1_inheritance_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommissionEmployee Employee1 = new CommissionEmployee(1, "Ronish", 1000f, 0.99f);
            Console.WriteLine(Employee1);
            Console.WriteLine(Employee1.Earning());
            SalaryPlusCommissionEmployee Employee2 = new SalaryPlusCommissionEmployee(1, "Ronish Makaju", 1000f, 0.99f,99999);
            Console.WriteLine(Employee2);
            Console.WriteLine(Employee2.Earning());
        }
    }
}
