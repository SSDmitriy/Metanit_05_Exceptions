// A06 Find catch block https://metanit.com/sharp/tutorial/2.30.php

//here we have chain of methods
// Main() --> A.Method1() --> A.Method2()
// Method2() is generate an Exception, but have not suitable "catch"
// suitable catch only in Main().
// Run order after exception in meth2() is:
// EXCEPTION --> find suitable type (in Main() ) --> finally2 --> finally1 --> HANDLER of Exception --> finally Main()


namespace Metanit_05_Exceptions
{
    internal class A06_FindCatchBlock
    {
        static void Main(string[] strings)
        {
            Console.WriteLine("A06 find catch block");
            Console.WriteLine();

            A a = new A();

            try
            {
                a.Method1();
            }
            catch (DivideByZeroException) // suitable type of exception
            {
                Console.WriteLine("Exception handler in MAIN()");
            }
            finally
            {
                Console.WriteLine("Finaly in MAIN()");
            }

            Console.WriteLine("++ Code after handle exceptions in MAIN()");

        }
    }


    class A
    {
        public void Method1()
        {
            try
            {
                Method2();
            }
            catch (OutOfMemoryException) // not suitable type
            {
                Console.WriteLine("Exception handler in METHOD1()");

            }
            finally
            {
                Console.WriteLine("Finaly in METHOD1()");
            }

            Console.WriteLine("-- Code which never execute in METHOD1()");

        }



        void Method2()
        {
            try
            {
                int x = 6;
                int y = x / 0; //EXCEPTION here with type DivisionByZero
                Console.WriteLine("-- Code which never execute in METHOD2()"); //never exe
            }
            catch (ArgumentOutOfRangeException) //not suitable type
            {
                Console.WriteLine("Exception handler in METHOD2()");
            }
            finally
            {
                Console.WriteLine("Finaly in METHOD2()");
            }
        }


    }
}
