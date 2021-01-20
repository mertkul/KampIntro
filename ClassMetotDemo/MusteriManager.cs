using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("------Müşteri Eklendi------------");
            Console.WriteLine("Müşteri ID:"+musteri.Id);
            Console.WriteLine("Adı : "+musteri.MusteriAdi);
            Console.WriteLine("Soyadı : " +musteri.MusteriSoyadi);
            Console.WriteLine("Yaş : " +musteri.MusteriYas);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("-----------Müşteriler Listelendi----------");
            Console.WriteLine("Müşteri ID: " + musteri.Id);
            Console.WriteLine("Adı : " + musteri.MusteriAdi);
            Console.WriteLine("Soyadı : " + musteri.MusteriSoyadi);
            Console.WriteLine("Yaş : " + musteri.MusteriYas);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("-----------Tebrikler Müşteri Başarılı ile silindi.----------");
            Console.WriteLine("Müşteri ID: " + musteri.Id);
            Console.WriteLine("Adı : " + musteri.MusteriAdi);
            Console.WriteLine("Soyadı : " + musteri.MusteriSoyadi);
            Console.WriteLine("Yaş : " + musteri.MusteriYas);
        }
    }
}
