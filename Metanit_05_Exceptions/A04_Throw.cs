// A04 THROW operator https://metanit.com/sharp/tutorial/2.31.php

namespace Metanit_05_Exceptions
{
    internal class A04_Throw
    {

        static void Main(string[] strings)
        {
            Console.WriteLine("___ The THROW operator ___");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("___ Throw exception with constructor ___");

            try
            {
                Console.Write("Input name please: ");
                string name = Console.ReadLine();
                if (name == null || name.Length < 2)
                {
                    throw new Exception("MyException: the length of name shorter than 2 symbols"); // here is exception with constructor()
                }
                else
                {
                    Console.WriteLine($"Your name is: {name}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception handler");

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("___ Throw exception WITHOUT CONSTRUCTOR (rethrow)___");
            Console.WriteLine();

            try
            {
                try
                {
                    int x = 5;
                    int y = x / 0;
                    Console.WriteLine("Result " + y);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Inner handler... and throw further");
                    Console.WriteLine(e.Message);
                    throw; // RETHROW the exception further
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);

                Console.WriteLine("External try-catch handler");

            }



        }
    }
}
