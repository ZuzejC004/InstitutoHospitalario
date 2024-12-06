using System;

namespace InstutoHospitalario
{

	public abstract class Empleado
	{ 
		protected String nombre;
		protected String apellido;
		protected String cedula;
		protected DateTime registrar;
		
		protected  String Nombre {get{return nombre;} set{nombre = value;}}
		protected  String Apellido {get{return apellido;} set{apellido = value;}}
		protected  String Cedula {get{return cedula;} set{cedula = value;}}
		protected  DateTime Registrar {get{return registrar;} set{registrar = value;}}
		
		public Empleado(String n, String a, String c, DateTime t)
		{
			nombre = n;
			apellido = a;
			cedula = c;
			registrar = t;
		}
		public void HoraLlegada()
		{
			Console.WriteLine("Registra la llegada:" +registrar);
		}
		public void HoraSalida ()
		{
			Console.WriteLine("Registra la hora de salida:" +registrar);
		}
		public virtual void Cirugia() 
		{
			Console.WriteLine("participando en cirugia");
		}
	}
}
