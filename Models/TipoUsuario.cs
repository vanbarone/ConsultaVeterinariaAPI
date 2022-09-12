using System.ComponentModel.DataAnnotations;

namespace ConsultaVeterinariaAPI.Models
{
    public class TipoUsuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Tipo { get; set; }
    }
}
