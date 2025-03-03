using System.Dynamic;

internal class Program
{
    private static void Main(string[] args)
    {

    }

    public interface ISocial
    {
        void Saluta();
        void Segue(int numFollower, string social);
        void Seguito(int numFollower, string social);
    }
    class Persona : ISocial
    {
        //fields
        string Nome { get; set; }
        string Cognome { get; set; }
        DateTime DataNascita { get; set; }
        public int Eta
        {
            get 
            {
                DateTime today = DateTime.Today;
                int eta =  today.Year - DataNascita.Year;
                if(DataNascita.Date > today.AddYears(-eta))
                {
                    eta--;
                }
                return eta;
            }
        }
        public Persona(string nome, string cognome, DateTime dataNascita)
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
        }
        public Persona(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = DateTime.Now;
        }

        public void ToString(Persona persona)
        {
            System.Console.WriteLine(persona);
        }
        public void MiPresento(Persona persona)
        {
            System.Console.WriteLine($"mi chiamo {Nome} {Cognome} e ho {Eta} anni");
        }
        public void Saluta()
        {

        }
        public void Segue(int numFollower, string social)
        {

        }
        public void Seguito(int numFollower, string social)
        {

        }
    }
}