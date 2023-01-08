// A02 "Catch" block and filters https://metanit.com/sharp/tutorial/2.28.php
using p = System.Console; // alias

namespace Metanit_05_Exceptions
{

    internal class A02_CatchAndFilters
    {
        static void Main(string[] args)
        {
            p.WriteLine("Hello filters");
            p.WriteLine();
            p.WriteLine("Filter by TYPE of exception");
            try
            {
                int x = 5;
                int y = x / 0;
                p.WriteLine($"Result is: {y}");
            }
            catch (DivideByZeroException e)
            {
                p.WriteLine("An EXCEPTION is appear. It just hudled this. " + e.Message);
            }

            p.WriteLine();
            p.WriteLine();
            p.WriteLine("Filter by CONDITION");
            p.WriteLine();
            int x2 = 1;
            int y2 = 0;
            try
            {
                int result1 = x2 / y2;
                int result2 = y2 / x2;
            }
            catch (DivideByZeroException) when (y2 == 0) // "when" - is a condition
            {
                p.WriteLine("You tried divide by zero. \"Y\" can't be a \"0\"");
            }
            catch (DivideByZeroException e)
            {
                p.WriteLine("EXCEPTION! " + e.Message);
            }



        }
    }
}
