using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ticket.Shared.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        [Display(Name = "Fecha")]
        public string Name { get; set; } = null!;

        [Display(Name = "Usada")]
        public bool Used { get; set; } = false;

        [Display(Name = "Porteria")]
        public string Zone { get; set; } = null!;
    }
}
