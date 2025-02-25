using System.Runtime.CompilerServices;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.Write("Cas Latency (CL) hizini giriniz: ");
        int cas = Convert.ToInt32(Console.ReadLine());

        Console.Write("Megatransfer(Mt/s) hizini giriniz: ");
        int megatransfer = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(calclatency(megatransfer, cas));
    }
    private static double calclatency(int megatransfer ,int cas)
    {
        double latency = cas *2000/megatransfer;
        return latency;

    }

}