using System.ComponentModel.DataAnnotations;

namespace ApiFeira.Models
{
    public class Visita
    {
        [Required]
        public string RA { get; set; } = string.Empty;

        public DateTime DataVisita { get; set; } = DateTime.Now;

        [Required]
        [Range(10, 99)]
        public int NumeroProjeto { get; set; }

        [Range(0, 5)]
        public double Nota { get; set; }
    }
}