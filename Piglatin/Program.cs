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
                //If the word starts with a vowel, it will call the Vowel method
                if (vowel.Contains(word[0]))
                {
                    Console.Write(Vowel(word)+ " ");
                }
                //Otherwise it calls the Consonant method
                else
                {
                    Console.Write(Consonant(word) + " ");
                }
            }

        }

        //Just returns the input word with "way" concatenated
        static string Vowel(string input)
        {
            return (input + "way");
        }


        static string Consonant(string input)
        {
            string vowel = "aeiou";
            string consonant = "bcdfghjklmnpqrstvwxyz";
            Queue<char> consonantQueue = new Queue<char>();
            Queue<char> restOfWord = new Queue<char>();
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (consonant.Contains(input[i]))
                {
                    consonantQueue.Enqueue(input[i]);
                }
                else if (vowel.Contains(input[i]))
                {
                    int ctr = i;
                    for (int j = 0; j < (input.Length - i); j++)
                    {
                        restOfWord.Enqueue(input[ctr]);
                        ctr++;
                    }
                    break;
                }
            }
            for (int i = 0; restOfWord.Count > 0; i++)
            {
                output += restOfWord.Dequeue();
            }
            for (int i = 0; consonantQueue.Count > 0; i++)
            {
                output += consonantQueue.Dequeue();
            }

            //return output word with "ay" concatenated at the end.
            return (output + "ay");
        }

    }
}
