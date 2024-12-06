using System;

namespace InstutoHospitalario
{
	
	public interface AtenderAdministrar
	{
		Boolean AtenderPaciente(String nombre);
		void AdministrarMedicina(String nombre);
	}
}
