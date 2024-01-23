using Microsoft.EntityFrameworkCore;
using Negosud.Class;
using Type = Negosud.Class.Type;

namespace Negosud.Context
{
    public class NegosudContext : DbContext
    {
        public DbSet<Produit> Produits { get; set; }

        public DbSet<Type> Types { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Domaine> Domaines { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Fournisseur> Fournisseurs { get; set; }

        public DbSet<Utilisateur> Users { get; set; }

        public DbSet<Commande> Commandes { get; set; }

        public DbSet<Historique> Historiques { get; set; }


        //Configuration à la base de données MySql
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connexionString = "server=localhost;port=3306;userid=root;password=;database=Negosud;";
            optionsBuilder.UseMySql(connexionString, ServerVersion.AutoDetect(connexionString));
        }
        public NegosudContext() { }
        public NegosudContext(DbContextOptions<NegosudContext> options) : base(options) { }
    }
}
