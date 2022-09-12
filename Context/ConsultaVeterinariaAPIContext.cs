using ConsultaVeterinariaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsultaVeterinariaAPI.Context
{
    public class ConsultaVeterinariaAPIContext: DbContext
    {
        public ConsultaVeterinariaAPIContext(DbContextOptions<ConsultaVeterinariaAPIContext> options): base(options)
        {
        }

        public DbSet<TipoUsuario> TipoUsuario { get; set; }

        public DbSet<Especialidade> Especialidade { get; set; }

        public DbSet<Usuario> Usuario { get; set; }
        
        public DbSet<Medico> Medico { get; set; }
        
        public DbSet<Paciente> Paciente { get; set; }

        public DbSet<Consulta> Consulta { get; set; }

    }
}
