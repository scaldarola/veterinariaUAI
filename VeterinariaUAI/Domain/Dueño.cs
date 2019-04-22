using System;
namespace VeterinariaUAI.Domain
{
    public class Dueño
    {
        public Dueño()
        {
        }
        
        public Dueño(string nombre, string apellido, string dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
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
    }
}
