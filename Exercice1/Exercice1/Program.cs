using System;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addition de deux variables contenant des entiers et affichage des ces variables dans des chaines de caractére.
            int firstNumber = 5;
            int secondNumber = 45;
            int additionResult = firstNumber + secondNumber;
            Console.WriteLine($"Le premier nombre est: {firstNumber}.");
            Console.WriteLine($"Le deuxième nombre est: {secondNumber}.");
            Console.WriteLine($"L'addition des deux nombres est: {firstNumber} + {secondNumber} = {additionResult}.");
        }
    }
}
