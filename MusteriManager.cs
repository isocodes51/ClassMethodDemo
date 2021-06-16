using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri) => Console.WriteLine($"{musteri.TCKimlikNo} TC Kimlik numaralı Sayın,  {musteri.Ad} {musteri.Soyad} {DateTime.Now} tarihinde kayıtlarımıza eklendi.");
        public void Delete(string _musteriNo, Musteri[] _musteriler)  {
            //Console.WriteLine(_musteriler);
            foreach (var musteri in _musteriler)
            {
               // Console.WriteLine($"{musteri.MusteriNo} müşteri numaralı, {musteri.TCKimlikNo} TC Kimlik numaralı Sayın,  {musteri.Ad} {musteri.Soyad} {DateTime.Now} tarihinde kayıtlarımızdan silindi.");
            if(_musteriNo == musteri.MusteriNo)
                {
                    Console.WriteLine($"{musteri.MusteriNo} numaralı Müşteri silindi");
                }
            
            }

            //Console.WriteLine($"{musteri.MusteriNo} müşteri numaralı, {musteri.TCKimlikNo} TC Kimlik numaralı Sayın,  {musteri.Ad} {musteri.Soyad} {DateTime.Now} tarihinde kayıtlarımızdan silindi.");
        }
        
        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("--------------Müşterilerimiz------------------");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine($" Id:{musteri.Id}\n Müşteri No:{musteri.MusteriNo}\n TC Kimlik No: {musteri.TCKimlikNo}\n Ad: {musteri.Ad}\n Soyad: {musteri.Soyad}");
                Console.WriteLine("----------------------------------------------");
            }
          
        }
    }
}
