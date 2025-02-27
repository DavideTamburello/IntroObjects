﻿using EsempiCapitolo14;

internal class Program
{
	
	//creazione di un metodo parametrico
	public static void Swap<K>(ref K a, ref K b)
	{
		(b, a) = (a, b);
	}
	private static void Main(string[] args)
	{
	   //creazione di oggetti di tipo Dog
	   Dog myDog = new Dog("Lampo", 3);
	   myDog.Bark();
	   //uso di properties
	   myDog.Name="Fulmine";
	   myDog.Bark();

		// string firstDogName = null;
		// Console.Write("Enter first dog name: ");
		// firstDogName = Console.ReadLine();
		// // Using a constructor to create a dog with specified name
		// Dog firstDog = new Dog(firstDogName);
		// // Using a constructor to create a dog wit a default name
		// Dog secondDog = new Dog();
		// Console.Write("Enter second dog name: ");
		// string secondDogName = Console.ReadLine();
		// // Using property to set the name of the dog
		// secondDog.Name = secondDogName;
		// // Creating a dog with a default name
		// Dog thirdDog = new Dog();
		// Dog[] dogs = [firstDog, secondDog, thirdDog];
		// foreach (Dog dog in dogs)
		// {
		// 	dog.Bark();
		// }
		
		// //per usare la versione di Dog che si trova in Animals
		// EsempiCapitolo14.Animals.Dog cane1 = new EsempiCapitolo14.Animals.Dog();
		// cane1.Abbaia();
		
		//versione modificata di Dog con anche il Collar
		Dog dog1 = new Dog();
		dog1.Bark();
		//modifico il collare del cane (ne creo uno nuovo)
		dog1.Collar = new Collar(25); //usiamo la property Collar in scrittura --> set 
		int collarSize = dog1.Collar.Size;//usiamo la property Collar in lettura -- > get
		
		Dog myDog2 = new Dog();
		Console.WriteLine($"{myDog2.Name} {myDog2.Age} {myDog2.Length} {myDog2.Collar.Size}");
		Dog myDog3 = new Dog("Pallino",2,56,new Collar(30));
		Console.WriteLine($"{myDog3.Name} {myDog3.Age} {myDog3.Length} {myDog3.Collar.Size}");
		Dog myDog4 = new Dog("Pallino", 2);
		Console.WriteLine($"{myDog4.Name} {myDog4.Age} {myDog4.Length} {myDog4.Collar.Size}");
		
		Point p = new Point(4.5,3.8);
		Console.WriteLine(p);
		OuterClass outerClass = new OuterClass("outer");
		OuterClass.NestedClass nestedClass = new
		OuterClass.NestedClass(outerClass, "nested");
		nestedClass.PrintNames();
		
		//test di AnimalShelter
		//quando creo una istanza di una classe generica devo definire il tipo
		//parametrico
		AnimalShelter<Dog> shelter = new AnimalShelter<Dog>(10);
		//inserimento di cani nel canile
		shelter.Shelter(myDog2);
		shelter.Shelter(myDog3);
		shelter.Shelter(myDog4);
		shelter.Shelter(new Dog());
		shelter.Shelter(new Dog("Bianchino", 2, 56, new Collar(30)));
		
		//stampa dei cani
		Console.WriteLine("Stampa dei cani nel canile");
		shelter.PrintAnimals();
		//liberiamo qualche cane dal canile
		Dog mioNuovoCane = shelter.Release(4);
		mioNuovoCane.Bark();
		Dog altroCane = shelter.Release(2);
		altroCane.Bark();
		
		//un ricovero per gatti
		AnimalShelter<Cat> catShelter = new AnimalShelter<Cat>();
		catShelter.Shelter(new Cat("pallino"));
		Cat cat2 = new Cat("pallino 2");
		catShelter.Shelter(cat2);
		catShelter.Shelter(new Cat("pallino 3"));
		catShelter.Shelter(new Cat("pallino 3"));

		Console.WriteLine("Stampa dei gatti nel ricovero");
		catShelter.PrintAnimals();
		//utilizziamo la versione di Release che prende in input un reference 
		Cat? mioNuovoGatto = catShelter.Release(cat2);
		//Cat mioNuovoGatto = catShelter.Release(2);
		Console.WriteLine("Test del metodo Release che prende in input un reference");
		Console.WriteLine(mioNuovoGatto);
		
		//metodi parametrici
		//test di Swap
		Dog cane1 = new Dog("cane1");
		Dog cane2 = new Dog("cane2");
		Console.WriteLine("Stampa dei cani prima dello swap");
		Console.WriteLine($"cane 1 = {cane1}; cane 2 = {cane2}");
		Swap<Dog>(ref cane1,ref cane2);
		Console.WriteLine("Stampa dei cani dopo lo swap");
		Console.WriteLine($"cane 1 = {cane1}; cane 2 = {cane2}");


	}
}