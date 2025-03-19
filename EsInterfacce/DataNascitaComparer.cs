using System;

namespace EsInterfacce;

public class DataNascitaComparer : Comparer<Persona>
{
    public override int Compare(Persona? x, Persona? y)
    {
        if(x is null && y is null) return 0;
        if(x is null) return -1;
        if(y is null) return 1;

        return x.DataNascita.CompareTo(y.DataNascita);
    }
}
