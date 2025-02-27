﻿using Esercizio4;
//Write a program, which prints on the standard output the count of days, hours, 
// and minutes, which have passes since the computer is started until the moment
//  of the program execution. For the implementation use the class Environment.
internal class Program
{
	
	
	private static void Main(string[] args)
	{
		//per i campi statici (metodi, properties, fields) utilizzo
		//il nome della classe per accedere al campo
		Console.WriteLine(SysUtils.GetSysTime());
		//per i campi di istanza (ossia riferiti ad un singolo oggetto)
		//utilizzo il nome del reference 
		SysUtils myUtils = new SysUtils();
		Console.WriteLine(myUtils.Ciao());



	}
}