using System;

namespace EsempiCapitolo14;

// public class AnimalShelter
// {

// 	private const int DefaultPlacesCount = 20;
// 	private Dog[] animalList;
// 	private int usedPlaces;
// 	public AnimalShelter() : this(DefaultPlacesCount)
// 	{
// 	}
// 	public AnimalShelter(int placesCount)
// 	{
// 		animalList = new Dog[placesCount];
// 		usedPlaces = 0;
// 	}
// 	public void Shelter(Dog newAnimal)
// 	{
// 		if (usedPlaces >= animalList.Length)
// 		{
// 			throw new InvalidOperationException("Shelter is full.");
// 		}
// 		animalList[usedPlaces] = newAnimal;
// 		usedPlaces++;
// 	}
// 	public Dog Release(int index)
// 	{
// 		if (index < 0 || index >= usedPlaces)
// 		{
// 			throw new ArgumentOutOfRangeException(
// 			"Invalid cell index: " + index);
// 		}
// 		Dog releasedAnimal = animalList[index];
// 		//compattamento con shift a sinistra
// 		for (int i = index; i < usedPlaces - 1; i++)
// 		{
// 			animalList[i] = animalList[i + 1];
// 		}

// 		animalList[usedPlaces - 1] = null;
// 		usedPlaces--;
// 		return releasedAnimal;
// 	}
// }

//definizione di una classe generica: una classe parametrica rispetto a uno o più tipi
public class AnimalShelter<T>
{

	private const int DefaultPlacesCount = 20;
	private T[] animalList;
	private int usedPlaces;
	public AnimalShelter() : this(DefaultPlacesCount)
	{
	}
	public AnimalShelter(int placesCount)
	{
		animalList = new T[placesCount];
		usedPlaces = 0;
	}
	public void Shelter(T newAnimal)
	{
		if (usedPlaces >= animalList.Length)
		{
			throw new InvalidOperationException("Shelter is full.");
		}
		animalList[usedPlaces] = newAnimal;
		usedPlaces++;
	}
	public T Release(int index)
	{
		if (index < 0 || index >= usedPlaces)
		{
			throw new ArgumentOutOfRangeException(
			"Invalid cell index: " + index);
		}
		T releasedAnimal = animalList[index];
		//compattamento con shift a sinistra
		for (int i = index; i < usedPlaces - 1; i++)
		{
			animalList[i] = animalList[i + 1];
		}

		animalList[usedPlaces - 1] = default;
		usedPlaces--;
		return releasedAnimal;
	}
	
	//
	public void PrintAnimals()
	{
		for (int i = 0; i <usedPlaces; i++)
		{
			Console.WriteLine(animalList[i]);
		}

	}

	//versione del metodo release che accetta in input un reference ad un oggetto
	public T? Release(T dogToRelease)
	{
		//ricerco l'oggetto nella lista 
			//se lo trovo prendo il suo indice 
			//se non lo trovo restituisco null
		int index = -1;
		int i=0;
		bool trovato = false;
		while(!trovato && i<usedPlaces)
		{
			if(animalList[i]!=null && animalList[i]!.Equals(dogToRelease))
			{
				index = i;
				trovato =true;
			}
			i++;
		}
		//se non ho trovato
		if(!trovato)
		{
			return default;

		}
		T releasedAnimal = animalList[index];
		//compattamento con shift a sinistra
		for (int k = index; k < usedPlaces - 1; k++)
		{
			animalList[k] = animalList[k + 1];
		}
		animalList[usedPlaces - 1] = default;
		usedPlaces--;
		return releasedAnimal;

	}
}