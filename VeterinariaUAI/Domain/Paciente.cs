using System;
namespace VeterinariaUAI.Domain
{
    public class Paciente
    {
        public Paciente()
        {
        }
        
        public Paciente(string nombre, DateTime fechanac, string tipo, Dueño dueño)
        {
            this.Nombre = nombre;
            this.FechaNacimiento = fechanac;
            this.TipoMascota = tipo;
            this.DueñoMascota = dueño;
        }

        public string Nombre
        {
            get;
            private set;
        }

        public DateTime FechaNacimiento
        {
            get;
            private set;
        }

        public string TipoMascota
        {
            get;
            private set;
        }

        public Dueño DueñoMascota
        {
            get;
            private set;
        }
    }
}
