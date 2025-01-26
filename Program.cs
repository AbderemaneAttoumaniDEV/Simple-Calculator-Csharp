using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{Environment.NewLine}Bienvenue dans la calculatrice simple !");
        
        Console.WriteLine($"{Environment.NewLine}Entrez le premier nombre : ");
        double nombre1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"{Environment.NewLine}Entrez l'opérateur (+, -, *, /) : ");
        string operateur = Console.ReadLine();

        double nombre2 = 0;
        bool valide = false;

        // Boucle pour valider le second nombre (pour la division par 0 surtout)
        while (!valide)
        {
            Console.WriteLine($"{Environment.NewLine}Entrez le second nombre : ");
            nombre2 = Convert.ToDouble(Console.ReadLine());

            if (operateur == "/" && nombre2 == 0)
            {
                Console.WriteLine($"{Environment.NewLine}Erreur : Division par zéro ! Veuillez entrer un autre nombre.");
            }
            else
            {
                valide = true; // Le second nombre est valide
            }
        }

        double resultat = 0;

        // Calcul en fonction de l'opérateur
        switch (operateur)
        {
            case "+":
                resultat = nombre1 + nombre2;
                break;
            case "-":
                resultat = nombre1 - nombre2;
                break;
            case "*":
                resultat = nombre1 * nombre2;
                break;
            case "/":
                resultat = nombre1 / nombre2;
                break;
            default:
                Console.WriteLine($"{Environment.NewLine}Opérateur invalide !");
                return;
        }

        Console.WriteLine($"{Environment.NewLine}Résultat : {resultat}");
    }
}
