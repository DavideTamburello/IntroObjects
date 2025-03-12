using System;

namespace ConfrontoOggettiDemo;

public class Temperature:IEquatable<Temperature> 
{
    //internamente la classe Temperature memorizza la temperatura in gradi 
    //Fahrenheit
    protected double temperatureF;

    public double Fahrenheit
    {
        get
        {
            return temperatureF;
        }
        set
        {
            temperatureF = value;
        }
    }

    public double Celsius
    {
        get
        {
            return (temperatureF - 32) * (5.0 / 9);
        }
        set
        {
            temperatureF = (value * 9.0 / 5) + 32;
        }

    }

    public Temperature(double celsius)
    {
        Celsius = celsius;
    }

    //ridefiniamo il concetto di uguaglianza

    public override bool Equals(object? obj)
    {
        //verifico che obj sia non nullo e dello stesso tipo di Temperature
        if(obj is null)
        {
            return false;
        }
        // if (obj is not Temperature other)
        // {
        //     return false;
        // }
        // //verifico che i valori di temperatura siano identici
        // return temperatureF.Equals(other.temperatureF);
        //riuso l'Equals tipizzato
        if(obj is Temperature other)
        {
            return Equals(other);//richiama Equals tipizzato
        }
        return false;
        
        
    }
    //l'algoritmo di hashing restituisce con altissima probabilità numeri interi diversi se gli oggetti
    //passati in input sono diversi. Tuttavia è possibile avere quelle che si chiamano 
    //"collisioni", ossia, con bassissima probabilità, è possibile che due oggetti distinti
    //abbiano lo stesso numero intero di hash
    //CONTRATTO CHE DEVE ESSERE SEMPRE GARANTITO: se due oggetti sono uguali, devono avere lo stesso hash code
    //==> oggetti "equals" hanno lo stesso "hash code"
    public override int GetHashCode()
    {
       return HashCode.Combine(temperatureF);
    }

    public bool Equals(Temperature? other)
    {
        //versione tipizzata dell'Equals
        if(other is null)
        {
            return false;
        }
        //bisogna garantire un comportamento coerente tra la versione di Object.Equals e la versione di
        //IEquatable.Equals
        return temperatureF.Equals(other.temperatureF);
    }

    //override degli operatori
    public static bool operator == (Temperature left, Temperature right)
    {
        //dobbiamo assicurarci che left e right siano non nulli
        //si possono usare alcuni approcci per garantire ciò
        
        //1) usare il metodo statico Object.Equals
        //return Object.Equals(left, right);
        
        //2) usare il metodo statico Object.ReferenceEquals(reference, null) che è la stessa cosa che 
        //   scrivere reference is null
        if (left is null)
        {
            return right is null;
        }
        return left.Equals(right);
        //return left.temperatureF == right.temperatureF;
    }
    public static bool operator !=(Temperature left, Temperature right)
    {
        return !(left == right);
    }
}