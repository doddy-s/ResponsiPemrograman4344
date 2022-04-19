public class Karyawan
{
    public string nik{get; set;}
    public string nama{get; set;}
    public int gajiBulanan{get; set;}

    public Karyawan(string nikConstructor, string namaConstructor, int gajiBulananConstructor)
    {
        nik = nikConstructor;
        nama = namaConstructor;
        gajiBulanan = gajiBulananConstructor;
        if(gajiBulananConstructor < 0)
        {
            gajiBulanan = 0;
        }
    }

    public void printGajiBulanan()
    {
        Console.WriteLine("{0} {1}\t{2}", nik, nama, gajiBulanan);
    }

    public void naikkanGajiBulanan()
    {
        gajiBulanan = Convert.ToInt32(gajiBulanan * 1.1);
    }
}