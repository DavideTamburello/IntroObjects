using System;

namespace OOPPrinciples.LabClassi;
//con base Class diciamo che Lion discende da Felidae
//in C# esiste l'ereditarietà singola --> una classe può discendere da una sola 
//base class.
//Una classe però può implementare un numero illimitato di interfacce
//le interfacce rappresentano contratti che le classi devono rispettare
//le interfacce non possono contenere campi dati, ma solo metodi e proprietà e costanti
//le interfacce non possono contenere implementazioni dei metodi 
public class Lion:Felidae,IRiproducible<Lion>
{
	private int weight;
	// Keyword "base" will be explained in the next paragraph
	//base è il costruttore di Felidae ossia la classe da cui deriva Lion
	public Lion(bool male, int weight) : base(male)
	{
		this.weight = weight;
	}
	
	public int Weight
	{
		get { return weight; }
		set { this.weight = value; }
	}

	public override string ToString()
	{
		//il Lion eredita il genere dalla classe Felidae
		string genere = Male ? "maschio" : "femmina";
		return $"Sono un leone {genere} e peso {weight} Kg";
	}

	public virtual void MiPresento()
	{
	    Console.WriteLine($"Sono un {nameof(Lion)} e sono molto aggressivo");
	}

	public void Ruggisci()
	{
	    Console.WriteLine($"Sono un {nameof(Lion)} e ruggisco così: Roarrrr!!!");
	}

    public Lion[] Reproduce(Lion mate)
    {
		//versione più realistica
		
		//controlliamo se i generi dei due leoni che si riproducono sono diversi
		if(Male != mate.Male)
		{
			Random gen = new Random();
			int numeroDiLeoncini = gen.Next(1, 4);
			Lion[] leoncini = new Lion[numeroDiLeoncini];
			for (int i = 0; i < numeroDiLeoncini; i++)
			{
				//a caso decidiamo se il leoncino è maschio o femmina
				//il peso va a caso tra tra 1 e 2 Kg
				leoncini[i] = new Lion(gen.Next(0, 2) == 0, gen.Next(1, 3));
			}
			return leoncini;
		}
		return [];
	}
}