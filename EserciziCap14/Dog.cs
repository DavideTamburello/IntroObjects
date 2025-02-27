
namespace EsempiCapitolo14;

// Class declaration
public class Dog
{ // Opening bracket of the class body
  // Field declaration
	private string name;
	private int age;
	private double length;
	private Collar collar;
	private static int dogCounter;
	
	//costruttore con tutti i parametri
	public Dog(string name, int age, double length, Collar collar)
	{
		this.name = name;
		this.age = age;
		this.length = length;
		this.collar = collar;
		dogCounter++;
	}
	
	//costruttore con 3 parametri
	public Dog(string name, int age, double length):this(name,age,length,new Collar())
	{
		
	}
	
	public Dog(string name, int age):this(name,age,0.5)
	{
		
	}
	public Dog(string name):this(name,3)
	{
		
	}
		public Dog():this("Sharo")
	{
		
	}

	// // Constructor declaration (peremeterless empty constructor)
	// public Dog()
	// {
	// 	this.name = "Sharo";
	// 	this.age = 3;
	// 	this.length = 0.5;
	// 	this.collar = new Collar();
	// 	dogCounter++;
	// }
	// // Another constructor declaration
	// public Dog(string name)
	// {
	// 	this.name = name;
	// 	this.age = 3;
	// 	this.length = 0.5;
	// 	this.collar = new Collar();
	// 	dogCounter++;
	// }
	//  public Dog(string name, int age)
	//  {
	// 	this.name = name;
	// 	this.age = age;
	// 	this.length = 0.5;
	// 	this.collar = new Collar();
	// 	dogCounter++;
	//  }
	
	// Property declaration
	public string Name
	{
		get { return name; }
		set { 
			name = value; 
			}
	}
	//property associata al campo (field) collar che utilizza l'operatore lambda =>
	//l'operatore => semplifica alcune parti della sintassi C#
	// get => collar; equivale get{ return collar;}
	// set => collar = value; equivale set{ collar = value;}
	//public Collar Collar { get => collar; set => collar = value; }
	public Collar Collar
	{
		get
		{
			return collar;
		}
		set
		{
			collar = value;
		}
	}

	
	public int Age { get => age; set => age = value; }
	public double Length { get => length; set => length = value; }

	// Method declaration (non-static)

	//da un metodo di istanza (non statico) posso accedere sia ai campi statici 
	// che a quelli non statici
	public void Bark()
	{
		//Console.WriteLine("{0} con età {1} said: Wow-wow! ",name ?? "[unnamed dog]",age);
		Console.WriteLine($"{name ?? "[unnamed dog]"} con età {age} said: Wow-wow! ");
		//da un metodo di istanza (non statico) posso accedere ad un campo statico
		Console.WriteLine($"Sono stati creati {dogCounter} cani");

	}
	
	//un esempio di metodo statico
	public static void GetDogInfo()
	{
		

	}

    public override string ToString()
    {
        return $"{{{nameof(Name)}:{Name},{nameof(Age)}:{Age}, {nameof(Length)}:{Length}, {nameof(Collar)}:{Collar}}}";
    }

} // Closing bracket of the class body