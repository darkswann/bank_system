using System;

namespace bank_system
{
    class Program
    {
        static void Main(string[] args)
        {

            // BURASI EN ÜST TARAF YANİ PROGRAMI AÇTIĞIMIZDA EKRANA ÇIKAN KODLARIMIZ!
            int bakiye = 1000;
            Console.WriteLine("Dark Banka'a Hoşgeldiniz!");
            Console.WriteLine("Bakiyeniz : " + bakiye);
            Console.WriteLine("\n---------İŞLEMLER---------\n");
            Console.WriteLine("1. Para Çekme");
            Console.WriteLine("2. Para Yatırma");
            Console.WriteLine("3. Bakiye Sorgulama");
            Console.WriteLine("4. Kart İade");


            Console.Write("\nİşleminizi Seçiniz: ");
            int islem = Convert.ToInt32(Console.ReadLine()); // islem Değişkenini Okutuyoruz!

            switch (islem)
            {
                case 1:  // 1'e Basınca Çalışacak Kodlar
                    Console.WriteLine("Bakiyeniz :" + bakiye);
                    Console.Write("Çekmek istediğiniz tutarı giriniz : ");
                    int tutar = Convert.ToInt32(Console.ReadLine());
                    if (tutar > bakiye)
                    {
                        Console.Write("Yetersiz bakiye. Tekrar giriniz : ");
                        tutar = Convert.ToInt32(Console.ReadLine());
                    }
                    bakiye -= tutar;
                    Console.WriteLine("Yeni Bakiyeniz : " + bakiye);
                    break;
                case 2:     // 2'e Basınca Çalışacak Kodlar
                    Console.WriteLine("Bakiyeniz = " + bakiye);
                    Console.Write("Yatırmak istediğiniz tutarı giriniz : ");
                    tutar = Convert.ToInt32(Console.ReadLine());
                    bakiye += tutar;
                    Console.WriteLine("Yeni Bakiyeniz = " + bakiye);
                    break;
                case 3: // 3'e Basınca Çalışacak Kodlar
                    Console.WriteLine("Bakiyeniz = " + bakiye);
                    break;
                case 4: // 4'e Basınca Çalışacak Kodlar
                    Console.WriteLine("Kartınızı Almayı Unutmayınız!");
                    break;

                default: // Hiçbir durum ile eşleşme olmaz ise bu kodlar çalışır
                    Console.WriteLine("Yanlış İşlem Seçtiniz. Tekrar Giriniz.");
                    break;
            }
            Console.ReadLine();

        }
    }
}
