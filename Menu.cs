using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class Menu
    {
      
        public void AnaMenu(Musteri[] musteriler, MusteriManager musteriManager)
        {
            bool devam= true;
            while (devam)
            {
                Console.WriteLine("Müşteri Eklemek için 'e'");
                Console.WriteLine("Müşteri Silmek için 's'");
                Console.WriteLine("Müşteri Listelemek için 'l'");
                Console.WriteLine("harflerine basınız..");
                Console.WriteLine("Çıkmak için 'q' ");
                Console.WriteLine("EN YÜSKEK FAYİZ İÇİN ABC BANKDAN DAHA İYİSİNİ BULAMAZSINIZ :))");
                Console.WriteLine("İşlem Yapmak için bir değer giriniz:");
                string deger = Console.ReadLine();
              
                switch (deger)
                {
                    case "e":
                        foreach (var mustericiks in musteriler)
                        {
                            musteriManager.Add(mustericiks);
                            Console.WriteLine("---------------------------------------");
                        }
                    break;

                    case "s":
                        //Müşterileri silmek için önce Müşterilerin hepsini listelemeli sonra da hangisini sileceksek ona göre atmalıyız.
                        //Listele
                        musteriManager.Listele(musteriler);
                        Console.Clear();
                        Console.WriteLine("Silmek istediğiniz Müşterinin  Müşteri Nosunu giriniz.");
                        string _silMusteriNo = Console.ReadLine();
                        musteriManager.Delete(_silMusteriNo, musteriler);
                    break;

                    case "l":
                        //Listele
                        musteriManager.Listele(musteriler);
                    break;

                    case "q":
                        devam = false;
                        
                    break;

                    default:
                        Console.WriteLine("Yanlış tuşa bastınız");
                       // AnaMenu(musteriler, musteriManager);
                        devam = false;
                    break;
                }
            }
        }
    }
}
