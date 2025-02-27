using System;

namespace Esercizio4;

public struct SysTime
{
	public int Giorni { get; set; }
	public int Ore { get; set; }
	public int Minuti { get; set; }
	
	public SysTime(int giorni, int ore, int minuti)
	{
		Giorni = giorni;
		Ore = ore;
		Minuti = minuti;
	}

    public override string ToString()
    {
        return $"Giorni = {Giorni}, Ore = {Ore}, Minuti = {Minuti}";
    }

}