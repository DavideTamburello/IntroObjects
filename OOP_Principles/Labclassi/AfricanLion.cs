using System;

namespace OOPPrinciples.LabClassi;

public class AfricanLion:Lion
{
	// …
	// If we comment out the ": base(male, weight)" line
	// the class will not compile. Try it.
	public AfricanLion(bool male, int weight)
	: base(male, weight)
	{ }
	public override string ToString()
	{
		return string.Format(
		"(AfricanLion, male: {0}, weight: {1})",
		this.Male, this.Weight);
	}

    public override void MiPresento()
    {
       Console.WriteLine($"sono un {nameof(AfricanLion)} e sono più gentile del mio antenato");
    }
	public new void Ruggisci()
	{
		Console.WriteLine($"Sono un {nameof(AfricanLion)} e ruggisco così: Roarrrr Roarrrr!!!");
	}

}