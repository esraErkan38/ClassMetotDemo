using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 3381;
            musteri1.Adi = "Esra";
            musteri1.Soyadi = "ERKAN";


            Musteri musteri2 = new Musteri();
            musteri2.Id = 3381;
            musteri2.Adi = "Ebru";
            musteri2.Soyadi = "AKIN";


            Musteri musteri3 = new Musteri();
            musteri3.Id = 3381;
            musteri3.Adi = "Zemzem";
            musteri3.Soyadi = "ULUTÜRK";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("***Ekleme***");
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("***SİLME***");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);

            Console.WriteLine("***LİSTELEME***");
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);





        }
    }
}
