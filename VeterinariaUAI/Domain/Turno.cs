using System;
namespace VeterinariaUAI.Domain
{
    public class Turno
    {
        public Turno()
        {
        }

        public Sala Sala
        {
            get;
            private set;
        }

        public Veterinario Veterinario
        {
            get;
            private set;
        }

        public Paciente Paciente
        {
            get;
            private set;
        }

        public DateTime FechaHora
        {
            get;
            private set;
        }

        public double Seña
        {
            get;
            private set;
        }
    }
}
