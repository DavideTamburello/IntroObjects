using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string testo = "oggi analizzo del testo per vedere alcune proprietà";
        StringBuilder sbLettere = new();
        StringBuilder sbNumeri = new();
        
        foreach(char c in testo)
        {
            if(char.IsLetter(c))
            {
                sbLettere.Append(c);

            }else if(char.IsDigit(c))
            {
                sbNumeri.Append(c);
            }
            //string di sole lettere
            string soloLettere = sbLettere.ToString();
            Console.WriteLine(soloLettere);
            string soloNumeri = sbNumeri.ToString();
            Console.WriteLine(soloNumeri);
        }
    }
}