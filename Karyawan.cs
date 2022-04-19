public class Karyawan
{
    public string nik{get; set;}
    public string nama{get; set;}
    public int gajiBulanan{get; set;}

    public Karyawan(string nikConst, string namaConst, int gajiBulananConst)
    {
        nik = nikConst;
        nama = namaConst;
        gajiBulanan = gajiBulananConst;
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