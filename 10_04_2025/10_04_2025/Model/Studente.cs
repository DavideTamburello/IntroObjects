using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_04_2025.Model
{
    internal class Studente
    {
        public int ID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cognome { get; set; } = string.Empty;
        public string Indirizzo { get; set; } = string.Empty;
        public DateOnly DataNascita { get; set; }

        public Studente(int id, string nome, string cognome, DateOnly dataNascita, string indirizzo)
        {
            ID = id;
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            Indirizzo = indirizzo;
        }
        public Studente()
        {
            
        }

        public override string ToString()
        {
            return $"{nameof(ID)}: {ID}, {nameof(Nome)}: {Nome}, {nameof(Cognome)}: {Cognome}, {nameof(Indirizzo)}: {Indirizzo}, {nameof(DataNascita)}: {DataNascita.ToShortDateString()}";
        }
    }
}
