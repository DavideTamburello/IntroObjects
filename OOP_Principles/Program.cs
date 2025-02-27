﻿using OOPPrinciples.LabClassi;

internal class Program
{
	private static void Main(string[] args)
	{
		//creazione di oggetti derivanti da una gerarchia di classi
		Felidae f = new Felidae();
		Lion lion = new Lion(false, 200);
		AfricanLion africanLion = new AfricanLion(true, 300);
		Console.WriteLine(lion);
		//conversione di oggetti da un tipo ad un altro --> navigare la gerarchia

		// il cast implicito è sempre possibile - up casting
		//corrisponde ad assegnare a un reference di tipo base class un oggetto 
		//di tipo sottoclasse


		//posso assegnare un oggetto di tipo Lion a un reference di tipo object
		//perché un AfricanLion è un object

		//questa operazione si chiama cast implicito
		object objectLion = africanLion;
		// cast implicito --> è possibile perché un AfricanLion is a Lion
		Felidae felidae = africanLion;
		Console.WriteLine("stampa di felide ottenuto da AfricanLion");
		Console.WriteLine(felidae);

		//cast esplicito -- down casting

		//supponiamo di avere un oggetto che è un AfricanLion referenziato mediante un object
		object leonObj = new AfricanLion(true, 200);
		object myObj = new object();
		//dopo alcune righe di codice...

		//cast esplicito - non sempre si può fare
		//il cast esplicito può essere fatto quando l'oggetto puntato dal reference
		//è "compatibile" con il tipo dell'oggetto target
		//"compatibile" --> il tipo a destra dell'espressione di assegnamento è dello stesso tipo dell'oggetto target (a sinistra)
		// 					oppure discende dal tipo dell'oggetto target a sinistra
		AfricanLion myAfricanLion = (AfricanLion)leonObj;
		Console.WriteLine("Stampa di myAfricanLion a partire dal cast esplicito");
		Console.WriteLine(myAfricanLion);

		//cast esplicito - non sempre si può fare
		try
		{
			AfricanLion myObjectAsAfricanLion = (AfricanLion)myObj;
			Console.WriteLine("Stampa di myObjectAsAfricanLion a partire dal cast esplicito");
			Console.WriteLine(myObjectAsAfricanLion);
		}
		catch (InvalidCastException e)
		{

			//gestire l'eccezione
			Console.WriteLine("Cast non possibile");
			Console.WriteLine(e.Message);
		}

		//domanda: quando abbiamo una gerarchia e un metodo con lo stesso nome in 
		//in più classi della gerarchia (ad esempio in Lion e AfricanLion) quale versione
		//del metodo viene utilizzata a runtime quando si utilizza un reference?
		AfricanLion africanLion1 = new AfricanLion(true, 300);
		Lion lion1 = africanLion1;
		object objectLeone = new AfricanLion(false, 200);
		Lion lion2 = (Lion)objectLeone;
		//se stampo lion1 quale versione del ToString viene invocata? quella di Lion o 
		//quella di AfricanLion?
		Console.WriteLine("Stampa di un oggetto con un reference di tipo base class");
		Console.WriteLine(lion1);
		//viene utilizzato la versione del tipo "effettivo" dell'oggetto puntato al tempo di esecuzione
		Console.WriteLine("Stampa di un object che di fatto è un AfricanLion");
		Console.WriteLine(objectLeone);

		object myObject2 = new object();
		Console.WriteLine(myObject2);

		//questo che abbiamo visto riguarda i metodi che sono virtual
		Console.WriteLine("Stampa di \"MiPresento\" con reference di tipo AfricanLion");
		africanLion1.MiPresento();
		//anche se saliamo nella gerarchia con il reference la versione che viene eseguita è quella dell'oggetto 
		//puntato a runtime. Nel caso seguente l'oggetto puntato da objectLeone è un AfricanLion e anche se 
		//il reference è di tipo object, oppure Lion la versione del metodo che viene invocata è quella di AfricanLion
		Console.WriteLine("Stampa di \"MiPresento\" con reference di tipo Lion, ma l'oggetto puntato è di tipo AfricanLion");
		((Lion)objectLeone).MiPresento();
		//lo stesso comportamento anche se il reference è di tipo base class
		Console.WriteLine("Stampa di \"MiPresento\" con reference di tipo Lion, ma l'oggetto puntato è di tipo AfricanLion");
		lion2.MiPresento();
		//nell'esempio precedente non viene eseguita la versione di MiPresento dichiarata dentro la classe Lion, ma 
		//la versione dichiarata nella classe AfricanLion perché il metodo MiPresento è virtual e quindi la versione
		//eseguita è sempre quella del tipo effettivo dell'oggetto puntato dal reference. Non importa quale sia il tipo 
		//del reference. Quello che conta è il tipo dell'oggetto puntato.

		//regola: quando si crea un metodo virtual è possibile eseguire l'override di tale metodo nelle classi derivate

		//tenere ben presente che:
		//1) A method, which can be overridden, is called virtual. In .NET, methods are not virtual by default. If we want a method to be overridable, we can do so by including the keyword virtual in the declaration of the method.

		//2) It turns out that when we override a method, we cannot access the old implementation even if we use up casting.

		//metodi ridefiniti mediante l'operatore new (meno usato) - viene impiegato quando vogliamo rendere accessibile sia l'implementazione nella classe derivata che quella nella base class.

		Console.WriteLine("Stampa di \"Ruggisci\" con reference di tipo AfricanLion");
		africanLion1.Ruggisci();
		Console.WriteLine("Stampa di \"Ruggisci\" con reference di tipo Lion, ma l'oggetto puntato è di tipo AfricanLion");
		((Lion)objectLeone).Ruggisci();
		Console.WriteLine("Stampa di \"Ruggisci\" con reference di tipo Lion, ma l'oggetto puntato è di tipo AfricanLion");
		lion2.Ruggisci();

		//regola: quando si crea un metodo con la keyword new si va a ridefinire un metodo di una base class, ma l'accesso
		//alle versioni del metodo sull'oggetto avviene in maniera diversa rispetto a quanto visto con i metodi virtual.
		
		//quando i metodi sono sovrascritti con la keyword new nelle classi derivate è sempre possibile accedere anche 
		//alle versioni del metodo definite nelle base class, navigando la gerarchia e la versione del metodo invocata 
		//è quella del tipo del reference e non quella del tipo effettivo dell'oggetto puntato

		//testing dell'interfaccia IRiproducible

		Lion leoneUno = new Lion(true, 200);//leone maschio
		Lion leoneDue = new Lion(false, 150);//leone femmina
		Lion[] leoncini = leoneUno.Reproduce(leoneDue);
		Console.WriteLine("Ecco i leoncini");
		foreach (Lion leoncino in leoncini)
		{
			Console.WriteLine(leoncino);
		}


	}
}