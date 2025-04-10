using _10_04_2025.Model;
using System.Diagnostics.Contracts;

internal class Program
{
    private static void Main(string[] args)
    {
        //CSV - comma separated values
        //Studente s = new Studente() { Nome = "mario", Cognome = "rossi", Indirizzo = "via dei dadi" };
        //Console.WriteLine(s);

        //leggere il file csv una riga alla volta 
        //processare ogni riga ed estrarre le informazioni per creare un oggetto di tipo Studente
        List<Studente> studenti = [];

        var appDir = AppContext.BaseDirectory;
        string filePath = Path.Combine(appDir, "../../../myCSV.csv");
        try
        {
            using StreamReader reader = new(filePath); //using è come usare try...finally
            string? riga;

            while ((riga = reader.ReadLine()) != null)
            {
                //processing della singola riga
                string[] colonne = riga.Split(',');
                //sappiamo che colonna 0 = ID, 1 = nome, 2 = cognome, 3 = data di nascita, 4 = indirizzo
                Studente s = new Studente() {ID = int.Parse(colonne[0]), Nome = colonne[1], Cognome = colonne[2], DataNascita = DateOnly.Parse(colonne[3]), Indirizzo = colonne[4] };
                Studente a = new Studente(int.Parse(colonne[0]), colonne[1], colonne[2], DateOnly.Parse(colonne[3]), colonne[4]);
                studenti.Add(s);
                studenti.Add(a);
            }
        }

        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine($"il file {filePath} non esiste");
            Console.WriteLine($"{fnfe.Message}");
        }
        catch (IOException ioe)
        {
            Console.WriteLine($"problemi di accesso al file {filePath}");
            Console.WriteLine($"{ioe.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"problemi con il file {filePath}");
            Console.WriteLine($"{e.Message}");
        }

        //stampiamo la lista
        foreach (var studente in studenti)
        {
            Console.WriteLine(studente);
        }
    }
}
//private static List<Studente> NewMethod(string filePath)
//{

//}