using System;

namespace patika_practices
{
    class Program
    {
        static void Main(string[] args)
        {   
            //*CONSOLE PROGRAMMING
            /* Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your name:");
            var name=Console.ReadLine();
            Console.WriteLine("Enter your surname:");
            var surname=Console.ReadLine();
            Console.WriteLine("Welcome "+name+" "+surname); */

            //*VARIABLES
            Console.WriteLine("");

            byte b=5; //! 1 byte
            sbyte c=5; //! 1 byte

            short s=5; //! 2 byte
            ushort us=5; //! 2 byte
            
            Int16 i16=2; //! 2 byte
            int i=2; //! 4 byte
            Int32 i32=2; //! 4 byte
            Int64 i64=2; //! 8 byte

            uint ui=2; //! 4 byte
            long l=4; //! 8 byte 
            ulong ul=4; //! 8 byte

            //*Real Numbers

            float f=5;
            double d=5;
            decimal de=5;

            char ch='2';
            string str="Emre";

            bool b1=true;
            bool b2=false;

            DateTime dt=DateTime.Now;
            Console.WriteLine(dt);

            object o1="x";
            object o2='y';
            object o3=4;
            object o4=4.3;

            //*String Expressions

            string str1=string.Empty;
            str1="Emre Emre";
            string ad="Emre";
            string soyad="Emre";
            string tamIsim=ad+" "+soyad;

            //*Defining Integers

            int integer1=5;
            int integer2=3;
            int integer3=integer1+integer2;

            //*Boolean

            bool bool1=10>2;

            //*Variable Conversions

            string str20="20";
            int int20=20;
            string yeniDeger= str20+int20.ToString();
            Console.WriteLine(yeniDeger); //! 2020

            int int21=int20+ Convert.ToInt32(str20);
            Console.WriteLine(yeniDeger); //! 40

            int int22= int20+ int.Parse(str20); //! 40

            //*Datetime

            string datetime=DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2=DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            //*Hour

            string hour=DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

        }
    }
}
