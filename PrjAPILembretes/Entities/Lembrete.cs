namespace PrjAPILembretes.Entities
{
    public class Lembrete
    {
        public int LembreteId { get; set; }
        public string ?TituloLembrete { get; set; }
        public string ?CorpoLembrete { get; set; } 
        public bool StatusLembrete { get; set; }
    }
}
