
using _11_03_2025;
using _12_03_2025;
using ConfrontoOggettiDemo;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //testing di Box
        Box b1 = new Box(2, 3, 4);
        Box b2 = new Box(2, 3, 4);
        if (b1 == b2)
        {
            Console.WriteLine("le due scatole sono uguali");
        }

        //gestione di un elenco di oggetti
        List<Box> boxes = new List<Box>(); // questo crea una lista vuota
        List<int> ints = new List<int>();
        ints.Add(1);
        ints.AddRange([2, 3, 4, 5]);
        List<int> dispari = [1, 3, 5, 7, 9];
        ints.AddRange(dispari);
        //processing di una lista
        for(int i = 0; i < ints.Count; i++)
        {
            Console.Write(ints[i] + " ");
        }
        Console.WriteLine();
        //versione con foreach
        foreach(var numero in ints)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();

        //alcuni metodi notevoli
        //modifica di un elemento
        ints[1] = 10;
        foreach (var numero in ints)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
        //inserire un nuovo elemento in coda --> Add oppure AddRange
        //inserire un nuovo elemento in una specifica posizione
        ints.Insert(2, 9);
        foreach (var numero in ints)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();

        //rimuovere elemento dalla lista
        //RemoveAt prende come parametro la posizione
        ints.RemoveAt(2);
        foreach (var numero in ints)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();

        //Remove prende come parametro l'oggetto
        //la Remove confronta gli oggetti presenti nella lista e chiede che gli oggetti implementino l'interfaccia IEquatable<T>
        ints.Remove(10);
        foreach (var numero in ints)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();

        //verifico se un oggetto è presente nella lista
        //verifico se l'oggetto 5 è presente nella lista
        //richiede IEquatable<T>
        if(ints.Contains(5))
        {
            Console.WriteLine("il numero 5 è presente nella lista");
        }else
        {
            Console.WriteLine("il numero 5 NON è presente nella lista");
        }

        //posso anche trovare la posizione di un oggetto, se non lo trova da -1
        int pos = ints.IndexOf(5);
        if(pos != -1)
        {
            Console.WriteLine($"il numero 5 è presente in posizione {pos}");
        }else
        {
            Console.WriteLine("il numero 5 NON è presente");
        }

        //gestione magazzino
        Magazzino magazzino = new Magazzino("Mercatone delle scatole");
        //aggiungo scatole al magazzino
        magazzino.Boxes.Add(new Box(3, 2, 1));
        magazzino.Boxes.Add(new Box(1, 2, 3));
        magazzino.Boxes.Add(new Box(4, 5, 6));
        magazzino.Boxes.Add(new Box(7, 8, 9));
        magazzino.Boxes.Add(new Box(10, 10, 10));

        //fare la lista delle scatole
        foreach(var scatola in magazzino.Boxes)
        {
            Console.WriteLine(scatola);
        }


        
    }
}