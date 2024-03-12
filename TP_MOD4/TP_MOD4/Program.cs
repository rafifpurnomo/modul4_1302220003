using TP_MOD4;

internal class Program
{
    private static void Main(string[] args)
    {
        // MEMANGGIL DATA DARI CLASS KODEPOS
        KodePos DataKodePos= new KodePos();

        String kodePostWates = DataKodePos.GetKodePos("Wates");
        String kodePostCijaura = DataKodePos.GetKodePos("Cijaura");
        String kodePostMargasari = DataKodePos.GetKodePos("Margasari");
        Console.WriteLine("ini kode post Wates: " + kodePostWates);
        Console.WriteLine("ini kode post Cijaura: " + kodePostCijaura);
        Console.WriteLine("ini kode post Margasari: " + kodePostMargasari);
    }
}