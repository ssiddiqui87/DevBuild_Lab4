using System;
using System.Collections.Generic;

namespace Piglatin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get input from user
            
            Console.Write("Enter a word: ");
            string input = Console.ReadLine().ToLower();
            string vowel = "aeiou";

            //If there is multiple words typed, it will split it at the space and store in array split
            string[] splitArray = input.Split(" ");

           
            foreach (string word in splitArray)
            {
                if (vowel.Contains(word[0]))
                {
                    Console.Write(Vowel(word)+ " ");
                }
                else
                {
                    Console.Write(Consonant(word) + " ");
                }
            }

        }

        static string Vowel(string input)
        {
            return (input + "way");
        }

        static string Consonant(string input)
        {
            string consonant = "bcdfghjklmnpqrstvwxyz";

            Queue<char> consonantQueue = new Queue<char>();
            string output = "";
            int ctr = 0;

            while (consonant.Contains(input[ctr]))
            {
                consonantQueue.Enqueue(input[ctr]);
                ctr++;
            }

            for (int i = 0; i < (input.Length - ctr); i++)
            {
                output += input[i + ctr];
            }

            output += consonantQueue.Dequeue();


            return (output + "ay");
        }

    }
}
//for (int i = 0; i < input.Length; i++)
//{
//    if (consonant.Contains(input[i]))
//    {
//        consonantQueue.Enqueue(input[i]);
//    }
//    else if (vowel.Contains(input[i]))
//    {
//        ctr = i;
//        for (int j = 0; j < (input.Length - i); j++)
//        {
//            restOfWord.Enqueue(input[ctr]);
//            ctr++;
//        }
//        break;
//    }
//}
//for (int i = 0; restOfWord.Count > 0; i++)
//{
//    output += restOfWord.Dequeue();
//}
//for (int i = 0; consonantQueue.Count > 0; i++)
//{
//    output += consonantQueue.Dequeue();
//}