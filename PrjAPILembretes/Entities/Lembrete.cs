using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PrjAPILembretes.Entities
{
    public class Lembrete
    {
        public int LembreteId { get; set; }
        [MaxLength(50)]
        public string ?TituloLembrete { get; set; }
        [MaxLength(255)]
        public string ?CorpoLembrete { get; set; } 
        public bool StatusLembrete { get; set; }
    }
}
