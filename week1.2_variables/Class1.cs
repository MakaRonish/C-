using System;

public class Class1
{
	public Class1()
	{
		string check_test="Hello, My name is Ronish makaju....."

		bool hasPeriod, hasComma;
		TestString(check_test,out hasPeriod,out hasComma);

		if (hasPeriod && hasComma )
		{
			Console.WriteLine("It has both . and ,");

		}else if (hasComma)
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



    }
	staic void TestString(string str,out bool hasPeriod, out bool hasComma)
	{
		if (str.Contains('.'))
		{
			hasPeriod = true;
		}else if (str.Contains(","))
		{
			hasComma = true;
		}
	}
}
