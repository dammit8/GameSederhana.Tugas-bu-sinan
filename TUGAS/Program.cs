namespace TUGAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int angkaRahasia = random.Next(1, 101);
            int tebakan = 0;
            int jumlahPercobaan = 0;

            Console.WriteLine("=== Selamat Datang di Game Tebak Angka ===");
            Console.WriteLine("Saya telah memilih angka antara 1 sampai 100.");
            Console.WriteLine("Coba tebak ya!");

            while (tebakan != angkaRahasia)
            {
                Console.Write("Masukkan tebakanmu: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out tebakan))
                {
                    Console.WriteLine("Masukkan angka yang valid!");
                    continue;
                }

                jumlahPercobaan++;

                if (tebakan < angkaRahasia)
                {
                    Console.WriteLine("Terlalu RENDAH! Coba lagi.");
                }
                else if (tebakan > angkaRahasia)
                {
                    Console.WriteLine("Terlalu TINGGI! Coba lagi.");
                }
                else
                {
                    Console.WriteLine($"\nSELAMAT! Kamu berhasil menebak angka {angkaRahasia}");
                    Console.WriteLine($"Total percobaan: {jumlahPercobaan}");
                }
            }

            Console.WriteLine("\nTekan tombol apa saja untuk keluar...");
            Console.ReadKey();
        }
    }
}