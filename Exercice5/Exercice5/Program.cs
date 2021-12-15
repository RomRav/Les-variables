using System;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisissez vôtre nom et prénom:");
            string lastAndFirstName = Console.ReadLine();
            Console.WriteLine($"Bonjour {lastAndFirstName}, nous sommes le {DateTime.Today.ToString("dddd dd MMMM")}, comment allez-vous?");
        }
    }
}
