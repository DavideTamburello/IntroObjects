using System;
using System.Diagnostics.CodeAnalysis;

namespace EsInterfacce;

public class PersonaEqualityComparer : EqualityComparer<Persona>
{
    public override bool Equals(Persona? x, Persona? y)
    {
        if(x is null && y is null) return true;
        if(x is null || y is null) return false;

        return x.Nome == y.Nome && x.Cognome == y.Cognome && x.DataNascita == y.DataNascita;
    }

    public override int GetHashCode([DisallowNull] Persona obj)
    {
        return HashCode.Combine(obj.Nome, obj.Cognome, obj.DataNascita);
    }
}
