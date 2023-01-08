// A01 Exceptions https://metanit.com/sharp/tutorial/2.14.php

/*
namespace Metanit_05_Exceptions 
{
    internal class A01_tryCatchFinally
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            try
            {
                int x = 5;
                int y = 0;
                Console.WriteLine(x / (y));
            }
            catch
            {
                Console.WriteLine("Exception has found");
            }
            finally
            {
                Console.WriteLine("Final block");
            }


            //an example when "if" is better than "try-catch"
            void Square(string strNum)
            {
                try //here using "try-cath" too expencive
                {
                    Console.Write($"Square of \"{strNum}\" is: ");
                    int x = int.Parse(strNum);
                    Console.WriteLine(x * x);
                }
                catch
                {
                    Console.WriteLine("Exception!");
                }

            }


            void Square2(string strNum)
            {
                Console.Write($"Square of \"{strNum}\" is: ");
                int x;
                if (int.TryParse(strNum, out x)) //here is check "int.TryParce" instead "try-catch"
                {
                    Console.WriteLine(x * x);
                }
                else
                {
                    Console.WriteLine($"ERROR! Can't parse {strNum} to \"int\"");
                }
                
            }

            Square("3");
            Square("3r3");
            
            Square2("4");
            Square2("4d");
        }
    }
}

*/