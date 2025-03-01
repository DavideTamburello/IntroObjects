using System.Dynamic;

internal class Program
{
    private static void Main(string[] args)
    {
        
    }

    interface ISocial
    {
        public void Saluta();
        public void Segue(int numFollower, String social);
        public void Seguito(int numFollower, String social);
    }
    class Persona : ISocial
    {
        public String Nome{ get; set; }
        public String Cognome { get; set; }
        public DateTime DataNascita{ get; set; }
        public int Eta 
        {
            get {return Eta;}
            set { }
        }
        public Persona(String nome, String cognome, DateTime dataNascita)
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
        }
        public Persona(String nome, String cognome)
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
            System.Console.WriteLine($"mi chiamo {persona} e ho {Eta} anni");
        }
        public void Saluta()
        {

        }
        public void Segue(int numFollower, String social)
        {

        }
        public void Seguito(int numFollower, String social)
        {

        }
    }
}