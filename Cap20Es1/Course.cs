using System;

namespace Cap20Es1;

public class Course
{
    private string name;
    private int countOfClasses;
    private int countOfExercises;

    public Course(string name, int countOfClasses, int countOfExercises)
    {
        this.name = name;
        this.countOfClasses = countOfClasses;
        this.countOfExercises = countOfExercises;
    }

    public Course(string name):this(name,0,0)
    {
        
    }
    public Course():this(string.Empty)
    {
        
    }
    public string Name { get => name; set => name = value; }
    public int CountOfClasses { get => countOfClasses; set => countOfClasses = value; }
    public int CountOfExercises { get => countOfExercises; set => countOfExercises = value; }

    public override string ToString()
    {
        return $"{{{nameof(Name)}: {Name}, {nameof(CountOfClasses)}:{CountOfClasses}, {nameof(CountOfExercises)}:{CountOfExercises}}}";
    }
    
}