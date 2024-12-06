using System;

namespace InstutoHospitalario
{	
	public class Medico : Empleado, AtenderAdministrar
	{
		protected int anosExperiencia;
		protected int AnosExperiencia {get{return anosExperiencia ;}set{ anosExperiencia = value;}}
		
		public Medico(int e, String n, String a, String c, DateTime t) : base (n,a,c,t)
		{
			anosExperiencia = e;
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
		public void PrescribirMedicamtos()
		{
			Console.WriteLine("El Medico" +nombre+"a prescrito las medicinas las paciente"+nombre);
	     }
	}
}
