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
            string consonant = "bcdfghjklmnpqrstvwxyz";
            Queue<char> consonantQueue = new Queue<char>();
            string output = "";
            int ctr = 0;

            //This will check each letter and if it is a consonant, it will put it in constantQueue until it gets to a vowel
            while (consonant.Contains(input[ctr]))
            {
                consonantQueue.Enqueue(input[ctr]);
                ctr++;
            }

           //Once a vowel is enountered, this loop will put the rest of the letters in "output"
            for (int i = 0; i < (input.Length - ctr); i++)
            {
                output += input[i + ctr];
            }

            //Dequeue from queue back onto output
            output += consonantQueue.Dequeue();

            //return output word with "ay" concatenated at the end.
            return (output + "ay");
        }

    }
}
