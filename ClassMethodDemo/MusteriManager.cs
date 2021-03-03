using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void AddMusteri(Musteri musteri)
        {
            Console.WriteLine("--------Müşteri Ekleme-------");
            Console.WriteLine("Müşteri Id: " + musteri.MusteriId);
            Console.WriteLine("Müşteri Adı: " + musteri.MusteriAd);
            Console.WriteLine("Müşteri Soyadı: " + musteri.MusteriSoyad);
            Console.WriteLine("Müşterinin Kredi Notu: " + musteri.KrediNotu);
            Console.WriteLine("Müşteri sisteme eklendi... ");
            Console.WriteLine();
        }

        public void GetMusteri(Musteri[] musteriler)
        {
            Console.WriteLine("--------Tüm Müşterileri Listele-------");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri: " + musteri.MusteriAd + " " + musteri.MusteriSoyad);
            }
            Console.WriteLine();
        }

        public void DeleteMusteri(Musteri musteri)
        {
            Console.WriteLine("--------Müşteri Silme-------");
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + " silindi.");
            Console.WriteLine();
        }

    }
}
