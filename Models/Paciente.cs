using System;
using System.ComponentModel.DataAnnotations;

namespace ConsultaVeterinariaAPI.Models
{
    public class Paciente: Usuario
    {
        [StringLength(30)]
        public string Carteirinha { get; set; }

        [Required]
        public DateTime DtNascimento { get; set; }

        [Required]
        public bool Ativo { get; set; }

        public Paciente()
        {
            Ativo = true;
        }

    }
}
