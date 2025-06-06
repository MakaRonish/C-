namespace week4_generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AreEquals(400, 400));
            Console.WriteLine(AreEquals(400.33, 400.33));
            Console.WriteLine(AreEquals(40.1f, 400));
            Console.WriteLine(AreEquals("400", "400"));

            int[] array = { 1, 2, 3 };
            string[] array2 = { "a", "b", "c" };
            float[] array3 = { 1.2f, 2.4f, 3.4f };
            printarray(array);
            printarray(array2);
            printarray(array3);
        }

        //method to compare two calues
        //static bool AreEquals(int a, int b)
        //{

        //    return a==b;
        //}
        //static bool AreEquals(double a, double b)
        //{

        //    return a == b;
        //}


        // this has a lot of disadvantages it is not type safe
        //cpu has to do a lot of extra work like boxing to object then unboxing
        static bool AreEquals(object a, object b)
        {
            //return a == b;
            //object ma == checks for refrence

            return a.Equals(b);
        }

        static bool genericAreEqual<g,c>(g a, c b)
        {
            return a.Equals(b);
        }

        static void printarray<T>(T[] array)
        {
            foreach(T member in array)
            {
                Console.WriteLine(member);
            }
        }
    }
}
