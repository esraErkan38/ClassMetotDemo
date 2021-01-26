using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Adi + " " +musteri.Soyadi +" sisteme eklenmiştir.");
        }
        public void Sil(Musteri musteri)
        {

            Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi +" sisitemden silinmiştir.");
        }
        public void Listele(Musteri musteri)
        {
            
            Console.WriteLine("Müşteri Numarası : " + musteri.Id);
            Console.WriteLine("Müşteri Adı Soyadı : " + musteri.Adi + " " +musteri.Soyadi);
            
        }
    }
}
