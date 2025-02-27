using System;

namespace EsempiCapitolo14.Animals;

public class Dog
{ // Opening bracket of the class body
  // Field declaration
    private string name;
    // Constructor declaration (peremeterless empty constructor)
    public Dog()
    {
    }
    // Another constructor declaration
    public Dog(string name)
    {
        this.name = name;
    }
    // Property declaration
    public string Name
    {
        get { return name; }
        set
        {
            name = value;
        }
    }
    // Method declaration (non-static)
    public void Abbaia()
    {
        Console.WriteLine("{0} ha detto: Wow-wow!",
        name ?? "[cane senza nome]");

    }
} // Closing bracket of the class body