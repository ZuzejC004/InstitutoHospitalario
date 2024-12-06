using System;

namespace InstutoHospitalario
{
	
	public class Paramedico : Empleado, AtenderAdministrar
	{
		protected int nivelEmergencia;
		protected int NivelEmergencia {get{return nivelEmergencia ;}set{ nivelEmergencia = value;}}
		
		public Paramedico( int nivel,String n, String a, String c, DateTime t) : base(n,a,c,t)
		{
			nivelEmergencia = nivel;
		}
		
		public void AtenderEmergencia()
		{
			switch(nivelEmergencia)
			{
			   case 1: 
					Console.WriteLine("Se ha iniciando atencion basica.");
				break;
			   case 2:
				Console.WriteLine("Se ha activado el protocolo de emergencia Medio.");
			    break;
			   case 3:
			    Console.WriteLine("SE HA ACTIVADO LA ALARMA MAXIMA.");
			    break;
			   default:
			    Console.WriteLine("Nivel de emergencia no valido.");
			    break;
			}
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
	}
}
