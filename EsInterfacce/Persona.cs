using System;
using System.Runtime.CompilerServices;

namespace EsInterfacce;

public class Persona : IEquatable<Persona>, IComparable<Persona>
{
    string? codiceFiscale;
    string? nome;
    string? cognome;
    DateTime? dataNascita;
    
    public string? CodiceFiscale { get; set; }
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public DateTime DataNascita { get; set; }

    public Persona(string codiceFiscale, string nome, string cognome, DateTime dataNascita)
    {
        CodiceFiscale = codiceFiscale;
        Nome = nome;
        Cognome = cognome;
        DataNascita = dataNascita;
    }
    public Persona(string nome, string cognome) //riuso costruttore
    {
        Nome = nome;
        Cognome = cognome;
    }

    public override string ToString()
    {
        return $"{nameof(CodiceFiscale)}: {CodiceFiscale}, {nameof(Nome)}: {Nome}, {nameof(Cognome)}: {Cognome}, {nameof(DataNascita)}: {DataNascita}";
    }

    public bool Equals(Persona? other)
    {
        if(other is null)
        {
            return false;
        }
        return codiceFiscale == other.codiceFiscale;
    }
    public override bool Equals(object? obj)
    {
        if(obj is null)
        {
            return false;
        }
        if(obj is Persona other)
        {
            return Equals(other);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(codiceFiscale);
    }

    public int CompareTo(Persona? other)
    {
        if(other is null)
        {
            return 1;
        }
        int cognomeComparison = string.Compare(Cognome, other.Cognome);
        if(cognomeComparison != 0) return cognomeComparison;
        return Nome.CompareTo(other.Nome);
    }
    public int CompareTo(object? obj)
    {
        if(obj is null) return 1;
        if(obj is Persona other) return CompareTo(other);
        
        throw new ArgumentException("l'oggetto non è una Persona", nameof(obj));
    }

    public static bool operator ==(Persona left, Persona right)
    {
        if(left is null)
        {
            return right is null;
        }
        return left.Equals(right);
    }
    public static bool operator !=(Persona left, Persona right)
    {
        return !(left == right);
    }
    public static bool operator <(Persona left, Persona right)
    {
        if(left is null)
        {
            return right is not null;
        }
        if(right is null)
        {
            return false;
        }

        return left.CompareTo(right) < 0;
    }
    public static bool operator <=(Persona left, Persona right)
    {
        if(left is null)
        {
            return true;
        }
        if(right is null)
        {
            return false;
        }
        return left.CompareTo(right) <= 0;
    }
    public static bool operator >(Persona left, Persona right)
    {
        return right < left;
    }
    public static bool operator >=(Persona left, Persona right)
    {
        return right <= left;
    }


    
}
