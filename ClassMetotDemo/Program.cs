using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Engin ";
            musteri1.MusteriSoyadi = "Demirog";
            musteri1.MusteriAdres = "Hocam Sok. No:1";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAdi = "Özcan";
            musteri2.MusteriSoyadi = "Kara";
            musteri2.MusteriAdres = "Öğrenci Sok. No:2";

            //Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine( "Ekleme Bölümü --------");
            
            musteriManager.MusteriEkle(musteri1);

            Console.WriteLine("Silme Bölümü --------");
            musteriManager.MusteriSil(musteri2);

            Console.WriteLine("Listeleme Bölümü --------");
            musteriManager.MusteriListele(musteri1,musteri2);

        }
    }
}
