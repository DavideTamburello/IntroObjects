using _11_03_2025;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_03_2025
{
    
    internal class Magazzino
    {
        string nome;
        List<Box> boxes;

        public Magazzino(string nome, List<Box> boxes)
        {
            this.Nome = nome;
            this.Boxes = boxes;
        }

        public Magazzino(string nome) : this(nome, new List<Box>());

        public string Nome { get => nome; set => nome = value; }
        internal List<Box> Boxes { get => boxes; set => boxes = value; }

        public override string ToString()
        {
            return $"{nameof(Nome)}: {Nome}, {nameof(Boxes)}: {Boxes}";
        }
    }

    //metodo che stampa le scatole nel magazzino
    //solo se la scatola non è già presente nel magazzino
    public void StampScatole()
    {
        foreach (var scatola in boxes)
        {
            Console.WriteLine(scatola);
        }
        Console.WriteLine();
    }

    public bool AggiungiScatola(Box box)
    {
        if(!boxes.Contains(box))
        {
            boxes.Add(box);
            return true;
        }
    }
}
