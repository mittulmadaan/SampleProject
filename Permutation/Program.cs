// // <copyright file="Program.cs" company="Nagarro">
// //   Author:Nagarro
namespace Permutation
{
 using System;
 class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine(string.Format(Constants.AskForString));
            input = Console.ReadLine();
            Console.WriteLine(string.Format(Constants.DisplayMessage));

            PermutationLogic permutationlogic = new PermutationLogic();
            permutationlogic.Permutation("",input);

            Console.ReadLine();
        }
            
    }
}