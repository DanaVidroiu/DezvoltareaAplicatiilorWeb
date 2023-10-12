using System;
namespace Proiect
{
	public class Student
	{
		public string Nume { get; set; }
		public string Prenume { get; set; }
		public int An { get; set; }
		public string Domeniu { get; set; }
		public List<Materie> Materii { get; set; }

		public Student()
		{
			Materii = new List<Materie>();
		}

		public Student(string nume, string prenume, int an, string domeniu)
		{
			Nume = nume;
			Prenume = prenume;
			An = an;
			Domeniu = domeniu;
			Materii = new List<Materie>();
		}

		public void PrintDetalii()
		{
			Console.WriteLine($"Student: {Nume} {Prenume}");
			Console.WriteLine($"An: {An}");
			Console.WriteLine($"Domeniu: {Domeniu}");
			Console.WriteLine($"Materii: ");

			foreach(var materie in Materii)
			{
				Console.WriteLine($"-{materie.Nume}, {materie.Profesor}, {materie.Notare}, {materie.Sala}");
			}
		}
	}
}

