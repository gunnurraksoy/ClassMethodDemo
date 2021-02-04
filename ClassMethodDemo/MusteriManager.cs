using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekleme(Musteri musteri) 
        {
            Console.WriteLine("Müşteri eklendi:" +" " + musteri.Ad+" " +musteri.Soyad+" "+musteri.Yas);
        }

        public void Silme(Musteri musteri) 
        {
            Console.WriteLine("Müşteri silindi" + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Yas);
        }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi" + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Yas);
        }

    }
}
