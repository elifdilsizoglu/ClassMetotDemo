using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adı = "Elif";
            musteri1.Soyadı = "Dilsizoglu";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adı = "Meryem";
            musteri2.Soyadı = "Yıldırım";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adı = "Ali";
            musteri3.Soyadı = "Şimşek";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2,musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Listeleme(musteriler);


        }
    }
}
