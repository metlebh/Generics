using System;

namespace HomeWork_07._02._2023
{
    class Program
    {
        static void Main(string[] args)
        {



            Swap<string>("salam", "sagol");
            GetType(5);



        }


        public static void GetType<T>(T value)
        {
            Console.WriteLine(value);
        }


        static void Swap<T>(T a, T b)
        {
            T c = default;
            T temporary = c;
            c = a;
            a = b;
            b = c;

            Console.WriteLine($"Swapped values:{a} , {b}.");
        }






    }
}
