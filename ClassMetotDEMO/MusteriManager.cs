using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDEMO
{
    class MusteriManager
    {
        public void ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi" + musteri.Ad);
        }
        public void listele(Musteri[] musteriler)
        {
            Console.WriteLine("Musteri listesi : ");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Sehri);
            }
        }
        public void sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " adli musteri silindi...");
        }
    }
}
