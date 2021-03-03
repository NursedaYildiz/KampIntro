using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAd = "Nur";
            musteri1.MusteriSoyad = "Yıldız";
            musteri1.KrediNotu = 1100;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAd = "Ebru";
            musteri2.MusteriSoyad = "Kırtıl";
            musteri2.KrediNotu = 1500;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAd = "Engin";
            musteri3.MusteriSoyad = "Demiroğ";
            musteri3.KrediNotu = 1700;

            Musteri musteri4 = new Musteri();
            musteri4.MusteriId = 4;
            musteri4.MusteriAd = "Berkay";
            musteri4.MusteriSoyad = "Bilgin";
            musteri4.KrediNotu = 1400;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.AddMusteri(musteri1);
            musteriManager.GetMusteri(musteriler);
            musteriManager.DeleteMusteri(musteri1);
        }

    }
}
