using System;

namespace Cap20Es1;

public class Student:People
{
    //il numero di registro nella classe
    private int numeroRegistro;
    //la classe dello studente
    private StudentClass? studentClass;

    public int NumeroRegistro { get => numeroRegistro; set => numeroRegistro = value; }
    public StudentClass? StudentClass { get => studentClass; set => studentClass = value; }

    //costruttori
    public Student(string nomeStudente, int numeroRegistro, StudentClass? classe ):base(nomeStudente)
    {
        this.numeroRegistro = numeroRegistro;
        this.studentClass = classe;

    }

    //costruttore con il solo nomeStudente
    public Student(string nomeStudente):this(nomeStudente,0,null)
    {
        
    }

    public override string ToString()
    {
        return $"{{{nameof(Name)}: {Name}, {nameof(NumeroRegistro)}:{NumeroRegistro}}}";
    }
    
}