//ReadFromFileDemo

internal class Program
{
    private static void Main(string[] args)
    {
        //lettura da un file di testo

        //string filePath = "C:\\Users\\DAVIDETAMBURELLO3IA_\\source\\repos\\09_04_2025\\09_04_2025\\aaaaaaaa.txt";
        //--> percorso assoluto, cattiva pratica
        
        //AppContext.BaseDirectory restituisce il percorso dove si trova l'eseguibile
        var appDir = AppContext.BaseDirectory;
        //calcoliamo un percorso relativo rispetto a appDir
        //Path.Combine("/myDir/"); --> cattiva pratica
        string filePath = Path.Combine(appDir, "../../../aaaaaaaa.txt");
        //Console.WriteLine(filePath);

        //lettura da file
        //StreamReader reader = new StreamReader(filePath);
        //un file va letto in maniera sequenziale, riga per riga
        //il metodo ReadLine restituisce la prossima riga letta, se la riga esiste, restituisce null se la prossima riga
        //non esiste, ovvero siamo arrivati alla fine del file

        //per leggere tutte le righe di un file di testo si esegue un 
        //string riga = reader.ReadLine();
        ////stampa della prima riga
        //Console.WriteLine(riga);

        

        try
        {
            using StreamReader reader = new StreamReader(filePath);
            //ciclo di lettura di tutto il file di testo
            string? riga;
            while ((riga = reader.ReadLine()) != null)
            {
                //processiamo la riga letta
                Console.WriteLine(riga);
            }
        }
        catch(FileNotFoundException fnfe) 
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
        //non serve mettere finally

        //qui viene invocato reader.Dispose
    }
}