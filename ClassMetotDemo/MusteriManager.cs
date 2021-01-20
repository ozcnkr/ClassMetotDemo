using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle (Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.MusteriAdi);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Silinen Müşterinin Adı : " + musteri.MusteriAdi);
        }

        public void MusteriListele(Musteri musteri1, Musteri musteri2)
        {
            Console.WriteLine("1. Müşteri : " + musteri1.MusteriAdi);
            Console.WriteLine("2. Müşteri : " + musteri2.MusteriAdi);
        }
    }
}
