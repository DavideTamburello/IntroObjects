
namespace IntroObjects;

public class Cat
{
	//i campi statici sono "unici" per classe --> tutte le istanze 
	//condividono lo stesso valore del campo statico
	private static int catCounter=0;
	// Field name
	private string name;
	// Field color
	private string color;
	
	//property in sola lettura
	public static int CatCounter 
	{ 
		get
		{
			return catCounter;

		}
	
	}
	public string Name
	{
		// Getter of the property "Name"
		get
		{
			return this.name;
		}
		// Setter of the property "Name"
		set
		{
			this.name = value;
		}
	}
	public string Color
	{
		// Getter of the property "Color"
		get
		{
			return this.color;
		}
		// Setter of the property "Color"
		set
		{
			this.color = value;
		}
	}
	//Default constructor
	public Cat()
	{
		this.name = "Unnamed";
		this.color = "gray";
		catCounter++;
	}
	// Constructor with parameters
	public Cat(string name, string color)
	{
		this.name = name;
		this.color = color;
		catCounter++;
	}
	// Method SayMiau
	public void SayMiau()
	{
		Console.WriteLine("Cat {0} said: Miauuuuuu!", name);
	}
}