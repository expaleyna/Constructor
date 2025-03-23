using System;
using System.Globalization;

namespace AracUretimi
{
    public class Marka
    {
        public string Ad { get; set; }
        public Marka(string ad)
        {
            Ad = ad;
        }
    }
    public class Kasa
    {
        public string Tip { get; set; }
        public Kasa(string tip)
        {
            Tip = tip;
        }
    }
    public class Kapi
    {
        public int Adet { get; set; }
        public Kapi(int adet)
        {
            Adet = adet;
        }
    }
    public class Pencere
    {
        public int Adet { get; set; }
        public Pencere(int adet)
        {
            Adet = adet;
        }
    }
    public class Araba
    {
        public Marka Marka { get; set; }
        public string Model { get; set; }
        public Kapi Kapi { get; set; }
        public Pencere Pencere { get; set; }
        public Kasa Kasa { get; set; }
        public decimal Fiyat { get; set; }
        public Araba(Marka marka, string model, Kapi kapi, Pencere pencere, Kasa kasa, decimal fiyat)
        {
            this.Marka = marka;
            this.Model = model;
            this.Kapi = kapi;
            this.Pencere = pencere;
            this.Kasa = kasa;
            this.Fiyat = fiyat;
        }
        public override string ToString()
        {
            string fiyatFormatted = Fiyat.ToString("N0", new CultureInfo("tr-TR"));
            return "Arabanın markası " + Marka.Ad + ", modeli " + Model + ", kapı sayısı " + Kapi.Adet + ", pencere sayısı " + Pencere.Adet + ", kasası " + Kasa.Tip + ", fiyatı " + fiyatFormatted + " TL’dir.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Marka marka = new Marka("BMW");
            Kasa kasa = new Kasa("sedan");
            Kapi kapi = new Kapi(4);
            Pencere pencere = new Pencere(4);
            Araba araba = new Araba(marka, "X5", kapi, pencere, kasa, 2000000);
            Console.WriteLine(araba.ToString());
        }
    }
}
