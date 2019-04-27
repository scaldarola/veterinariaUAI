using System;
namespace VeterinariaUAI.Domain
{
    public class Veterinario
    {
        public Veterinario()
        {
        }

        public Veterinario(string nombre, string apellido, string dni, string matricula)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Matricula = matricula;
        }

        public string Nombre
        {
            get;
            private set;
        }

        public string Apellido
        {
            get;
            private set;
        }

        public string Dni
        {
            get;
            private set;
        }

        public string Matricula
        {
            get;
            private set;
        }
    }
}