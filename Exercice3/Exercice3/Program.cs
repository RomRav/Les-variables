using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEntry;
            int secondEntry;
            Console.WriteLine("Entrez le premier nombre:");
            firstEntry = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Entrez le second nombre:");
            secondEntry = Convert.ToInt32(Console.ReadLine());
            firstEntry += 33;
            secondEntry++;
            float result = (float)firstEntry / (float)secondEntry;
            Console.WriteLine($"Le résultat du calcule: ({firstEntry} + 33) / ( {secondEntry}  1) = {result}.");
        }
    }
}
