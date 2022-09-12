using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsultaVeterinariaAPI.Models
{
    public class Medico: Usuario
    {
        [Required]
        [StringLength(15)]
        public string CRM { get; set; }

        [Required]
        [ForeignKey("Especialidade")]
        public int IdEspecialidade { get; set; }
        public Especialidade Especialidade { get; set; }

    }
}
