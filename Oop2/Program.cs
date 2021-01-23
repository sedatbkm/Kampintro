using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ - Gerçek müşteri örneği
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "1234567890";

            //Kodlama.io - Tüzel müşteri örneği

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek Müşteri -Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            MusteriMenager musteriMenager = new MusteriMenager();
            musteriMenager.Add(musteri1);
            musteriMenager.Add(musteri2);



        }
    }
}
