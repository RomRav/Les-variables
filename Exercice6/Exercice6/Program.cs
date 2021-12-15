using System;

namespace Exercice6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisissez vôtre nom:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Saisissez vôtre prénom:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Saisissez vôtre année de naissance:");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            // int age =  - birthYear;
            int curentYear = DateTime.Now.Year;
            Console.WriteLine($@"Fiches de renseignement:{Environment.NewLine}*Nom: {lastName}{Environment.NewLine}*Prenom: {lastName}{Environment.NewLine}*Age: {curentYear-birthYear} ");
        }
    }
}
