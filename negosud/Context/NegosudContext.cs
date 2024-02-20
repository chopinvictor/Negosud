using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Negosud.Class;
using Negosud.Dao;
using Type = Negosud.Class.Type;

namespace Negosud.Context
{
    public class NegosudContext(DbContextOptions<NegosudContext> options) : IdentityDbContext<User>(options)
    {
        public DbSet<Produit> Produits { get; set; }

        public DbSet<Type> Types { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Domaine> Domaines { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Fournisseur> Fournisseurs { get; set; }

        public DbSet<Commande> Commandes { get; set; }

        public DbSet<Historique> Historiques { get; set; }


        public class NegosudContextFactory : IDesignTimeDbContextFactory<NegosudContext>
        {
            public NegosudContext CreateDbContext(string[] args)
            {
                var connexionString = "server=localhost;port=3306;userid=root;password=;database=negosud4;";
                var optionsBuilder = new DbContextOptionsBuilder<NegosudContext>();
                optionsBuilder.UseMySql(connexionString, ServerVersion.AutoDetect(connexionString));

                return new NegosudContext(optionsBuilder.Options);
            }
        }
    }
}