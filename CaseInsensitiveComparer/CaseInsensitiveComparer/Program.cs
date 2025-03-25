// Implementazione personalizzata di EqualityComparer<string> per confronto case-insensitive
using System.Diagnostics.CodeAnalysis;

public class CaseInsensitiveComparer : EqualityComparer<string>
{
    public override bool Equals(string? x, string? y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (x is null || y is null) return false;
        return x.Equals(y, StringComparison.OrdinalIgnoreCase);
    }

    public override int GetHashCode([DisallowNull] string obj)
    {
        // L'Invariant Culture in .NET è una cultura neutra o culturalmente agnostica che non cambia in base alle impostazioni del sistema operativo o dell'utente.

        // Quando si usa `ToLowerInvariant()` invece di `ToLower()`, si sta garantendo che la trasformazione in minuscolo della stringa avvenga in modo coerente indipendentemente dalle impostazioni locali(locale) del sistema. Questo è cruciale per:

        // 1.Generare hash code consistenti tra diverse macchine e culture
        // 2.Evitare comportamenti imprevisti quando l'applicazione viene eseguita in paesi diversi 
        // 3.Assicurare che il confronto case -insensitive funzioni correttamente in qualsiasi ambiente

        // Senza l'Invariant Culture, alcune lettere potrebbero essere trasformate in modo diverso in base alla cultura locale (ad esempio la lettera "I" in turco ha un comportamento speciale).
        // Nel contesto del metodo `GetHashCode()`, questo assicura che le chiavi del dizionario abbiano hash consistenti indipendentemente dalla cultura del sistema.
        return obj.ToLowerInvariant().GetHashCode();
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        // Creazione di un Dictionary che utilizza il comparatore di uguaglianza case-insensitive
        Dictionary<string, int> conteggi = new Dictionary<string, int>(new CaseInsensitiveComparer());

        // Aggiunta di elementi con chiavi che differiscono solo per la capitalizzazione
        // Uso dell'indexer invece di Add per evitare eccezioni con chiavi duplicate case-insensitive
        conteggi["mela"] = 1;
        conteggi["Mela"] = 2; // Questa assegnazione sovrascriverà la precedente a causa del comparatore case-insensitive
        conteggi["BANANA"] = 3;
        conteggi["banana"] = 4; // Questa assegnazione sovrascriverà la precedente

        Console.WriteLine("Contenuto del Dictionary:");
        foreach (KeyValuePair<string, int> coppia in conteggi)
        {
            Console.WriteLine($"{coppia.Key}: {coppia.Value}");
        }
        // Output (l'ordine potrebbe variare):
        // Mela: 2
        // BANANA: 4

        // Verifica se una chiave esiste (case-insensitive)
        string chiaveDaCercare = "mELA";
        bool chiavePresente = conteggi.ContainsKey(chiaveDaCercare);
        Console.WriteLine($"\nIl Dictionary contiene la chiave '{chiaveDaCercare}'? {chiavePresente}"); // Output: Il Dictionary contiene la chiave 'mELA'? True// Tentativo di recuperare un valore (case-insensitive)
        if (conteggi.TryGetValue(chiaveDaCercare, out int valore))
        {
            Console.WriteLine($"Il valore associato a '{chiaveDaCercare}' è: {valore}"); // Output: Il valore associato a 'mELA' è: 2
        }
        else
        {
            Console.WriteLine($"La chiave '{chiaveDaCercare}' non è presente nel Dictionary");
        }
    }
}