﻿using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin translator");
            TranslatePig();
        }

        public static void TranslatePig()
        {


            Console.WriteLine("Submit a word that you need translated:");
            string input = Console.ReadLine();


            char[] pigWords = input.ToCharArray();
            if (IsVowel(pigWords[0]) == true)
            {
                TranslateVowel(input);
            }
            else
            {
                TranslateCon(input);
            }


        }

        public static bool IsVowel(char pigWord)
        {

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < 5; i++)
            {


                if (pigWord == vowels[i])
                {
                    return true;
                }
            }
            return false;
        }

        public static void TranslateVowel(string pigWord)
        {
            Console.WriteLine(pigWord + "way");

        }

        public static void TranslateCon(string pigWord)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            char[] letters = pigWord.ToCharArray();

            for (int l = 0; l < pigWord.Length; l++)
            {


                if (letters[l] == vowels[0] || letters[l] == vowels[1] || letters[l] == vowels[2] || letters[l] == vowels[3] || letters[l] == vowels[4])
                {
                    string substring = pigWord.Substring(l);
                    string substring2 = pigWord.Substring(0, l);
                    Console.WriteLine(substring + substring2 + "ay");
                    break;
                }

            }


        }

    }

}

