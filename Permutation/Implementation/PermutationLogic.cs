// // <copyright file="PermutationLogic.cs" company="Nagarro">
// //   Author:Nagarro
namespace Permutation
{
    using System;

    class PermutationLogic
    {
        public void Permutation(string permutedString, string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine(permutedString);
                return;
            }
            else
            {
                for (int index = 0; index < input.Length; index++)
                {

                    string remaining = input.Substring(0, index) + input.Substring(index + 1);
                    Permutation(permutedString + input[index], remaining);
                }
            }
           
        }
    }
}
