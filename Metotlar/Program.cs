using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] {"Elma", "Karpuz" };


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 15;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            //type -safe --tip güvenli
            Urun[] urunler=new Urun[] { urun1, urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }



           Console.WriteLine("-------Metotlar--------");

            //instance- örnek
            //encapsulition
            SepetMenager sepetMenager = new SepetMenager();
            sepetMenager.Ekle(urun1);
            sepetMenager.Ekle(urun2);

            sepetMenager.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetMenager.Ekle2("Elma", "Yeşil elma", 12,9);
            sepetMenager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,8);

        }
    }
}


//Dont repeat yourself - DRY- Clean Code- Best Practice
