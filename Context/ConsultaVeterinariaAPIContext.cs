using ConsultaVeterinariaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsultaVeterinariaAPI.Context
{
    public class ConsultaVeterinariaAPIContext: DbContext
    {
        public ConsultaVeterinariaAPIContext(DbContextOptions<ConsultaVeterinariaAPIContext> options): base(options)
        {
            //Recria o BD toda vez que executar a aplicação
            //Database.SetInitializer(new DropCreateDatabaseAlways<DataContext>());
        }

        public DbSet<TipoUsuario> TipoUsuario { get; set; }

        public DbSet<Especialidade> Especialidade { get; set; }

        public DbSet<Usuario> Usuario { get; set; }
        
        public DbSet<Medico> Medico { get; set; }

        public DbSet<Paciente> Paciente { get; set; }

        public DbSet<Consulta> Consulta { get; set; }

        //protected override void OnModelCreating(System.Data.En  DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
         
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConve‌​ntion>();
        //}


    }
}
