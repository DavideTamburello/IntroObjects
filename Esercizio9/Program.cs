﻿
//Write a program, which calculates the count of workdays between the current
// date and another given date after the current (inclusive). Consider that 
// workdays are all days from Monday to Friday, which are not public holidays,
// except when Saturday is a working day. The program should keep a list 
// of predefined public holidays, as well as a list of predefined working Saturdays.

internal class Program
{
	private static void Main(string[] args)
	{
		//elenco festività previste dino al 6 giugno
		DateTime[] elencoFestività = [new DateTime(2025,3,7), new DateTime(2025, 4,17)];//...
		
		//data di oggi
		DateTime oggi = DateTime.Today;
		//data futura
		DateTime dataFine = new DateTime(2025, 6, 6);
		//calcolo dei giorni feriali
		DateTime date = oggi;
		int nGiorniFeriali = 0;
		while(date <= dataFine)
		{
			if(date.DayOfWeek != DayOfWeek.Sunday && 
				date.DayOfWeek != DayOfWeek.Saturday && 
				!elencoFestività.Contains(date))
			{
	
				nGiorniFeriali++;
			}
			date = date.AddDays(1);
		}
		Console.WriteLine($"Numero giorni feriali: {nGiorniFeriali}");
		
	}
}