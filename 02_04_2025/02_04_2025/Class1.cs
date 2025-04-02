using System;

namespace Rubrica;

public class Contact : IEquatable<Contact>
{
    public string Nome { get; set; }
    public string NumeroTelefono { get; set; }
    public string Email { get; set; }

    public Contact(string nome, string numeroTelefono, string email)
    {
        Nome = nome;
        NumeroTelefono = numeroTelefono;
        Email = email;
    }

    override public string ToString()
    {
        return $"{nameof(Nome)}: {Nome}, {nameof(NumeroTelefono)}: {NumeroTelefono}, {nameof(Email)}: {Email}";
    }

    public bool Equals(Contact? other)
    {
        if(other is null)
        {
            return false;
        }
        return Nome == other.Nome && NumeroTelefono == other.NumeroTelefono && Email == other.Email;
    }
    public override bool Equals(object? obj)
    {
        return Equals(obj as Contact);
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Nome, NumeroTelefono, Email);
    }
}