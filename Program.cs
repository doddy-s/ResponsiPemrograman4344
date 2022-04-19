class Program
{
    static void Main(string[] args)
    {
        Karyawan[] karyawan = new Karyawan[2];

        karyawan[0] = new Karyawan("190302123", "Paijo", 3000000);
        karyawan[1] = new Karyawan("190302124", "Jono", 2000000);

        Console.WriteLine("NIK\t  Nama\tGaji Bulanan");
        Console.WriteLine("----------------------------");
        for(int i = 0; i<2; i++)
        {
            karyawan[i].printGajiBulanan();
        }

        Console.WriteLine("\nAsyik kenaikan gaji 10% !!\n");

        for(int i = 0; i<2; i++)
        {
            karyawan[i].naikkanGajiBulanan();
        }

        Console.WriteLine("NIK\t  Nama\tGaji Bulanan");
        Console.WriteLine("----------------------------");
        for(int i = 0; i<2; i++)
        {
            karyawan[i].printGajiBulanan();
        }
    }
}