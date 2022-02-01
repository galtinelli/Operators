using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Soru1

            Console.WriteLine("Soru 1:Dışarıdan alınan iki sayının toplamıyla farkının birbirine bölümünden kalanın sonucunu ekrana yazdıran program (Farkın toplama bölümünden kalan) ");
            //Dışarıdan alınan iki sayının toplamıyla farkının birbirine bölümünden kalanın sonucunu ekrana yazdıran program (Farkın toplama bölümünden kalan)

            Console.WriteLine("1. Sayıyı Giriniz: ");
            double sayi1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("2. Sayıyı Giriniz: ");
            double sayi2 = Convert.ToInt32(Console.ReadLine());

            double toplam = sayi1 + sayi2;
            double fark = sayi1 - sayi2;

            double mod = fark / toplam;

            Console.WriteLine("İstenilen sonuç: "+mod);


            #endregion

            #region Soru2

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Soru 2:Dışarıdan alınan bir sayının 10 eksiğinin 20 fazlasının 2 'ye bölümünden kalanın karesi kaçtır? ");
            //Dışarıdan alınan bir sayının 10 eksiğinin 20 fazlasının 2 'ye bölümünden kalanın karesi kaçtır?

            Console.WriteLine("Lütfen bir sayi giriniz?");
            int sayi = Convert.ToInt32(Console.ReadLine());

            double hesap = ((sayi - 10) + 20) / 2;
            double kare = hesap * hesap;
            Console.WriteLine("Sayının hesaplama sonrasında karesi= "+kare);

            #endregion

            #region Soru3

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Soru 3:Dışarıdan alınan iki sayının karelerinin toplamı ile karelerinin farkının toplamı kaçtır ");
            //Dışarıdan alınan iki sayının karelerinin toplamı ile karelerinin farkının toplamı kaçtır

            Console.Write("İlk sayıyı giriniz: ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");

            int b = Convert.ToInt32(Console.ReadLine());

            double karetoplamı = (a * a) + (b * b);
            double karefarkı= (a * a) - (b * b);

            Console.WriteLine("İki sayının karelerinin toplamı ile karelerinin farkının toplamı: "+ (karetoplamı+karefarkı));

            #endregion

            #region Soru4

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Soru 4:Dışarıdan alınan Vize sınavının %40'ıve final sınavının %60'ını alıp bir öğrencinin not otalamasını hesaplayan ve ekrana yazdıran program ");
            //Dışarıdan alınan Vize sınavının %40'ıve final sınavının %60'ını alıp bir öğrencinin not otalamasını hesaplayan ve ekrana yazdıran program

            Console.Write("Vize notunuzu giriniz: ");
            double vize = Convert.ToDouble(Console.ReadLine());
 
            Console.Write("Final notunuzu giriniz: ");
            double final = Convert.ToDouble(Console.ReadLine());

            double not = (vize * 0.4) + (final * 0.6);

            Console.WriteLine("Not ortalamanız: "+not);



            #endregion


            #region Soru5
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Soru 5:iki sayının karelerinin toplamı ile karelerinin farkının toplamı ");
            //Dışarıdan girilen kullanıcı adı ve soyyadını ayrı ayrı alınız ve adi.soyadi@mail.com şeklinde mail adresini ekrana yazdıran program

            //NOT: Tek isim girişi
            //ÇIKTI: Sayın Bilge Adam,
            //bilge.adam@mail.com mail adresiniz aktif hale getirilmiştir.

            Console.WriteLine("Adınızı giriniz: ");
            string ad = Console.ReadLine();
            
            Console.WriteLine("Soyadınızı giriniz: ");
            string sad = Console.ReadLine();

            Console.WriteLine("Sayın " + ad +sad +",");
            Console.WriteLine( ad +"." +sad+"@mail.com adresiniz aktif hale getirilmiştir.");



            #endregion

            Console.ReadKey();



        }
    }
}
