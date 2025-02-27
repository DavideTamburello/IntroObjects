using System;

namespace EsempiCapitolo14;

public class Cat
{
	private string name;
	private int age;
	private double length;

	public Cat(string name, int age, double length)
	{
		this.name = name;
		this.age = age;
		this.length = length;
	}
	
	public Cat(string name, int age):this(name,age, 20)
	{
		
	}
	public Cat(string name) : this(name, 1)
	{

	}
	public Cat() : this("gattino")
	{

	}

	public string Name { get => name; set => name = value; }
	public int Age { get => age; set => age = value; }
	public double Length { get => length; set => length = value; }

    public override string ToString()
    {
        return $"[{name}, {age}, {length}]";
    }
}