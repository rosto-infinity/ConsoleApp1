using System;

public class Boite<T>
{
    private T contenu; // Champ privé pour stocker le contenu de type générique T

    // Méthode pour ajouter un élément de type T à la boite
    public void Ajouter(T item)
    {
        contenu = item;
    }

    // Méthode pour obtenir l'élément de type T de la boite
    public T Obtenir()
    {
        return contenu;
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Utilisation de la classe générique Boite avec un entier
        Boite<int> boiteInt = new Boite<int>();
        boiteInt.Ajouter(5);
        Console.WriteLine(boiteInt.Obtenir()); // Affiche 5

        // Utilisation de la classe générique Boite avec une chaîne de caractères
        Boite<string> boiteString = new Boite<string>();
        boiteString.Ajouter("Bonjour");
        Console.WriteLine(boiteString.Obtenir()); // Affiche "Bonjour"
    }
}
