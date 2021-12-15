using System;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
			//Récupération de la saisie utilisateur dans une variables
            Console.WriteLine("Saisissez vôtre nom et prénom:");
            string lastAndFirstName = Console.ReadLine();
			//Affichage des données saisie et de la date du jour formater
            Console.WriteLine($"Bonjour {lastAndFirstName}, nous sommes le {DateTime.Today.ToString("dddd dd MMMM")}, comment allez-vous?");
        }
    }
}
