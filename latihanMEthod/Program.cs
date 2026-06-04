using System;

namespace LatihanMethod
{
    class Program
    {
        static double HitungLuasLingkaran(double jariJari)
        {
            return Math.PI * jariJari * jariJari;
        }

        static double HitungLuasPersegi(double sisi)
        {
            return sisi * sisi;
        }

        static double HitungLuasPersegiPanjang(double panjang, double lebar)
        {
            return panjang * lebar;
        }

        static double HitungLuasSegitiga(double alas, double tinggi)
        {
            return 0.5 * alas * tinggi;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== KALKULATOR LUAS BANGUN DATAR ===\n");

            bool lanjut = true;

            while (lanjut)
            {
                Console.WriteLine("Pilih bangun datar:");
                Console.WriteLine("1. Lingkaran");
                Console.WriteLine("2. Persegi");
                Console.WriteLine("3. Persegi Panjang");
                Console.WriteLine("4. Segitiga");
                Console.WriteLine("0. Keluar");
                Console.Write("\nMasukkan pilihan: ");

                string pilihan = Console.ReadLine();

                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        Console.Write("Masukkan jari-jari lingkaran: ");
                        double r = double.Parse(Console.ReadLine());
                        double luasLingkaran = HitungLuasLingkaran(r);
                        Console.WriteLine($"Luas Lingkaran = {luasLingkaran:F2}\n");
                        break;

                    case "2":
                        Console.Write("Masukkan panjang sisi persegi: ");
                        double sisi = double.Parse(Console.ReadLine());
                        double luasPersegi = HitungLuasPersegi(sisi);
                        Console.WriteLine($"Luas Persegi = {luasPersegi:F2}\n");
                        break;

                    case "3":
                        Console.Write("Masukkan panjang: ");
                        double panjang = double.Parse(Console.ReadLine());
                        Console.Write("Masukkan lebar: ");
                        double lebar = double.Parse(Console.ReadLine());
                        double luasPersegiPanjang = HitungLuasPersegiPanjang(panjang, lebar);
                        Console.WriteLine($"Luas Persegi Panjang = {luasPersegiPanjang:F2}\n");
                        break;

                    case "4":
                        Console.Write("Masukkan alas segitiga: ");
                        double alas = double.Parse(Console.ReadLine());
                        Console.Write("Masukkan tinggi segitiga: ");
                        double tinggi = double.Parse(Console.ReadLine());
                        double luasSegitiga = HitungLuasSegitiga(alas, tinggi);
                        Console.WriteLine($"Luas Segitiga = {luasSegitiga:F2}\n");
                        break;

                    case "0":
                        Console.WriteLine("Terima kasih, program selesai!");
                        lanjut = false;
                        break;

                    default:
                        Console.WriteLine("Pilihan tidak valid, coba lagi!\n");
                        break;
                }
            }
        }
    }
}