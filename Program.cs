using System;

namespace patika_practices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your name:");
            var name=Console.ReadLine();
            Console.WriteLine("Enter your surname:");
            var surname=Console.ReadLine();
            Console.WriteLine("Welcome "+name+" "+surname);
        }
    }
}
