using System;
namespace VeterinariaUAI.Domain
{
    public class Sala
    {
        public Sala()
        {
        }
        
        public Sala(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre
        {
            get;
            private set;
        }
    }
}
