using System;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            int secondNumber = 45;
            int thirdNumber = 65;
            int result = (firstNumber + secondNumber) * thirdNumber;
            Console.WriteLine($"La valeur du premier nombre est {firstNumber}, celle du deuxième est : {secondNumber} et la valeur du dernier nombre est : {thirdNumber}.");
            Console.WriteLine($"Le résultat du calcul : ({firstNumber} + {secondNumber}) x {thirdNumber} = {result}.");
            
        }
    }
}
