using System;
namespace Proiect
{
	public class Materie
	{
		public string Nume { get; set; }
		public string Profesor { get; set; }
		public string Notare { get; set; }
		public int Sala { get; set; }

		public Materie()
		{
		}

		public Materie(string nume, string profesor, string notare, int sala)
		{
			Nume = nume;
			Profesor = profesor;
			Notare = notare;
			Sala = sala;
		}
	}
}

