using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Mert";
            musteri1.MusteriSoyadi = "Kul";
            musteri1.MusteriYas = 26;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Ahmet";
            musteri2.MusteriSoyadi = "Bayraktar";
            musteri2.MusteriYas = 27;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 5;
            musteri3.MusteriAdi = "Sinan";
            musteri3.MusteriSoyadi = "Gümüş";
            musteri3.MusteriYas = 30;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 8;
            musteri4.MusteriAdi = "Mesut";
            musteri4.MusteriSoyadi = "Özil";
            musteri4.MusteriYas = 32;

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3,musteri4};

          
            //instance class örneği 
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Ekle(musteri2);
            musteriManager.Sil(musteri3);



        }

    }
}
