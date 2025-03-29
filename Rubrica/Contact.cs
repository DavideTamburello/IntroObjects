using System;

namespace Rubrica;

public class Contact
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
}
