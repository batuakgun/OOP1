using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.CustomerNumber = "12345";
            musteri1.Name = "Batuhan";
            musteri1.Surname = "Akgün";
            musteri1.TcNo = "12345678910";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.CustomerNumber = "34243";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123456678765";



            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);



        }
    }
}
