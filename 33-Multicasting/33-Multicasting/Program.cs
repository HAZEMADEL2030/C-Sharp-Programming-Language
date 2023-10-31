using System;

namespace _33_Multicasting
{
    class Multicast
    {
        public static void Sinus(int number)
        {
            Console.WriteLine("Sinis is:" + Math.Sin(number));
        }

        public static void Cosinus(int number)
        {
            Console.WriteLine("Cosinus is:" + Math.Cos(number));
        }
    }

    public delegate void MyDelegate(int number);
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate D1 = Multicast.Sinus;
            MyDelegate D2 = Multicast.Cosinus;

            Console.WriteLine("<----Simple Delegate---->");
            D1.Invoke(60);
            D2(180);
            Console.WriteLine();
            Console.WriteLine("<---Multicast-->");
            MyDelegate MulticastDelegate = D1 + D2;
            MulticastDelegate(90);
            Console.ReadLine();
        }
    }
}