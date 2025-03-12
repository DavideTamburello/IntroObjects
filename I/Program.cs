﻿using ConfrontoOggettiDemo;

internal class Program
{
    private static void Main(string[] args)
    {
    
        Temperature t1 = new Temperature(20);
        Temperature t2 = new Temperature(20);
        Temperature t3 = t1;//t3 punta allo stesso oggetto puntato da t1
        //tutti gli oggetti ereditano Equals di Object che considera uguali
        //due oggetti se e solo se sono lo stesso oggetto in memoria
        if( t1.Equals(t2))
        {
            Console.WriteLine("I due oggetti sono uguali");
        }else
        {
            Console.WriteLine("I due oggetti sono distinti");
        }
        if (t1 == t2)
        {
            Console.WriteLine("I due oggetti sono uguali - versione con ==");
        }
        else
        {
            Console.WriteLine("I due oggetti sono distinti - versione con ==");
        }

        if (t1 == t3)
        {
            Console.WriteLine("I due oggetti t1 e t3 sono uguali - versione con ==");
        }
        else
        {
            Console.WriteLine("I due oggetti t1 e t3 sono distinti - versione con ==");
        }
        
        //testing di Box 
        Box b1 = new Box(2,3,4);
        Box b2 = new Box(2,3,4);
        if(b1 == b2)
        {
            Console.WriteLine("Le due scatole sono uguali");
        }
        Console.WriteLine("Stampiamo le scatole");
        Console.WriteLine($"Box b1 = {b1}");
        Console.WriteLine($"Box b2 = {b2}");
        
        //gestione di un elenco di oggetti
        List<Box> boxes = new List<Box>();//crea una lista vuota
        List<int> ints = new List<int>();
        ints.Add(1);
        ints.Add(4);
        ints.Add(5);
        ints.Add(7);
        ints.AddRange([3,5,6,]);//aggiungo un elenco di oggetti alla lista
        List<int> dispari = [1,3,5,7];
        ints.AddRange(dispari);
        //processing di una lista
        for (int i = 0; i < ints.Count; i++)
        {
            Console.Write(ints[i]+" ");
        }
        Console.WriteLine();
        //versione foreach
        foreach (var numero in ints)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
        //alcuni metodi notevoli
        //modifica di un elemento
        ints[1]=10;
        foreach (var numero in ints)
        {
            Console.Write(numero + " ");
        }
        //inserire un nuovo elemento in coda --> Add oppure AddRange
        //inserire un nuovo elemento in una specifica posizione
        ints.Insert(2, 9);
        Console.WriteLine();
        foreach (var numero in ints)
        {
            Console.Write(numero + " ");
        }
        //rimuovere un elemento dalla lista
        //prende come parametro la posizione
        ints.RemoveAt(2);
        Console.WriteLine();
        foreach (var numero in ints)
        {
            Console.Write(numero + " ");
        }
        //prende come parametro l'oggetto
        //Remove confronta gli oggetti presenti nella lista e richiede che 
        //gli oggetti implementino l'interfaccia IEquatable<T>
        ints.Remove(10);
        Console.WriteLine();
        foreach (var numero in ints)
        {
            Console.Write(numero + " ");
        }

        //verificare se un oggetto è presente nella lista
        //verifico se l'oggetto 5 è presente nella lista
        Console.WriteLine();
        //richiede IEquatable<T>
        if (ints.Contains(5))
        {
            Console.WriteLine("Il numero 5 è presente");
        }else
        {
            Console.WriteLine("Il numero 5 NON è presente");
        }
        //posso anche trovare la posizione dell'oggetto 5
        //richiede IEquatable<T>
        int pos = ints.IndexOf(5);
        if(pos !=-1)
        {
            Console.WriteLine($"Il numero 5 è presente in posizione {pos}");
        }else
        {
            Console.WriteLine("Il numero 5 NON è presente");
        }

        //gestione magazzino
        Magazzino magazzino = new Magazzino("Mercato delle scatole");
        //aggiungo scatole al magazzino
        magazzino.Boxes.Add(new Box(3,2,1));
        magazzino.Boxes.Add(new Box(3,3,2));
        magazzino.Boxes.Add(new Box(3,2,1));
        magazzino.Boxes.Add(new Box(4,4,5));
        magazzino.Boxes.Add(new Box(3,2,6));
        magazzino.Boxes.Add(new Box(5,2,7));
        
        //stampare la lista delle scatole
        foreach (var scatola in magazzino.Boxes)
        {
            Console.WriteLine(scatola);
        }
        Console.WriteLine();
        //stampa scatole con il metodo del Magazzino
        Console.WriteLine("stampa scatole con il metodo del Magazzino");
        magazzino.StampaScatole();
        bool inserito = magazzino.AggiungiScatola(new Box(3, 3, 2));
        if(inserito)
        {
            Console.WriteLine("La scatola è stata inserita");
        }else 
        {
            Console.WriteLine("La scatola non è stata inserita");
        }
        Console.WriteLine("stampa scatole con il metodo del Magazzino dopo AggiungiScatola");
        magazzino.StampaScatole();
        
        //test rimozione scatole
        Console.WriteLine("Rimozione della scatola Box(3,3,2)");
        magazzino.RimuoviScatola2(new Box(3, 3, 2));
        magazzino.StampaScatole();
        
        //sulle liste è possibile fare l'ordinamento con il metodo Sort
        //gli elementi nella lista devono aver implementato l'interfaccia IComparable<T>
        ints.Sort();
        foreach (var numero in ints)
        {
            Console.Write(numero+" ");
        }
        Console.WriteLine();
        
        //per fare il Sort occorre aver implementato IComparable<Box>
        Console.WriteLine("Stampa delle scatole ordinate per volume");
        magazzino.StampaListaOrdinata();




    }
}