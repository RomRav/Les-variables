using System;

namespace Exercice6
{
    class Program
    {
        static void Main(string[] args)
        {
			//Récupération des saisies utilisateur dans les variables
            Console.WriteLine("Saisissez vôtre nom:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Saisissez vôtre prénom:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Saisissez vôtre année de naissance:");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            int curentYear = DateTime.Now.Year;
			//Affichage dans une chaîne de caractére des variables et calcule grâce à la date du jour de l'age de l'utilisateur.
            Console.WriteLine($@"Fiches de renseignement:{Environment.NewLine}*Nom: {lastName}{Environment.NewLine}*Prenom: {lastName}{Environment.NewLine}*Age: {curentYear-birthYear} ");
        }
    }
}
