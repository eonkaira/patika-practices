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
            /* int time = DateTime.Now.Hour;

            if(time>=6 && time<=11)
                Console.WriteLine("Günaydın!");
            else if(time<=18)
                Console.WriteLine("İyi günler!");
            else
                Console.WriteLine("İyi geceler!");

            string sonuc = time<=18 ? "İyi günler!" : "İyi geceler!";

            sonuc = time>=6 && time <=11 ? "Günaydın!" : time <=18 ? "İyi günler!" : "İyi geceler!";

            Console.WriteLine(sonuc); */

            //---- SWITCH-CASE ----
            //* Expression
            /* int month = DateTime.Now.Month;
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız.");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız.");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındasınız.");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girildi.");
                    break;
            }   


            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimindesiniz.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimindesiniz.");
                    break;
                
                default:
                    break;
            } */

            //---- FOR LOOP ----
            //* Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır
            /* Console.Write("Lütfen bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i<=sayac; i++)
            {
                if(i%2 == 1)
                    Console.WriteLine(i);
            } */

            //* 1 ile 1000  arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır
            /* int tekToplam=0;
            int ciftToplam=0;

            for (int i = 1; i <= 1000 ; i++)
            {
                if(i%2==1)
                    tekToplam += i; //* tekToplam = tekToplam + i

                else
                    ciftToplam += i;
            }

            Console.WriteLine("Tek Toplam: "+tekToplam);
            Console.WriteLine("Çift Toplam: "+ciftToplam);

            //* break, continue
            for (int i = 1; i < 10; i++)
            {
                if(i%2==5)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if(i%2==5)
                    continue;
                Console.WriteLine(i);    
            } */

            //---- WHILE ----
            //* 1'den başlayarak console'dan girilen sayıya kadar (sayı dahil) ortama hesaplayıp console'dan yazdıran program

            /* Console.Write("Lütfen bir sayı giriniz: ");
            int sayi= Convert.ToInt32(Console.ReadLine());
            int sayac= 1;
            int toplam= 0;

            while (sayac<=sayi)
            {
                 toplam+=sayac;
                 sayac++;
            }
            Console.WriteLine(toplam/sayi); */

            //* a'dan z'ye kadar olan tüm harfleri console'da yazdır

            /* char character= 'a';

            while (character<'z')
            {
                 Console.Write(character);
                 character++;
            } */

            //---- FOREACH ----

            /* string[] arabalar={"Audi", "Honda", "Ford", "Subaru"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }  */

            //---- ARRAYS ----

            //* Array Tanımlama
            /*1*/ /* string[] renkler= new string[5]; */
            /*2*/ /* string[] hayvanlar= {"Kedi", "Köpek", "Kuş", "Kurt"}; */
            /*3*/ /* int[] dizi;
                  dizi= new int[5]; */

            //* Array'lere değer atama ve erişim
            /* renkler[0]="Kırmızı";
            dizi[3]=10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[3]); */

            //* Döngüler ile Array kullanımı
            //* Klavyeden girilen n tane programın ortalamasını hesaplayan program

            /* Console.Write("Lütfen array'in eleman sayısını giriniz: ");
            int arrayLength= int.Parse(Console.ReadLine());
            int[] arrayNumbers= new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i+1);
                arrayNumbers[i]= int.Parse(Console.ReadLine());
            }

            int totalOfNumbers=0;
            foreach (int number in arrayNumbers)
            {
                totalOfNumbers+=number;
            }
            Console.WriteLine("Average of numbers is " + totalOfNumbers/arrayLength); */

            //---- ARRAY CLASS METHODS ----
            
            //* Sort
            /* int[] sayiDizisi={23,12,4,86,72,3,11,17};

            Console.WriteLine("**** Sırasız Dizi ****");
            foreach (int sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("**** Sıralı Diziler ****");
            Array.Sort(sayiDizisi);

            foreach (int sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
 */
            //* Clear
            /* Console.WriteLine("**** Array Clear ****");
            //! Sayı dizisi elemanlarını kullanarak 2. index'ten itibaren 2 tane elemanı 0'lar.
            Array.Clear(sayiDizisi,2,2);

            foreach (int sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            } */

            //* Reverse
            /* Console.WriteLine("**** Array Reverse ****");
            Array.Reverse(sayiDizisi);

            foreach (int sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            } */

            //* IndexOf
           /*  Console.WriteLine("**** Array IndexOf ****");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23)); */

            //* Resize
            /* Console.WriteLine("**** Array Resize ****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;

            foreach (int sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            } */

            //---- METHODS ----
            
            //* erisim_belirteci geridönüş_tipi metod_adı(parametreListesi / argüman)
            //* {
                    ////* komutlar
                      //* return                
            //* }

            /* 
            int a=2;
            int b=3;
            Console.WriteLine(a+b);

            int sonuc= Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek= new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2=ornek.ArttirVeTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b)); */
            
            //* out parametreler
            /* string sayi= "999" ;

            bool sonuc= int.TryParse(sayi, out int outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(sonuc);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            MetotlarOverloading instance= new MetotlarOverloading();
            instance.Topla(4,5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //* Metot Overloading
            int ifade=999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Emre","Oz"); 
            */

            //* Metot İmzası
            //* metotAdi + parametre sayisi + parametre




            //* Rekürsif - Öz yineleme
            //* 3^4 = 3*3*3*3

            int result= 1;
            for (int i = 1; i < 5; i++)
            {
                result = result*3;
                Console.WriteLine(result);
            }

            Islemler instance= new();
            Console.WriteLine(instance.Expo(3,4));

            //* Extension Metotlar

            string ifade="Emre Özden";
            bool sonuc= ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            if(sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }

            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = {5,3,7,8,1,9};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstCharacter());
            



     
        }

        

        
        
        
        
        
        
        
        /* static int Topla(int deger1, int deger2) //*Metotlar 1 konusunda
        {
            return(deger1+deger2);
        } */

        
        

        
        
        
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
    class Metotlar
        {
            public void EkranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }

            public int ArttirVeTopla(ref int deger1, ref int deger2)
            {
                deger1+=1;
                deger2+=1;
                return deger1 + deger2;
            }

        }

    class MetotlarOverloading
        {
            public void Topla(int a, int b, out int toplam)
            {
                toplam= a+b;
            }

            public void EkranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }

            public void EkranaYazdir(int veri)
            {
                Console.WriteLine(veri);
            }

            public void EkranaYazdir(string veri1, string veri2)
            {
                Console.WriteLine(veri1+veri2);
            }



        }

        public static class Extension
        {

            public static bool CheckSpaces(this string param)
            {
                return param.Contains(" ");
            }

            public static string RemoveWhiteSpaces(this string param)
            {
                string[] dizi=param.Split(" ");
                return string.Join("",dizi);
            }

            public static string MakeUpperCase(this string param)
            {
                return param.ToUpper();
            }

            public static string MakeLowerCase(this string param)
            {
                return param.ToLower();
            }

            public static int[] SortArray(this int[] param)
            {
                Array.Sort(param);
                return param;
            }

            public static void EkranaYazdir(this int[] param)
            {
                foreach (var item in param)
                {
                    Console.WriteLine(item);
                }
            }

            public static bool IsEvenNumber(this int param)
            {
                return param%2==0;
            }

            public static string GetFirstCharacter(this string param)
            {
                return param.Substring(0,1);
            }
        }

        public class Islemler
        {
            public int Expo(int sayi, int üs)
            {
                if(üs<2)
                    return sayi;
                return Expo(sayi,üs-1)*sayi;
            }
            //! Expo(3,4)
            //! Expo(3,3)*3
            //! Expo(3,2)*3*3   
            //! Expo(3,1)*3*3*3
            //! 3*3*3*3 = 3^4

        }







}



