using Microsoft.EntityFrameworkCore;

namespace GestionBancaireApi.Models
{
    public class AppDbContext:DbContext
    {
       
        public DbSet<Compte> Comptes { get; set; }
        public DbSet<Mouvement> Mouvements { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=gestion_bancaire;uid=root;pwd=;");
        }

    }
}
