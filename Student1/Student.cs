using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarie
{
    public class Student
    {
		public string Nume { get; set; }
		public string Oras { get; set; }
		public DateTime DataInscriere { get; set; }
		public string ProgramStudiu { get; set; }

		public Student()
		{ }
		public Student(string nume, string oras, DateTime datainscriere, string programstudiu)
		{
			this.Nume = nume;
			this.Oras = oras;
			this.DataInscriere = datainscriere;
			this.ProgramStudiu = programstudiu;
		}
		public override string ToString()
		{
			return $"{Nume} din {Oras} s-a inscris la data de: {DataInscriere},la programul de studiu : {ProgramStudiu}";
		}
	}
}
