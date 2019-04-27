using System;
namespace VeterinariaUAI.Domain
{
    public class Turno
    {
        public Turno()
        {
        }
        
        public Turno(Sala sala, Veterinario vet, Paciente pac, DateTime fechaHora, double seña)
        {
            this.Paciente = pac;
            this.Veterinario = vet;
            this.Sala = sala;
            this.FechaHora = fechaHora;
            this.Seña = seña;
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
