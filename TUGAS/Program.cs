using System;

namespace TUGAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool mainLagi = true;

            while (mainLagi)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("===========================================");
                Console.WriteLine("     🔥 GAME TEBAK ANGKA ULTIMATE 🔥     ");
                Console.WriteLine("===========================================");
                Console.ResetColor();

                // --- FITUR 1: PILIHAN KESULITAN ---
                Console.WriteLine("\nPilih Tingkat Kesulitan:");
                Console.WriteLine("1. Mudah  (1-10, Nyawa: 5)");
                Console.WriteLine("2. Normal (1-50, Nyawa: 7)");
                Console.WriteLine("3. Sulit  (1-100, Nyawa: 10)");
                Console.Write("\nPilihanmu (1/2/3): ");

                int maxAngka = 10, nyawa = 5;
                string level = Console.ReadLine();

                switch (level)
                {
                    case "2": maxAngka = 50; nyawa = 7; break;
                    case "3": maxAngka = 100; nyawa = 10; break;
                    default: maxAngka = 10; nyawa = 5; break;
                }

                int angkaRahasia = random.Next(1, maxAngka + 1);
                int tebakan = 0;
                int jumlahPercobaan = 0;
                bool menang = false;

                Console.WriteLine($"\nOke! Saya memikirkan angka 1 sampai {maxAngka}.");
                Console.WriteLine($"Hati-hati, kamu hanya punya {nyawa} nyawa!");

                // --- LOGIKA GAME ---
                while (nyawa > 0)
                {
                    Console.Write($"\n[Nyawa: {nyawa}] Masukkan tebakanmu: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out tebakan))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("❌ Input tidak valid! Masukkan angka.");
                        Console.ResetColor();
                        continue;
                    }

                    jumlahPercobaan++;

                    if (tebakan < angkaRahasia)
                    {
                        Console.WriteLine("📉 Terlalu RENDAH!");
                        nyawa--;
                    }
                    else if (tebakan > angkaRahasia)
                    {
                        Console.WriteLine("📈 Terlalu TINGGI!");
                        nyawa--;
                    }
                    else
                    {
                        menang = true;
                        break;
                    }
                }

                // --- SELESAI GAME ---
                if (menang)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n🎉 SELAMAT! Kamu berhasil menebak angka {angkaRahasia}");
                    Console.WriteLine($"🏆 Kamu menang dalam {jumlahPercobaan} percobaan.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n💀 GAME OVER!");
                    Console.WriteLine($"Angka yang benar adalah: {angkaRahasia}");
                    Console.ResetColor();
                }

                // --- FITUR 2: MAIN LAGI ---
                Console.Write("\nMain lagi? (y/n): ");
                mainLagi = Console.ReadLine().ToLower() == "y";
            }

            Console.WriteLine("\nTerima kasih sudah bermain! Sampai jumpa.");
            System.Threading.Thread.Sleep(2000);
        }
    }
}