using System;

namespace EsempiCapitolo14;

public class Collar
{
	private int size;
	public Collar()
	{
	}
	public Collar(int size)
	{
		this.size = size;

	}

	public int Size { get => size; set => size = value; }

    public override string ToString()
    {
        return $"{{{nameof(size)}: {size}}}";
    }
}