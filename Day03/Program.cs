using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var input = new List<string>();
            input.Add("vJrwpWtwJgWrhcsFMMfFFhFp");
            input.Add("jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL");
            input.Add("PmmdzqPrVvPwwTWBwg");
            input.Add("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn");
            input.Add("ttgJtRGJQctTZtZT");
            input.Add("CrZsJsPPZsGzwwsLwLmpwMDw");


            var letters = new List<char>();
            int sum = 0;

            for (char i = 'a'; i <= 'z'; i++)
            {
                letters.Add(i);
            }
            for (char i = 'A'; i <= 'Z'; i++)
            {
                letters.Add(i);
            }



            for (int i = 0; i < input.Count; i++)
            {
                int rucksackNum = i+1;
                var rucksack = new List<char>();
                rucksack.AddRange(input[i]);

                int compartmentSize = rucksack.Count / 2;
                var firstHalf = new List<char>();
                var secondHalf = new List<char>();

                for (int j = 0; j < compartmentSize-1; j++)
                {
                    firstHalf.Add(rucksack[j]);
                }
                for (int j = compartmentSize; j < input[i].Length - 1; j++)
                {
                    secondHalf.Add(rucksack[j]);
                }

                char priority = new char();
                foreach (char m in firstHalf)
                {
                    foreach (char n in secondHalf)
                    {
                        if (n == m)
                        {
                            priority = m;
                        }
                    }
                }

                int pSum = letters.IndexOf(priority) + 1;
                for (int j = 0; j < rucksack.Count; j++)
                {
                    if (rucksack[j] == priority)
                    {
                        pSum = pSum + 1;
                    }

                }

                sum = sum + (letters.IndexOf(priority)+1);

                Console.WriteLine("Rucksack number " + rucksackNum + "'s priority is " + priority);
                
            }


            Console.WriteLine("The sum of the priority items is " + sum);

        }
    }
}
