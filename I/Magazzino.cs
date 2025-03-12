
using System;

namespace ConfrontoOggettiDemo;

public class Magazzino
{
    string nome;
    List<Box> boxes;

    public Magazzino(string nome, List<Box> boxes)
    {
        this.nome = nome;
        this.boxes = boxes;
    }
    
     public Magazzino(string nome):this(nome, new List<Box>())
    {
        
    }

    public string Nome { get => nome; set => nome = value; }
    public List<Box> Boxes { get => boxes; set => boxes = value; }

    public override string ToString()
    {
        return $"{{{nameof(Nome)}: {Nome}, Numero Scatole: {boxes.Count}}}";
    }
    
    //metodo che stampa le scatole nel magazzino
    public void StampaScatole()
    {
        foreach (var scatola in boxes)
        {
            Console.WriteLine(scatola);
        }
        Console.WriteLine();
    }
    //metodo che aggiunge una scatola al magazzino
    //solo se la scatola non è già presente nel magazzino
    public bool AggiungiScatola(Box box)
    {
        //verifico prima se la scatola è già presente
        if(!boxes.Contains(box))
        {
            boxes.Add(box);
            return true;
        }
        return false;
       
        
    }
    
    public bool RimuoviScatola(Box box)
    {
        //devo cercare la scatola e se la trovo la elimino
        int posizioneScatola = boxes.IndexOf(box);
        if(posizioneScatola!=-1)
        {
            boxes.RemoveAt(posizioneScatola);
            return true;
        }
        return false;
    }
    
    public bool RimuoviScatola2(Box box)
    {
       return boxes.Remove(box);
    }
    
    public void StampaListaOrdinata()
    {
        boxes.Sort();
        StampaScatole();
    }
    
}
