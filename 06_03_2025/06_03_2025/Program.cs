using _06_03_2025;

internal class Program
{
    private static void Main(string[] args)
    {
        //coma facciamo a ordinare gli oggetti di tipo temperatura?
        //creiamo un array di oggetti di tipo temperatura

        const int NumeroDiTemperature = 10;
        Random gen = new Random();
        Temperatura[] temperature = new Temperatura[NumeroDiTemperature];

        for(int i = 0; i <temperature.Length; i++)
        {
            temperature[i] = new Temperatura(gen.Next(-10, 41));
        }
        //stampiamo le temperature
        PrintTemperature(temperature);
        Array.Sort(temperature); //--> per funzionare richiede che gli oggetti nell'array implementino IComparable
        Console.WriteLine("stampa delle temperature ordinate");
        PrintTemperature(temperature);

        //confronti con oggetti di tipo Temperatura
        if (temperature[4] > temperature[3])
        {

        }
    }

    private static void PrintTemperature(Temperatura[] temperature)
    {
        foreach(var tempreratura in temperature)
        {
            Console.WriteLine($"temperatura = {temperature.Celsius:F2} °C, corrispondente a {temperature.Fahreneit:F2} °F");
        }
    }
}