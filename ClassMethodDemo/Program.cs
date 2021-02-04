using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ayşe";
            musteri1.Soyad = "Korkmaz";
            musteri1.Yas = 42;


            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ebru";
            musteri2.Soyad = "Yılmaz";
            musteri2.Yas = 34;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Hakan";
            musteri3.Soyad = "Özdemir";
            musteri3.Yas = 24;


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekleme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Listeleme(musteri3);

        }
    }
}
