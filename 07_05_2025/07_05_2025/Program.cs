using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            string path = @"C:\Users\DAVIDETAMBURELLO3IA_\Desktop\aaa";
            if (Directory.Exists(path))
            {
                string[] elencoStringhe = Directory.GetDirectories(path);
                GetDirectories2(elencoStringhe);
                GetFiles2(path);
            }

        }catch(DirectoryNotFoundException dnfe)
        {
            Console.WriteLine(dnfe.Message);
        }
    }
    public static void GetDirectories2(string[] elencoStringhe)
    {
        foreach(string item in elencoStringhe)
        {
            Console.WriteLine(Path.GetFileName(item));

            foreach (string file in Directory.GetFiles(item))
            {
                Console.WriteLine("\t" + Path.GetFileName(file));

            }
            foreach (string cartella in Directory.GetDirectories(item))
            {
                Console.WriteLine("\t" + Path.GetFileName(cartella));
                GetFiles2(Path.GetFullPath(cartella));

            }
        }
    }
    public static void GetFiles2(string path)
    {
        foreach (var item in Directory.GetFiles(path))
        {
            Console.WriteLine(Path.GetFileName(item));

        }
    }
}