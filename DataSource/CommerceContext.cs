using EsercizioWebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace EsercizioWebAPI.DataSource
{
    public class CommerceContext : DbContext
    {
        public CommerceContext() { }
        public CommerceContext(DbContextOptions<CommerceContext> options) : base(options) { }

        public DbSet<Utente> Utenti { get; set; }
        public DbSet<Prodotto> Prodotti { get; set; }

        public DbSet<Carrello> Carrelli { get; set; }
        
    }
}
