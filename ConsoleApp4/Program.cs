using System.Runtime.CompilerServices;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("RAM latency calculator");
    start:
        Console.WriteLine("-------------------------------------------------------------");

        Console.Write("Cas Latency (CL): ");
        float cas = Convert.ToInt32(Console.ReadLine());
        Console.Write("Megatransfer(MT/s): ");
        float megatransfer = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ram Latency in nanoseconds = " + calclatency(megatransfer, cas));
        Console.WriteLine("");
        Console.WriteLine("Press R to do another calculation");
        restart:
        var keyInfo = Console.ReadKey(true);
        if (keyInfo.Key == ConsoleKey.R)
            goto start;
        else
            Console.WriteLine("Please press R");
        goto restart;


    }
    private static double calclatency(float megatransfer, float cas)
    {
        float latency = cas * 2000 / megatransfer;
        return latency;

    }

}