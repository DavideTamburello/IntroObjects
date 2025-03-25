internal class Program
{
    public static void Main(string[] args)
    {
        // Creazione di un dizionario dove la chiave è una stringa e il valore è un intero
        //uso il costruttore a 0 parametri ma contemporaneamente utilizzo le properties
        Dictionary<string, int> etaPersone = new()
        {
            // Aggiunta di coppie chiave-valore
            { "Alice", 30 },
            //{"alice", 28 }, stessa key --> va in eccezione, dovrei usare ConstainsKey() o TryAdd()
            { "Bob", 25 },
            { "Charlie", 35 }
        };
        etaPersone["alice"]= 30;
        etaPersone["alice"] = 20; //NON va in eccezione, se non esiste la key la crea altrimenti gli assegna il valore 
        etaPersone["bob"] = 30;


        // Accesso all'età di una persona tramite la chiave
        Console.WriteLine($"L'età di Bob è: {etaPersone["Bob"]}"); // Output: L'età di Bob è: 25

        // Verifica se una chiave esiste
        bool alicePresente = etaPersone.ContainsKey("Alice");
        Console.WriteLine($"Alice è presente? {alicePresente}"); // Output: Alice è presente? True

        // Iterazione sulle coppie chiave-valore
        Console.WriteLine("Età delle persone:");
        foreach (KeyValuePair<string, int> coppia in etaPersone)
        {
            Console.WriteLine($"{coppia.Key}: {coppia.Value}");
        }
        // Output:
        // Alice: 30
        // Bob: 25
        // Charlie: 35
    }
}