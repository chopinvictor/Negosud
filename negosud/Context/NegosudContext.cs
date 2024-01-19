using Microsoft.EntityFrameworkCore;
using Negosud.Class;
using System.Collections.Generic;
using Type = Negosud.Class.Type;

namespace Negosud.Context
{
    public class NegosudContext: DbContext
    {
        public DbSet<Produit> Produits { get; set;}

        public DbSet<Type> Types { get; set;}

        public DbSet<Client> Clients { get; set; }

        public DbSet<Domaine> Domaines { get; set; }

        public DbSet<Transaction> Transaction { get; set; }

        public DbSet<Fournisseur> Fournisseurs { get; set; }

        public DbSet<User> Users { get; set; }


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
