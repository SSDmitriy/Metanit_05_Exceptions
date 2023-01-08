// A05 My own class exceptions https://metanit.com/sharp/tutorial/3.17.php

namespace Metanit_05_Exceptions
{
    internal class A05_MyOwnExceptionClasses
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___ A05 here is my own classes for exceptions ___");

            try
            {
                Person person = new Person { Age = 17, Name = "Tom" };
            }
            catch (Exception e)
            {

                Console.WriteLine("Handler for exception: " + e.Message);

            }

        }







        //class for my own exceptions
        class MyPersonException : Exception
        {
            public MyPersonException(string message)
                : base(message) { }
        }

        class Person
        {
            private int age;
            public string Name { get; set; } = "";
            public int Age
            {
                get { return age; }
                set
                {
                    if (value < 18)
                    {
                        throw new MyPersonException("My Exception! Forbidden to less 18");
                    }
                    else
                    {
                        age = value;
                    }
                }
            }

        }
    }
}
