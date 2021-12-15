using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEntry;
            int secondEntry;
			//Récupération et convertion en entier les saisies utilisateur dans les variables firstEntry et secondEntry.
            Console.WriteLine("Entrez le premier nombre:");
            firstEntry = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Entrez le second nombre:");
            secondEntry = Convert.ToInt32(Console.ReadLine());
			//Modification des variables
            firstEntry += 33;
            secondEntry++;
			//Diviser les variables convertie en flotant pour avoir un résultat plus précis. 
            float result = (float)firstEntry / (float)secondEntry;
            Console.WriteLine($"Le résultat du calcule: ({firstEntry} + 33) / ( {secondEntry}  1) = {result}.");
        }
    }
}
