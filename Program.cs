using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikasi Kalkulator");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1.Penambahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Perkalian");
            Console.WriteLine("4.Pembagian");
            Console.Write("Pilihan dari (1-4):");
            int ch = Int32.Parse(Console.ReadLine());
            int a, b, c;
            if (ch == 1)
            {
                Console.Write("Masukan Nilai A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukan Nilai B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a + b;
                Console.WriteLine("Penambahan = {0}", c);
            }
            else if (ch == 2)
            {
                Console.Write("Masukan Nilai A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukan Nilai B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a - b;
                Console.WriteLine("Pengurangan = {0}", c);
            }
            else if (ch == 3)
            {
                Console.Write("Masukan Nilai A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukan Nilai B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a * b;
                Console.WriteLine("Perkalian = {0}", c);
            }
            else if (ch == 4)
            {
                Console.Write("Masukan Nilai A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Pembagian = {0}", c);
            }
            else
            {
                Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia");
            }
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
    }
}