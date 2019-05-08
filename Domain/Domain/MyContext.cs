using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace VeterinariaUAI.Domain
{
    public class MyContext : DbContext
    {
        public virtual DbSet<Turno> Turnos { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<Dueño> Dueños { get; set; }
        public virtual DbSet<Sala> Salas { get; set; }
        public virtual DbSet<Veterinario> Veterinarios { get; set; }
    }
}
