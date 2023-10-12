using Proiect;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Materie materie1 = new Materie();
        materie1.Nume = "TIC";
        materie1.Profesor = "Popescu";
        materie1.Notare = "Proiect 100%";
        materie1.Sala = 240;
        Materie materie2 = new Materie("Matematica", "Ionescu", "Examen 100%", 103);
        Materie materie3 = new Materie("Informatica", "Antonescu", "Proiect 40% + Examen 60%", 206);

        Student student1 = new Student("Ionescu", "Matei", 1, "Informatica");
        Student student2 = new Student("Popescu", "George", 3, "Matematica");

        student1.Materii.Add(materie1);
        student1.Materii.Add(materie2);

        student2.Materii.Add(materie3);

        List<Student> listaStudenti = new List<Student>
        {
            student1, student2
        };

        foreach(var student in listaStudenti)
        {
            student.PrintDetalii();
            Console.WriteLine();
        }
    }
}