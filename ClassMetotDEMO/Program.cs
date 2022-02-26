using System;

namespace ClassMetotDEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Nisa";
            musteri1.Soyad = "NurACK";
            musteri1.Sehri = "Ordu";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "BerkeCan";
            musteri2.Soyad = "AltıPatlar";
            musteri2.Sehri = "Sinop";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Kamuran";
            musteri3.Soyad = "Kahveci";
            musteri3.Sehri = "İzmir";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.ekle(musteri1);
            musteriManager.listele(musteriler);
            musteriManager.sil(musteri2);
        }
    }
}
