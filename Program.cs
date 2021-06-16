using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {   /*
         
          isoCodes ®2021-06-16
          3.gün Ödev 3  
                   
          Not: Güle güle kullanmanız dileği ile.. :)
         */
       
       
        static void Main(string[] args)
        {
            // Extract Method diye bir kolaylığı var c# ın ondan yararlandım. Vouov süper.. :))
            Musteri musteri_1 = GetMusteri_1();
            Musteri musteri_2 = GetMusteri_2();
            Musteri[] musteriler = { musteri_1, musteri_2 };
            MusteriManager musteriManager = new MusteriManager();


            // Müşteri Ekleme----
            /*
               Açıklama: 
               Müşterileri tek tek eklemek yerine foreach ile hepsini aynı anda ekledim. Dilerseniz,
                     musteriManager.Add(musteri_1);
                     musteriManager.Add(musteri_2); 
               ayrı ayrı çağırıp tek tek de eklemeyi simule edebilirsiniz.
             */
            /*
             Console.WriteLine("-------Eklenen Müşteriler--------------"); 
             foreach (var mustericiks in musteriler)
             {

                 musteriManager.Add(mustericiks);
                 Console.WriteLine("---------------------------------------");
             }
             //----

             //Müşteri Silme----
               musteriManager.Delete(musteri_1); //İsterseniz toplu olarak da silme yapabilirsiniz .
             //----

             //Müşteri Listeleme----
               musteriManager.Listele(musteriler);
             //----
            */
            Menu menu = new Menu();
            menu.AnaMenu(musteriler,musteriManager); //Menu.cs içindeki Anamenu Methodunu çağırıyoruz.
        }

        private static Musteri GetMusteri_1()
        {
            return new Musteri
            {
                Id = 1,
                TCKimlikNo = "12345678901",
                MusteriNo = "1",
                Ad = "Toygar",
                Soyad = "Hedehedehöy"
            };
        }

        private static Musteri GetMusteri_2()
        {
            return new Musteri
            {
                Id = 2,
                TCKimlikNo = "12345678902",
                MusteriNo = "2",
                Ad = "Düriye",
                Soyad = "Güğümlerikalaylı"
            };
        }
    }
}
