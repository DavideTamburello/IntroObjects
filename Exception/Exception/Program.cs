internal class Program
{
    private static void Main(string[] args)
    {
        try 
        {
            string fileName = "WrongTextFile1.txt";
            ReadFile(fileName);
        }
        catch(Exception ex) 
        {
            Console.WriteLine($"eccezione catturata nel Main. Message: {ex.Message}");   
        }
        
    }
    static void ReadFile(string fileName)
    {
        TextReader reader = null;
        try
        {
            reader = new StreamReader(fileName);
            //legge la prima riga di testo del file
            string line = reader.ReadLine();
            Console.WriteLine(line);
        }
        
        //aggiungo un altro blocco try catch
        //regola posso mettere più blocchi catch ma con il seguente criterio:
        //1) l'ordine dei catch conta --> devo mettere prima le eccezione più specifiche e poi quelle meno specifiche(rispetto alla gerarchia)
        //2) viene eseguito un solo blocco catch
        //3) l'ordine di esecuzione delle istruzioni è il seguente: 
        //il flusso di esecuzione del codice è tale che viene fatto un salto dall'istruzione che ha generato l'eccezione
        //al blocco catch che ha il tipo di eccezione "più affine" all'eccezione che si è verificata
        //4) di norma il codice nel blocco try che si trova dopo l'istruzione che ha generato l'eccezione non viene eseguito. questo può causare un problema se le istruzioni non eseguite prevedono il rilascio di risorse ottenute dal nostro programma 
        //5) per evitare il problema delle risorse ottenute e non rilasciate per effetto di una eccezione 
        //6) 

        catch(FileNotFoundException fnfe)
        {
            Console.WriteLine("tipo di eccezione: FileNotFoundException - il file non esiste");
            Console.WriteLine($"eccezione: {fnfe.Message}");

            //opzionalmente potrei sollevare una nuova eccezione
            throw new Exception("");
        }
        catch(IOException ioe)
        {
            Console.WriteLine("tipo di eccezione: IOException - il file non esiste");
            Console.WriteLine($"eccezione: {ioe.Message}");
        }
        catch (Exception ex) 
        {
            //gestire l'eccezione
            Console.WriteLine($"eccezione catturata nel metodo ReadFile. il file s");
            Console.WriteLine($"messaggio dell'eccezione: {ex.Message}");
            Console.WriteLine($"StackTrace dell'eccezione: {ex.StackTrace}");

        }
        finally
        {
            Console.WriteLine("blocco finally: questa parte viene sempre eseguita");
            if(reader != null)
            {
                reader.Close();
            }
        }
    }
}