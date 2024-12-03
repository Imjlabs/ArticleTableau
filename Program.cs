using System;

namespace ArticleTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création du tableau d'articles
            Article[] articles = new Article[3];
            articles[0] = new Article("Article 1", 12.5m, 10, TypeArticle.Alimentaire);
            articles[1] = new Article("Article 2", 8.0m, 20, TypeArticle.Habillement);
            articles[2] = new Article("Article 3", 15.0m, 30, TypeArticle.Loisir);

            // Affichage des articles
            Console.WriteLine("Articles initiaux :");
            foreach (var article in articles)
            {
                article.Afficher();
            }

            // Modification des quantités
            articles[0].Ajouter(5); // Ajouter 5 à l'article 1
            articles[1].Retirer(3);  // Retirer 3 de l'article 2

            // Affichage des articles après modification
            Console.WriteLine("\nArticles après modification :");
            foreach (var article in articles)
            {
                article.Afficher();
            }

            // Saisie d'un nouvel article par l'utilisateur
            Console.WriteLine("\nEntrez un nouvel article :");

            Console.WriteLine("Entrez le nom de l'article:");
            string nom = Console.ReadLine();
            if (string.IsNullOrEmpty(nom))
            {
                nom = "Article Inconnu";
            }

            Console.WriteLine("Entrez le prix de l'article:");
            decimal prix;
            while (!decimal.TryParse(Console.ReadLine(), out prix))
            {
                Console.WriteLine("Prix invalide. Entrez un prix valide:");
            }

            Console.WriteLine("Entrez la quantité:");
            int quantite;
            while (!int.TryParse(Console.ReadLine(), out quantite) || quantite < 0)
            {
                Console.WriteLine("Quantité invalide. Entrez une quantité valide:");
            }

            Console.WriteLine("Entrez le type de l'article (Alimentaire, Droguerie, Habillement, Loisir):");
            string typeInput = Console.ReadLine();
            TypeArticle type = (TypeArticle)Enum.Parse(typeof(TypeArticle), typeInput, true);

            // Création et affichage du nouvel article
            Article articleSaisi = new Article(nom, prix, quantite, type);
            articleSaisi.Afficher();
        }
    }
}
