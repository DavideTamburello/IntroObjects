using _10_04_2025.Model;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
internal class Program
{
    private static void Main(string[] args)
    {
        //CSV - comma separated values
        //Studente s = new Studente() { Nome = "mario", Cognome = "rossi", Indirizzo = "via dei dadi" };
        //Console.WriteLine(s);
        //processare ogni riga ed estrarre le informazioni per creare un oggetto di tipo Studente

        var appDir = AppContext.BaseDirectory;
        string filePath = Path.Combine(appDir, "../../../myCSV.csv");
        List<Studente> studenti = LoadStudentsFromCSV(filePath);
        //codice per stampare la lista
        foreach(var studente in studenti)
        {
            Console.WriteLine(studente);
        }
        //scrivo la lista di studenti su un altro file
        string filePathDestinazione = Path.Combine(appDir, "../../../outputCSV.csv");
        Console.WriteLine($"scrittura della lista studenti sul file {filePathDestinazione}");
        WriteStudentsToCSV(filePathDestinazione, studenti);

        //test del metodo che processa i dati uno alla volta
        string filePathDestinazione2 = Path.Combine(appDir, "../../../OutputOneByOne.csv");
        Console.WriteLine($"scrittura della lista studenti sul file {filePathDestinazione2} un dato alla volta");
        ProcessFileCSVOneByOne(filePath, filePathDestinazione2);
    }

    private static void ProcessFileCSVOneByOne(string filePathSorgente, string filePathDestinazione, char delimiter = ',')
    {
        //apre in lettura il file dal filePathSorgente 
        //apre in scrittura il filePathDestinazione
        //per ogno riga letta dal file sorgente effettua una elaborazione e poi scrive il risultato nel file destinazione
        using StreamReader reader = new (filePathSorgente);
        using StreamWriter writer = new (filePathDestinazione);
        string? riga;
        while((riga = reader.ReadLine()) != null)
        {
            //con la riga letta creo un oggetto di tipo Studente
            
            string[] colonne = riga.Split(delimiter);
            Studente s = new Studente() { ID = int.Parse(colonne[0]), Nome = colonne[1], Cognome = colonne[2], DataNascita = DateOnly.Parse(colonne[3]), Indirizzo = colonne[4] };
            //simulo le modifiche su Studente
            s.Cognome += "modificata";
            //effettuo le modifiche a Studente

            //poi salvo lo studente modificato sul filePathDestinazione
            string rigaStudente = $"{s.ID}, {s.Nome}, {s.Cognome}, {s.DataNascita.ToShortDateString()}, {s.Indirizzo}";

        }
    }
    private static void WriteStudentsToCSV(string filePath, List<Studente> listaStudenti)
    {
        //inizializzare il writer per scrivere
        //nelle opzioni predefinite di StreamWriter se il file esiste già verrà sovrascritto
        //se il file non esiste verrà creato
        using StreamWriter writer = new(filePath);
        //ciclo sulla lista per aggiungere gli studenti al file CSV
        foreach(var studente in listaStudenti)
        {
            //deve preparare la riga formattata per ciascun studente
            //supponiamo che il separatore sia la virgola
            string rigaStudente = $"{s.ID}, {s.Nome}, {s.Cognome}, {s.DataNascita.ToShortDateString()}, {s.Indirizzo}";
            writer.WriteLine(rigaStudente);
        }
    }
    private static List<Studente> LoadStudentsFromCSV(string filePath, char delimiter = ',')
    {
        //leggere il file csv una riga alla volta 
        
        try
        {
            using StreamReader reader = new(filePath); //using è come usare try...finally
            string? riga;

            while ((riga = reader.ReadLine()) != null)
            {
                //processing della singola riga
                string[] colonne = riga.Split(delimiter);
                //sappiamo che colonna 0 = ID, 1 = nome, 2 = cognome, 3 = data di nascita, 4 = indirizzo
                //Studente s = new Studente() { ID = int.Parse(colonne[0]), Nome = colonne[1], Cognome = colonne[2], DataNascita = DateOnly.Parse(colonne[3]), Indirizzo = colonne[4] };
                Studente s = new Studente(int.Parse(colonne[0]), colonne[1], colonne[2], DateOnly.Parse(colonne[3]), colonne[4]);
                studenti.Add(s);
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
        return studenti;
    }
}
