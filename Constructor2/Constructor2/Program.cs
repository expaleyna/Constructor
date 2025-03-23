using System;

namespace MatematikIslemleri
{
    public class Matematik
    {
        public int Topla(int a, int b)
        {
            return a + b;
        }
        public int Topla(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Topla(double a, double b)
        {
            return a + b;
        }
        public double Topla(double a, double b, double c)
        {
            return a + b + c;
        }
        public int Carp(int a, int b)
        {
            return a * b;
        }
        public int Carp(int a, int b, int c)
        {
            return a * b * c;
        }
        public double Carp(double a, double b)
        {
            return a * b;
        }
        public double Carp(double a, double b, double c)
        {
            return a * b * c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matematik mat = new Matematik();
            Console.WriteLine("Int Toplama (2 parametre): " + mat.Topla(3, 4));
            Console.WriteLine("Int Toplama (3 parametre): " + mat.Topla(3, 4, 5));
            Console.WriteLine("Double Toplama (2 parametre): " + mat.Topla(3.5, 4.5));
            Console.WriteLine("Double Toplama (3 parametre): " + mat.Topla(3.5, 4.5, 5.5));
            Console.WriteLine("Int Çarpma (2 parametre): " + mat.Carp(3, 4));
            Console.WriteLine("Int Çarpma (3 parametre): " + mat.Carp(3, 4, 5));
            Console.WriteLine("Double Çarpma (2 parametre): " + mat.Carp(3.5, 4.5));
            Console.WriteLine("Double Çarpma (3 parametre): " + mat.Carp(3.5, 4.5, 5.5));
        }
    }
}
