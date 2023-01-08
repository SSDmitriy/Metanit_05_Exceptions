// A03 The TYPES of exceptions https://metanit.com/sharp/tutorial/2.29.php

namespace Metanit_05_Exceptions
{
    internal class A03_TypesOfExceptions
    {
        static void Main(string[] strings)
        {
            Console.WriteLine("Here is TYPES of EXCEPTIONS");
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Result is: {y}");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                Console.WriteLine($"Method: {e.TargetSite}");
                Console.WriteLine($"StackTrace: {e.StackTrace}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Catch exceptions by types");
            Console.WriteLine();
            try
            {
                int[] nums = new int[4];
                nums[7] = 7; //here is an exception
                int x2 = 5;
                int y2 = x2 / 0; //here is too, but won't hadled because previous exception first
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Here is handle for DivideByZero"); // this will skipped, because another exception below
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Here is handle for OutOfRange: " + e.Message);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("UNCATCH exceptions, becase there is no \"catch\" for it");
            Console.WriteLine();
            //try
            //{
            //    object ob1 = "obbb";
            //    int num1 = (int)ob1; //here is casting exception, but it's won't handled 
            //                         // because there no fitted "catch"
            //    Console.WriteLine($"Result is: {num1}");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("exc divide");
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("exc 2");

            //}

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Here is working last \"catch\", because there is no special \"catch\" for cast");
            Console.WriteLine();
            try
            {
                object obj = "you";
                int num = (int)obj;     // System.InvalidCastException
                Console.WriteLine($"Результат: {num}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception Divivde");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Exception IdxOutOfRange");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Any OTHER EXCEPTION");
            }


        }

    }
}
