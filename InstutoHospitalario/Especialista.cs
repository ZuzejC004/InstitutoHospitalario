using System;

namespace InstutoHospitalario
{
	public class Especialista : Empleado
	{
		protected String areaEspecializada;
		protected String AreaEspecializada {get{return areaEspecializada;}set{ areaEspecializada = value;}}
		public Especialista(String area, String n, String a, String c, DateTime t) : base(n,a,c,t)
		{
			areaEspecializada = area;
		}
		public void Consulta()
		{
			Console.WriteLine("el Especialista" +nombre+ "en" +areaEspecializada+ "esta realizando consulta");
			
		}
			public override void Cirugia() 
		{
			Console.WriteLine("participando en cirugia");
		}
	}
}
