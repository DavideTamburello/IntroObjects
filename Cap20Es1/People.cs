using System;

namespace Cap20Es1;

public class People
{
    private string name;

    public People(string name)
    {
        this.name = name;
    }
    public People():this(string.Empty)
    {
        
    }
    public string Name { get => name; set => name = value; }

    public override string ToString()
    {
        return $"{{{nameof(Name)}:{Name}}}";
    }
}