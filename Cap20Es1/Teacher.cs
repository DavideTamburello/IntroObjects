using System;

namespace Cap20Es1;

public class Teacher:People
{
    private Course[]? courses;

    public Course[]? Courses { get => courses; set => courses = value; }

    public Teacher(string name, Course[]? courses):base(name)
    {
        this.courses = courses;
    }
    public Teacher(string name):this(name,null)
    {
        
    }

    public override string ToString()
    {
        return $"{{{nameof(Name)}:{Name}}}";
    }
    

}