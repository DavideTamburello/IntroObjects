using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //esempio sbagliatp
        Stopwatch sw = new Stopwatch();
        sw.Start();
        for(int i = 1; i <= 200000; i++)
        {
            collector += i;
        }
        sw.Stop();
        var elapsedMilliseconds = sw.ElapsedMilliseconds;
        Console.WriteLine(HandleCollector.Substring(..1024));
        Console.WriteLine($"la versione sbagliata della concatenazione impiega ElapsedMilliseconds");

        //versione corretta - uso di StringBuilder
        StringBuilder sb = new();
        sb.Append("numbers: ");
        for(int i = 1; i <= 200000; i++)
        {
            //collector += i
            sb.Append(i);
        }
        Console.WriteLine(sb.ToString()[0, 1024]);
        Console.WriteLine($"la versione sbagliata della concatenazione impiega {elapsedMilliseconds}ms");

    }
}