using System.Security.Authentication;
using EsInterfacce;

internal class Program
{
    private static void Main(string[] args)
    {
        Persona persona1 = new Persona("1", "antonio", "a", DateTime.Today);
        Persona persona2 = new Persona("2", "antonio", "b", DateTime.Today);
        Persona persona3 = new Persona("3", "antonio", "c", DateTime.Today);
        Persona persona4 = new Persona("4", "antonio", "d", DateTime.Today);
        Persona persona5 = new Persona("5", "antonio", "e", DateTime.Today);

        List<Persona> persone = [persona1, persona2, persona3, persona4, persona5];

        persone.Sort();
        System.Console.WriteLine(persone);

        
    }
}