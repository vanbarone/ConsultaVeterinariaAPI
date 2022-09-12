using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsultaVeterinariaAPI.Models
{
    public abstract class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(180)]
        public string Nome { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(10)]
        public string Senha { get; set; }

        [Required]
        [ForeignKey("TipoUsuario")]
        public int IdTipoUsuario { get; set; }
        public TipoUsuario TipoUsuario { get; set; }

    }
}
