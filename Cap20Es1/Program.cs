﻿using Cap20Es1;

internal class Program
{

    //We are given a school.The school has classes of students.Each class has a set of teachers.Each teacher teaches a set of courses. The students have a name and unique number in the class. Classes have a unique text identifier.Teachers have names. Courses have a name, count of classes and count of exercises.The teachers as well as the students are people. Your task is to model the classes (in terms of OOP) along with their attributes and operations define the class hierarchy and create a class diagram with Visual Studio.
    private static void Main(string[] args)
    {
        //creiamo la scuola Greppi
        //creo prima gli oggetti che non dipendono da altri oggetti
        Course course1 = new Course("Informatica terze", 2, 100);
        Course course2 = new Course("Informatica quarte", 2, 100);
        Course course3 = new Course("Informatica quinte", 2, 100);
        Course course4 = new Course("TLC terze", 2, 100);
        Course course5 = new Course("TLC quarte", 2, 100);


        //corsi di Malafronte
        Course[] corsiMalafronte = [course1,course2];
        Teacher teacher1 = new Teacher("Malafronte", corsiMalafronte);
        //corsi di Villa
        Course[] corsiVilla = [course4, course5];
        Teacher teacher2 = new Teacher("Villa", corsiVilla);
        //creo qualche classe
        Teacher[] docenti3IA = [teacher1,teacher2];
        StudentClass classe3IA = new StudentClass("3IA", docenti3IA);

        //creiamo gli studenti
        //possibili modi di creare uno studente
        Student studentMario = new Student("Mario Rossi",1,classe3IA);
        Student studentGiovanni = new Student("Giovanni Verdi",2,classe3IA);
        Student studentAlberto = new Student("Alberto Bianchi",3,classe3IA);
        Student studentSara = new Student("Sara Rossetti",4,classe3IA);
        Student studentMaria = new Student("Maria Villa", 5, classe3IA);

        //stampiamo i docenti della classe 3IA
        if(classe3IA.ClassTeachers is not null)
        {
            foreach (var teacher in classe3IA.ClassTeachers)
            {
                Console.WriteLine(teacher);
            }

        }

        //altro modo di gestire il nullable
        Console.WriteLine("altro modo di gestire il nullable");
        //?: --> boolean_expression? alternative1:alternative2
        // if boolean_expression is true return alternative1 else return alternative2
        //?? --> expression ?? alternative
        //if expression is not null return expression else return alternative
        foreach (var teacher in classe3IA.ClassTeachers?? [])
        {
            Console.WriteLine(teacher);
        }



    }
}