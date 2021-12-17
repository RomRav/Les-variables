using System;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
			//Affichage dans une chaine de caractére de trois variables.
            string title = "Monsieur";
            string firstName = "Vincent";
            int hasCome = 1;
            Console.WriteLine($"Bonjour {title} {firstName}, vous êtes venu nous rendre visite {hasCome} fois.");
        }
    }
}
