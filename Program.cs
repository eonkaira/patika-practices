using System;

namespace patika_practices
{
    class Program
    {
        static void Main(string[] args)
        {   
            //---- CONSOLE PROGRAMMING ----
            /* Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your name:");
            var name=Console.ReadLine();
            Console.WriteLine("Enter your surname:");
            var surname=Console.ReadLine();
            Console.WriteLine("Welcome "+name+" "+surname); */

            //---- VARIABLES ----
            /* Console.WriteLine("");

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
            Console.WriteLine(hour); */

            //---- OPERATORS ----

            //* Assignment Operators

            /* int x = 3;
            int y = 3;
            y=y+2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            //* Logical Operators 
            //* ||, &&, !
            bool isSuccess = true;
            bool isCompleted=false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect");
            if(isSuccess || isCompleted)
                Console.WriteLine("Great");
            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine!");

            //* Relational Operators
            //* <, >, <=, >=, ==, !=

            int a=3;
            int b=4;
            bool sonuc=a<b;

            Console.WriteLine(sonuc);
            sonuc=a>b;
            Console.WriteLine(sonuc);
            sonuc= a>=b;
            Console.WriteLine(sonuc);
            sonuc= a<=b;
            Console.WriteLine(sonuc);
            sonuc= a==b;
            Console.WriteLine(sonuc);
            sonuc= a!=b;
            Console.WriteLine(sonuc);

            //* Arithmetic Operators
            //* /, *, +, -

            int sayi1=18;
            int sayi2=5;
            int sonuc1= sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1= sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1= sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1= sayi1++;
            Console.WriteLine(sayi1);

            //* % : mod
            int sonuc2= 20%3;
            Console.WriteLine(sonuc2); */

            //---- TYPE CONVERSION ----
            //*** Implicit Conversion (Bilinçsiz)

            /* byte a = 5;
            sbyte b = 30;
            short c= 10;

            int d= a+b+c;
            Console.WriteLine("d:"+ d);

            long h=d;
            Console.WriteLine("h:"+ h);

            float i=h;
            Console.WriteLine("i:"+ i);

            string e= "zikriye";
            char f='k';
            object g =e+f+d;
            Console.WriteLine("g:"+ g); */

            //*** Explicit Conversion (Bilinçli)

           /*  int x =4;
            byte y = (byte)x;
            Console.WriteLine("y:"+ y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:"+t);

            float w= 10.3f;
            byte v=(byte)w;
            Console.WriteLine("v:"+v); */

            //* ToString Method
            /* int xx=6;
            string yy= xx.ToString();
            Console.WriteLine("yy:"+ yy);

            string zz=12.5f.ToString();
            Console.WriteLine("zz:"+zz); */

            //* System.Convert
            /* string s1="10", s2="20";
            int sayi1, sayi2;
            int Toplam;

            sayi1= Convert.ToInt32(s1);
            sayi2= Convert.ToInt32(s2);

            Toplam= sayi1+sayi2;
            Console.WriteLine("Toplam:"+ Toplam); */

            //* Parse
            /* ParseMethod(); */
            
            //---- TRY - CATCH - FINALLY ----
            /* try
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı: "+ sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: "+ex.Message.ToString());
            }
            finally
            {
                Console.Write("İşlem tamamlandı!");
            } */
            
            /* try
            {
                 int a = int.Parse(null);
                 int b = int.Parse("test");
                 int c = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                 Console.Write("İşlem tamamlandı!");
            } */
            
            //---- IF - IF ELSE - TERNARY ----
            int time = DateTime.Now.Hour;

            if(time>=6 && time<=11)
                Console.WriteLine("Günaydın!");
            else if(time<=18)
                Console.WriteLine("İyi günler!");
            else
                Console.WriteLine("İyi geceler!");

            string sonuc = time<=18 ? "İyi günler!" : "İyi geceler!";

            sonuc = time>=6 && time <=11 ? "Günaydın!" : time <=18 ? "İyi günler!" : "İyi geceler!";

            Console.WriteLine(sonuc);

            
            

            

        }

        
        
        
        
        
        
        
        
        
        
        
        public static void ParseMethod()
        {
            string metin1= "10";
            string metin2= "10.25";
            int rakam1;
            double double1;

            rakam1= Int32.Parse(metin1);
            double1= Double.Parse(metin2);

            Console.WriteLine("rakam1 :"+ rakam1);
            Console.WriteLine("double1 :"+ double1); 
        }
    }
}
