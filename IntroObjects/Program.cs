﻿using IntroObjects;

internal class Program
{
	private static void Main(string[] args)
	{
		//il main è l'entry point della nostra applicazione
		//creo una istanza (oggetto) della classe Cat
		Cat firstCat = new Cat();
		firstCat.Name="Tom";
		//sto interagendo con l'oggetto Tom
		firstCat.SayMiau();
		
		Cat secondCat = new Cat();
		secondCat.SayMiau();
		
		
		Cat gattino3 = new Cat("Pallina","bianco");
		gattino3.SayMiau();
		Console.WriteLine($"Ciao, mi chiamo {gattino3.Name} e il mio colore è {gattino3.Color}");
		//quanti gatti sono stati creati?
		//se un campo è statico devo accedervi mediante la classe e non mediante 
		//il reference ad un oggetto
		Console.WriteLine($"Sono stati creati {Cat.CatCounter} gattini");
		//test di RandomPasswordGenerator
		Console.WriteLine($"Password: {RandomPasswordGenerator.GetPassword()}");
		Console.WriteLine($"Password: {RandomPasswordGenerator.GetPassword()}");
		Console.WriteLine($"Password: {RandomPasswordGenerator.GetPassword()}");
		Console.WriteLine($"Password: {RandomPasswordGenerator.GetPassword()}");
		Console.WriteLine($"Password: {RandomPasswordGenerator.GetPassword()}");
		Console.WriteLine($"Password: {RandomPasswordGenerator.GetPassword()}");
		
		string myPassword = RandomPasswordGenerator.GetPassword();

	}
}