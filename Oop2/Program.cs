using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oğuzhan Turgut
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Oğuzhan";
            musteri1.Soyadi = "Turgut";
            musteri1.TcNo = "11111111111";
            musteri1.Id = 1;


            //Şirket
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.SirketAdi = "NASA";
            musteri2.VergiNo = "1234567890";
            musteri2.MusteriNo = "54321";

            Musteri musteri3 = new GercekMusteri();  //Referans tip olduğu için hem Musteri hem de diğerlerinin referansını da tutabilir.
            Musteri musteri4 = new TuzelMusteri();   //Referans tip olduğu için hem Musteri hem de diğerlerinin referansını da tutabilir.

            MusteriManager manager = new MusteriManager();
            manager.ekle(musteri1);
            manager.ekle(musteri2);
            manager.ekle(musteri3);
            manager.ekle(musteri4);

        }
    }
}
