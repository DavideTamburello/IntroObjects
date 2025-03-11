using _11_03_2025;

internal class Program
{
    private static void Main(string[] args)
    {
        //testing di Box
        Box b1 = new Box(2, 3, 4);
        Box b2 = new Box(2, 3, 4);
        if(b1 == b2)
        {
            Console.WriteLine("le due scatole sono uguali");
        }
    }
}