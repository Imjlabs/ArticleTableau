using System;

namespace ArticleTableau
{
    // Enumération pour les types d'articles
    public enum TypeArticle
    {
        Alimentaire,
        Droguerie,
        Habillement,
        Loisir
    }

    // Structure pour l'article
    public struct Article
    {
        public string Nom;
        public decimal Prix;
        public int Quantite;
        public TypeArticle Type;

        // Constructeur de l'article
        public Article(string nom, decimal prix, int quantite, TypeArticle type)
        {
            Nom = nom;
            Prix = prix;
            Quantite = quantite;
            Type = type;
        }

        // Méthode pour afficher les informations de l'article
        public void Afficher()
        {
            Console.WriteLine($"Nom: {Nom}, Prix: {Prix:C}, Quantité: {Quantite}, Type: {Type}");
        }

        // Méthode pour ajouter une quantité
        public void Ajouter(int quantite)
        {
            if (quantite > 0)
            {
                Quantite += quantite;
            }
        }

        // Méthode pour retirer une quantité
        public void Retirer(int quantite)
        {
            if (quantite > 0 && Quantite >= quantite)
            {
                Quantite -= quantite;
            }
        }
    }
}
