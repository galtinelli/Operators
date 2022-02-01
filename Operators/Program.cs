using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int yas=12;
            //Eğer && olursa ilk koşul false olduğunda direk çıkar

            if (yas >= 18 && yas <= 65)
            {
                //İlk koşul false olduğunda direk çıkar
            }

            if (yas >= 18 & yas <= 65)
            {
                //İki koşulu da sorgular, daha fazla işlem yapar.
            }

            int a = 5;
            a = a++;//6
            a = a--;//5
            a -= 2;//3

            a = ++a;
            Console.WriteLine(a);
           
            //Ctrl+K+S region oluşturma

            int c = 106;

            int b = 14;

            #region Toplama İşlemi

            int toplam = c + b;

            Console.WriteLine("Toplama işlemi sonucu: "+toplam);
            Console.WriteLine("Toplama işlemi sonucu: "+c+b);
            Console.WriteLine("Toplama işlemi sonucu: "+(c+b));


            #endregion

            #region Çıkarma İşlemi

            int fark = c - b;

            Console.WriteLine("Çıkarma işlemi sonucu: " + fark);//92
            //Console.WriteLine("Çıkarma işlemi sonucu: " + c - b);HATALI
            Console.WriteLine("Çıkarma işlemi sonucu: " + (c - b));//92

            #endregion

            #region Çarpma İşlemi

            int carp = c * b;

            Console.WriteLine("Çarpma işlemi sonucu: " + carp);//1484
            Console.WriteLine("Çarpma işlemi sonucu: " + (c * b));//1484

            #endregion
                        
            #region Bölme İşlemi

            double bol = Convert.ToDouble(c) / Convert.ToDouble(b);

            Console.WriteLine("Bölme işlemi sonucu: " + bol);//7
            Console.WriteLine("Bölme işlemi sonucu: " + (c / b));//7

            #endregion,

            #region Mod Alma İşlemi

            double mod = c % b;

            Console.WriteLine("Bölme işlemi sonucu: " + mod);//8
            Console.WriteLine("Bölme işlemi sonucu: " + (c % b));//8

            #endregion

            #region Sayıyı 1 Arttırma İşlemi

            double sayi = 15;

            Console.WriteLine("Sayının ilk değeri: "+sayi);

            sayi = sayi + 1;
            Console.WriteLine("Sayının ikinci değeri: "+sayi);

            sayi += 1;
            Console.WriteLine("Sayının üçüncü değeri: "+sayi);

            sayi++;
            Console.WriteLine("Bölme dördüncü değeri: " + sayi);//8

            #endregion

            #region Sayıyı 1 Azaltma İşlemi

            sayi = 15;

            Console.WriteLine("Sayının ilk değeri: " + sayi);

            sayi = sayi - 1;
            Console.WriteLine("Sayının ikinci değeri: " + sayi);

            sayi -= 1;
            Console.WriteLine("Sayının üçüncü değeri: " + sayi);

            sayi--;
            Console.WriteLine("Bölme dördüncü değeri: " + sayi);//8

            #endregion

            Console.ReadKey();

            //Environment.NewLine yeni satıra atlaır
        }
    }
}
