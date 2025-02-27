using System;

namespace Cap20Es1;

//è la classe degli studenti
public class StudentClass
{
    private string className;
    private Teacher[]? classTeachers;

    public string ClassName { get => className; set => className = value; }
    public Teacher[]? ClassTeachers { get => classTeachers; set => classTeachers = value; }

    public StudentClass(string className, Teacher[]? classTeachers)
    {
        this.className = className;
        this.classTeachers = classTeachers;
    }

    public StudentClass(string className): this(className, null)
    {
        
    }

    public override string ToString()
    {
        return $"{{{nameof(ClassName)}: {ClassName}}}";
    }
}