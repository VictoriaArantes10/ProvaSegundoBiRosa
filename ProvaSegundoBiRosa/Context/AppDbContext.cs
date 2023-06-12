using Microsoft.EntityFrameworkCore;
using ProvaSegundoBiRosa.Model;

namespace ProvaSegundoBiRosa.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Produto> Produto { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .Property(p => p.Nome)
                .HasMaxLength(90);

            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Produto>()
                .HasData(

                new Produto { Id = 1, Nome = "Balas", Preco = 9.77M, Descricao = "Para o aniversario", CodBarras = 4578, Quantidade = 10 },
                new Produto { Id = 2, Nome = "Pastel", Preco = 9.85M, Descricao = "Para o aniversario tambem", CodBarras = 7854, Quantidade = 20 }
                );

        }
    }
}
