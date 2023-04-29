using System.ComponentModel.DataAnnotations;

namespace Ticket.Shared.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        [Display(Name = "Fecha")]
        public string? Date { get; set; } = null!;

        [Display(Name = "Usada")]
        public bool Used { get; set; } = false;

        [Display(Name = "Porteria")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string? Zone { get; set; } = null!;
    }
}
