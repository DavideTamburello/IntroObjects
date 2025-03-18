using System;

namespace ConfrontoOggettiDemo;

public class Box : IEquatable<Box>, IComparable<Box>
{
    double larghezza;
    double profondità;
    double altezza;

    public Box(double larghezza, double profondità, double altezza)
    {
        this.larghezza = larghezza;
        this.profondità = profondità;
        this.altezza = altezza;
    }

    public double Larghezza { get => larghezza; set => larghezza = value; }
    public double Profondità { get => profondità; set => profondità = value; }
    public double Altezza { get => altezza; set => altezza = value; }

    // public double Volume
    // {
    //     get
    //     {
    //         return larghezza * profondità * altezza;
    //     }
    // }

    public double Volume { get => larghezza * profondità * altezza; }

    /// <summary>
    /// Due Box sono uguali e solo se hanno uguali dimensioni
    /// </summary>
    /// <param name="other">L'altra Box</param>
    /// <returns>true se le due Box hanno le stesse dimensioni</returns>
    /// <exception cref="NotImplementedException"></exception>
    public bool Equals(Box? other)
    {
        if (other is null)
        {
            return false;
        }
        return larghezza == other.larghezza && profondità == other.profondità && altezza == other.altezza;
    }

    public override bool Equals(object? obj)
    {
        //gestione casi nulli
        if (obj is null)
        {
            return false;
        }
        //verifico se obj è di tipo Box e nel caso verifico l'uguaglianza
        //se obj non è Box restituisco false
        if (obj is Box other)
        {
            return Equals(other);
        }
        return false;
    }
    public override int GetHashCode()
    {
        //utilizziamo un criterio coerente per la definizione del Equals e del GetHashCode
        return HashCode.Combine(larghezza, profondità, altezza);
    }

    public static bool operator ==(Box left, Box right)
    {
        //gestire i casi nulli
        if (left is null)
        {
            return right is null;
        }
        //usare Equals per l'uguaglianza
        return left.Equals(right);
    }
    public static bool operator !=(Box left, Box right)
    {
        return !(left == right);
    }

    public static bool operator <(Box left, Box right)
    {
        if (left is null)
        {
            return right is not null;
        }
        return left.CompareTo(right) < 0;
    }

    public static bool operator <=(Box left, Box right)
    {
        if (left is null)
        {
            return true;
        }
        return left.CompareTo(right) <= 0;
    }

    public static bool operator >(Box left, Box right)
    {
        //richiamo l'operatore già definito
        return right < left;
    }

    public static bool operator >=(Box left, Box right)
    {
        //richiamo l'operatore già definito
        return right <= left;
    }

    public override string ToString()
    {
        return $"{{{nameof(Larghezza)}: {Larghezza}, {nameof(Profondità)}: {Profondità}, {nameof(Altezza)}: {Altezza}, {nameof(Volume)}: {Volume}}}";
    }

    //definisco l'odinamento "naturale 
    public int CompareTo(Box? other)
    {
        if (other is null)
        {
            return 1;
        }
        return Volume.CompareTo(other.Volume);
    }


}