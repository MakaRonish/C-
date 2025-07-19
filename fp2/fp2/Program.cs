using System.Linq.Expressions;
using System.Numerics;

namespace fp2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //bool success = test(out string num);
            //List<int> list = new List<int>()
            //{
            //    99,34,54,213,5
            //};

            //bool result = indexFinser(list, out int index, 0);
            //Console.WriteLine(result);
            //Console.WriteLine(index);


            //int num = 10;
            //assign(ref num);
            //Console.WriteLine(num);


            //double areaofrec=areaOfT(weidth: userData("Enter the weidth :"), height: userData("Enter the height :"));

            //Console.WriteLine(areaofrec);

            double numberOfnum = userData("How many number:");
            List<double> nums = new List<double>();
            fillArray(ref nums, numberOfnum);
            sumarray(out double sum, nums);
            Console.WriteLine(sum);

        }


        //static bool test(out string num)
        //{
        //    num = "5";
        //    return true;
        //}

        //static bool indexFinser(List <int> name,out int index,int num)
        //{
        //    for (int i = 0; i < name.Count; i++)
        //    {
        //        if (name[i] == num)
        //        {
        //            index = i;
        //            return true;
        //        }
        //    }
        //    index = -1;
        //    return false;


        //}
        static void fillArray(ref List<double> nums,double count) { 
            for (int i = 0; i < count; i++)
            {

                nums.Add(userData($"Enter the {i + 1} num :"));
            }
        }

        static void sumarray(out double sum,List<double> lst) {
            sum = 0;
            foreach(double d in lst)
            {
                sum += d;
            }
            
        }
        static double userData(string Prompt)
        {
            Console.WriteLine(Prompt);
            return Convert.ToDouble(Console.ReadLine());

        }

        //static void assign(ref int num)
        //{
            
        //}

        //static double areaOfT(double weidth,double height)
        //{
        //    return weidth * height;
        //}






    }
}
