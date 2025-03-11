using Microsoft.EntityFrameworkCore;
using PrjAPILembretes.Entities;

namespace PrjAPILembretes.Context
{
    public class AppLembretesContext : DbContext //herdar vde DbContext para informar que esta classe representará o banco
    {
        public AppLembretesContext(DbContextOptions<AppLembretesContext>options):base(options) { 
        }
        public DbSet<Lembrete> Lembretes { get; set; }//representando uma tabela no bd
    }
}
