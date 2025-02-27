
namespace Esercizio4;

public  class SysUtils
{
	public static SysTime GetSysTime()
	{
		//algoritmo di conversione
		int elapsedMs = Environment.TickCount;
		//quanti giorni
		int nGiorni = elapsedMs / (1000 * 60 * 60 * 24);
		//Console.WriteLine($"Numero giorni: {nDays}");
		//calcolo delle ore rimanenti
		int hRemaining = elapsedMs - nGiorni * 1000 * 60 * 60 * 24;
		int nOre = hRemaining / (1000 * 60 * 60);
		//Console.WriteLine($"Numero ore: {nOre}");
		//calcolo dei minuti rimanenti
		int mRemaining = hRemaining - nOre * 1000 * 60 * 60;
		int nMinuti = mRemaining / (1000 * 60);
		//Console.WriteLine($"Numero minuti: {nMinuti}");
		return new SysTime(nGiorni,nOre,nMinuti);
	}
	
	public string Ciao()
	{
		return "Ciao";

	}
}