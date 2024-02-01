using Negosud.Class;
using Negosud.Context;
using Type = Negosud.Class.Type;

namespace NegosudAPI
{
    public static class SeedService
    {
        public static void SeedDatabase()
        {
            using (var context = new NegosudContext())
            {
                if (context.Domaines.Any()) return;

                context.Domaines.Add(new Domaine() { Id = 1, NomDomaine = "Clos Lapeyre", AdresseDomaine = "10 rue des Caves, Pau", CodePostalDomaine = "64110", PaysDomaine = "France" });
                context.Domaines.Add(new Domaine() { Id = 2, NomDomaine = "Saint-Émilion", AdresseDomaine = "12 rue des Vignes, Saint-Émilion", CodePostalDomaine = "33330", PaysDomaine = "France" });
                context.Domaines.Add(new Domaine() { Id = 3, NomDomaine = "Gewurtztraminer", AdresseDomaine = "10 avenue de la Libération, Strasbourg", CodePostalDomaine = "67200", PaysDomaine = "France" });
                context.Domaines.Add(new Domaine() { Id = 4, NomDomaine = "Camyn Larreyda", AdresseDomaine = "26 Chemin du plateau, Jurançon", CodePostalDomaine = "64110", PaysDomaine = "France" });
                context.Domaines.Add(new Domaine() { Id = 5, NomDomaine = "Burgué Seré", AdresseDomaine = "4 Chemin Casadebeig, Jurançon", CodePostalDomaine = "64110", PaysDomaine = "France" });
                context.Domaines.Add(new Domaine() { Id = 6, NomDomaine = "Malarrode", AdresseDomaine = "8 Chemin du bois, Jurançon", CodePostalDomaine = "64110", PaysDomaine = "France" });
                context.Domaines.Add(new Domaine() { Id = 7, NomDomaine = "Beauregard", AdresseDomaine = "50 chemin de la Vigne, Saint-Émilion", CodePostalDomaine = "33330", PaysDomaine = "France" });
                context.Domaines.Add(new Domaine() { Id = 8, NomDomaine = "Bernateau", AdresseDomaine = "12 chemin de la Traversée, Saint-Émilion", CodePostalDomaine = "33330", PaysDomaine = "France" });
                context.Domaines.Add(new Domaine() { Id = 9, NomDomaine = "Bernon Bécot", AdresseDomaine = "6 chemin de l'orée du bois, Saint-Émilion", CodePostalDomaine = "33330", PaysDomaine = "France" });
                context.Domaines.Add(new Domaine() { Id = 10, NomDomaine = "Rioja Haro", AdresseDomaine = "Calle de la Vigna, La Rioja", CodePostalDomaine = "26200", PaysDomaine = "Espagne" });
                context.Domaines.Add(new Domaine() { Id = 11, NomDomaine = "Semblante Carmenere", AdresseDomaine = "12 Camino del roja, Haro", CodePostalDomaine = "15220", PaysDomaine = "Chili" });
                context.Domaines.Add(new Domaine() { Id = 12, NomDomaine = "Cantoalba", AdresseDomaine = "3 Camino de la Camisetta, Burgos", CodePostalDomaine = "14317", PaysDomaine = "Chili" });
                context.Domaines.Add(new Domaine() { Id = 13, NomDomaine = "Romanée-Conti", AdresseDomaine = "12 rue des viticulteurs, Vosne-Romanée", CodePostalDomaine = "21700", PaysDomaine = "France" });
                context.Domaines.Add(new Domaine() { Id = 14, NomDomaine = "Château Margaux", AdresseDomaine = "1 rue du château, Margaux", CodePostalDomaine = "33460", PaysDomaine = "France" });
                context.Domaines.Add(new Domaine() { Id = 15, NomDomaine = "Château de Meursault", AdresseDomaine = "81 rue du château, Mersault", CodePostalDomaine = "33460", PaysDomaine = "France" });
                context.Domaines.Add(new Domaine() { Id = 16, NomDomaine = "Francis Ford Coppola", AdresseDomaine = "6 Old River Ld, Santa Rosa", CodePostalDomaine = "98045", PaysDomaine = "Etats -Unis" });
                context.Domaines.Add(new Domaine() { Id = 17, NomDomaine = "Kendall-JAckson", AdresseDomaine = "5007 Fulton Rd Sierra Roja", CodePostalDomaine = "95403", PaysDomaine = "Etats -Unis" });
                context.Domaines.Add(new Domaine() { Id = 18, NomDomaine = "Zinfendel", AdresseDomaine = "4012 Creek Ld, Santa Rosa", CodePostalDomaine = "98045", PaysDomaine = "Etats -Unis" });

                context.Types.Add(new Type() { Id = 1, NomType = "Blanc" });
                context.Types.Add(new Type() { Id = 2, NomType = "Rouge" });
                context.Types.Add(new Type() { Id = 3, NomType = "Rosé" });
                context.Types.Add(new Type() { Id = 4, NomType = "Pétillant" });
                context.Types.Add(new Type() { Id = 5, NomType = "Digestif" });

                context.Clients.Add(new Client() { Id = 1, NomClient = "Zidane", PrenomClient = "Zinedine", AdresseClient = "10 rue du cesi", VilleClient = "Pau", CodePostalClient = "64000", PaysClient = "France", EmailClient = "ZineZidane@gmail.com", TelephoneClient = "0559532533" });
                context.Clients.Add(new Client() { Id = 2, NomClient = "Martin", PrenomClient = "Camille", AdresseClient = "123 Rue de la Liberté", VilleClient = "Paris", CodePostalClient = "75001", PaysClient = "France", EmailClient = "camille.martin@email.com", TelephoneClient = "0159202253" });
                context.Clients.Add(new Client() { Id = 3, NomClient = "Dubois", PrenomClient = "Julien", AdresseClient = "456 Avenue des Roses", VilleClient = "Lyon", CodePostalClient = "69002", PaysClient = "France", EmailClient = "julien.dubois@email.com", TelephoneClient = "0920462577" });
                context.Clients.Add(new Client() { Id = 4, NomClient = "Leroy", PrenomClient = "Elise", AdresseClient = "789 Boulevard du Soleil", VilleClient = "Marseille", CodePostalClient = "13006", PaysClient = "France", EmailClient = "elise.leroy@email.com", TelephoneClient = "0433669901" });
                context.Clients.Add(new Client() { Id = 5, NomClient = "Dupont", PrenomClient = "Pierre", AdresseClient = "1010 Rue de l'Avenir", VilleClient = "Bordeaux", CodePostalClient = "33000", PaysClient = "France", EmailClient = "pierre.dupont@email.com", TelephoneClient = "0559173065" });
                context.Clients.Add(new Client() { Id = 6, NomClient = "Moreau", PrenomClient = "Emma", AdresseClient = "2020 Avenue des Étoiles", VilleClient = "Lille", CodePostalClient = "59000", PaysClient = "France", EmailClient = "emma.moreau@email.com", TelephoneClient = "0130205579" });
                context.Clients.Add(new Client() { Id = 7, NomClient = "Lambert", PrenomClient = "Nicolas", AdresseClient = "303 Rue de la Paix", VilleClient = "Paris", CodePostalClient = "75008", PaysClient = "France", EmailClient = "nicolas.lambert@email.com", TelephoneClient = "0430884017" });
                context.Clients.Add(new Client() { Id = 8, NomClient = "Bernard", PrenomClient = "Anna", AdresseClient = "404 Boulevard des Champs", VilleClient = "Lyon", CodePostalClient = "69003", PaysClient = "France", EmailClient = "laura.bernard@email.com", TelephoneClient = "0930602522" });
                context.Clients.Add(new Client() { Id = 9, NomClient = "Rodrigues", PrenomClient = "Alejandro", AdresseClient = "10 rue de Porto", VilleClient = "Lisbonne", CodePostalClient = "1100", PaysClient = "Portugal", EmailClient = "rodriguez@gmail.com", TelephoneClient = "0030330548" });
                context.Clients.Add(new Client() { Id = 10, NomClient = "Zhang", PrenomClient = "Wei", AdresseClient = "Zhonghuang Building #1007", VilleClient = "Shanghai", CodePostalClient = "200030", PaysClient = "Chine", EmailClient = "zhangwei@gmail.com", TelephoneClient = "860623034" });

                context.Fournisseurs.Add(new Fournisseur() { Id = 1, NomFournisseur = "Les Grappes", AdresseFournisseur = "ZI Mirador, Bordeaux", CodePostalFournisseur = "33000", PaysFournisseur = "France", TelephoneFournisseur = "0559335741", EmailFournisseur = "lagrappe@commerial-contact.fr" });
                context.Fournisseurs.Add(new Fournisseur() { Id = 2, NomFournisseur = "Agidra", AdresseFournisseur = "12 chemin de la cale, Bordeaux", CodePostalFournisseur = "33000", PaysFournisseur = "France", TelephoneFournisseur = "0559262181", EmailFournisseur = "agidra@contact.fr" });
                context.Fournisseurs.Add(new Fournisseur() { Id = 3, NomFournisseur = "Le Bon Vin", AdresseFournisseur = "32 rue du Bourg, Bordeaux", CodePostalFournisseur = "33000", PaysFournisseur = "France", TelephoneFournisseur = "0559124087", EmailFournisseur = "lebonvin@contact.fr" });

                var produit1 = new Produit() { Id = 1, NomProduit = "Les Grappes", NbProduit = 10, PrixProduit = 10.5f, TypeID = 1, DomaineID = 1 };
                var produit2 = new Produit() { Id = 2, NomProduit = "L'Uby", NbProduit = 15, PrixProduit = 12.3f, TypeID = 2, DomaineID = 8 };
                context.Produits.Add(produit1);
                context.Produits.Add(produit2);
                context.Produits.Add(new Produit() { Id = 3, NomProduit = "Bernadets", NbProduit = 13, PrixProduit = 9.3f, TypeID = 3, DomaineID = 4 });
                context.Produits.Add(new Produit() { Id = 4, NomProduit = "Gev Vendandes tardives", NbProduit = 31, PrixProduit = 15.7f, TypeID = 4, DomaineID = 3 });
                context.Produits.Add(new Produit() { Id = 5, NomProduit = "Old Wine", NbProduit = 30, PrixProduit = 10.9f, TypeID = 3, DomaineID = 1 });
                context.Produits.Add(new Produit() { Id = 6, NomProduit = "Caberney", NbProduit = 15, PrixProduit = 12.1f, TypeID = 4, DomaineID = 2 });
                context.Produits.Add(new Produit() { Id = 7, NomProduit = "Valto", NbProduit = 13, PrixProduit = 9.3f, TypeID = 2, DomaineID = 7 });
                context.Produits.Add(new Produit() { Id = 8, NomProduit = "Werner", NbProduit = 31, PrixProduit = 15.7f, TypeID = 1, DomaineID = 11 });

                context.Commandes.Add(new Commande() { Id = 1, DateCommande = DateTime.Now, FournisseurId = 1, EstEntreeSortie = true,
                    ListProduits = new List<Produit> { produit1, produit2 },
                    PrixTotal = (produit1.PrixProduit * 6) + (produit2.PrixProduit * 12),
                });

                context.Transactions.Add(new Transaction() { Id = 1, ProduitId = produit1.Id, NbProduit = 6, Description = "Achat", CommandeId = 1});
                context.Transactions.Add(new Transaction() { Id = 2, ProduitId = produit2.Id, NbProduit = 12, Description = "Achat", CommandeId = 1 });

                context.SaveChanges();
            }
        }
    }
}
