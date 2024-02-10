using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    class Program
    {
        private static Person person1;

        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas(); //vatandas1 adında yeni bir vatandaş oluşturur.

            SelamVer("Engin");
            SelamVer("Beyza");
            SelamVer();

            Topla(3, 5);
            Topla();

            //diziler - arrays
            string ogrenci1 = "Engin";
            string ogrenci2 = "Beyza";
            string ogrenci3 = "Kerem";

            string[] ogrenciler = new string[3]; //3 elemanlı dizinin tanımı
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Beyza";
            ogrenciler[2] = "Kerem";
            //ogrenciler[3] = "İlker";

            ogrenciler = new string[4]; //referans tipler için new kullanımı.
            ogrenciler[3] = "İlker";

            //for döngüsü
            for (int i=0; i<ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            //referans tipler (class, array, abstract..)
            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]); //Adana 

            //değer tipler (sayısal tipler)
            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            Console.WriteLine(sayi2); //10 

            //foreach döngüsü
            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new ForeignerManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim = "İsimsiz") //default parametre olarak "İsimsiz" gönderir.
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10) //default parametre olarak sayi1 için 5 değerini, sayi2 için 10 değerini gönderir.
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000; //tutar'ın eşitliği bir projede db'den gelir.
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Engin";
            string soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 12345678910;

            Console.WriteLine(mesaj);
            Console.WriteLine(tutar * 1.18);
        }
    }

    public class Vatandas
    {
        //vatandaşın özellikleri için prop (properties) kullanımı:
        public string Ad { get; set; } 
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
