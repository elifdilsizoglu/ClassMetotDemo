using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi" + " " + musteri.Adı);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi" + " " + musteri.Adı);
        }

        public void Listeleme(Musteri[] musteriler)
        {
            Console.WriteLine("Musteriler listelendi");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("   " + musteri.Adı);
            }
            
        }
    }
}
