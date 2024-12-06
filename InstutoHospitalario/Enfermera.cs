using System;

namespace InstutoHospitalario
{
	
	public class Enfermera : Empleado, AtenderAdministrar
	{
		protected int turno;
		protected int Turno {get{return turno;} set{turno = value;}}
		public Enfermera(String n, String a, String c, DateTime t) : base(n,a,c,t)
		{
			
		}
		public Boolean AtenderPaciente(String nombre){
		Console.WriteLine("El paciente " +nombre+ "a sido atendido");
		
		return true;
		}
		public void AdministrarMedicina(String nombre){
			if (AtenderPaciente(nombre)){
				Console.WriteLine("Administrar la Medicina");
			}
		}
		public override void Cirugia() 
		{
			Console.WriteLine("participando en cirugia");
		}
	}
}
