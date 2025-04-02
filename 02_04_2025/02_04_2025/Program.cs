using System;
using System.Collections;
using System.Collections.Generic;

namespace Rubrica;

public class ContactBook : IEnumerable<Contact>
{
    Dictionary<string, Contact> nome = new Dictionary<string, Contact>();
    Dictionary<string, Contact> numero = new Dictionary<string, Contact>();
    Dictionary<string, Contact> email = new Dictionary<string, Contact>();
    List<Contact> contatti = new List<Contact>();

    public void AddContact(Contact contatto)
    {
        nome.Add(contatto.Nome, contatto);
        numero.Add(contatto.NumeroTelefono, contatto);
        email.Add(contatto.Email, contatto);
        contatti.Add(contatto);
    }
    public Contact? SearchContact(string searchTerm)
    {
        foreach (var contatto in nome)
        {
            if (contatto.Key == searchTerm)
            {
                return contatto.Value;
            }
        }
        foreach (var contatto in numero)
        {
            if (contatto.Key == searchTerm)
            {
                return contatto.Value;
            }
        }
        foreach (var contatto in email)
        {
            if (contatto.Key == searchTerm)
            {
                return contatto.Value;
            }
        }
        return null;
    }
    public void ModifyContact(string nameToModify, Contact newContactInfo)
    {
        if(nome.ContainsKey(nameToModify))
        {
            string? emailDaEliminare;
            string? numeroDaEliminare;
            //elimino contatto corrispondente
            if (nome[nameToModify].Email != null)
            {
                emailDaEliminare = nome[nameToModify].Email;
                email.Remove(emailDaEliminare!);
            }
            if (numero[nameToModify].NumeroTelefono != null)
            {
                numeroDaEliminare = nome[nameToModify].NumeroTelefono;
                email.Remove(numeroDaEliminare!);


            }
            contatti.Remove(newContactInfo);
            nome.Remove(nameToModify);

            //aggiungo il nuovo contatto
            contatti.Add(newContactInfo);

            if(newContactInfo.Email != null)
            {
                nome[newContactInfo.Email] = newContactInfo;
            }
            if (newContactInfo.Nome != null)
            {
                nome[newContactInfo.Nome] = newContactInfo;
            }
            if (newContactInfo.NumeroTelefono != null)
            {
                nome[newContactInfo.NumeroTelefono] = newContactInfo;
            }
        }
    }
    public void DeleteContact(string nameToDelete)
    {
        int i = 0;
        foreach (var contatto in nome)
        {
            if (contatto.Key == nameToDelete)
            {
                nome.Remove(nameToDelete);
                numero.Remove(nameToDelete);
                email.Remove(nameToDelete);
                contatti.RemoveAt(i);
            }
            i++;
        }
    }
    // public string? PrintAllContacts()
    // {
    //     return contatti.ToString();
    // }

    public IEnumerator<Contact> GetEnumerator()
    {
        foreach (var contatto in contatti)
        {
            yield return contatto;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}