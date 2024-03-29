﻿using System.Collections.Generic;
using System.IO;

namespace aoc._2022
{
    class Day1
    {
        public static List<int> ReadInput(string filepath)
        {
            //reads in the input file line by line and converts it into
            //a list of calorie sums that the elfes are carrying
            
            StreamReader sr = new StreamReader(filepath);
            
            //line of input (string)
            string line;
            //collection to store total calorie counts of the elfs
            List<int> calSums = new List<int>();
            //temp var to store a single sum of calories of one elf
            int sumOfCalories = 0;

            while( (line = sr.ReadLine()) != null )
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    int calorieCount = int.Parse(line);
                    //Console.WriteLine("i read the number " + calorieCount);
                    sumOfCalories += calorieCount; 
                }
                else
                {
                    calSums.Add(sumOfCalories);
                    //Console.WriteLine("sumOfCalories = " + sumOfCalories);
                    sumOfCalories = 0;
                }
                
            }
            return calSums;
        }

        public static int FindMaxCalorieCount(List<int> calSums) 
        { 
            int maxCalorieCount = calSums.Max();
            return maxCalorieCount;
        }

        public static int FindTopThreeCalorieCount(List<int> calSums)
        {
            int topThreeCalorieCount = 0;
            calSums.Sort();
            //slice the top3 elements
            int amountOfElements = calSums.Count;
            int indexFrom = amountOfElements - 3;
            List<int> topThree = calSums.GetRange(indexFrom, 3);
            //calc the sum calories of the top three elfs that are carrying the most calories
            topThreeCalorieCount += topThree.Sum();
            return topThreeCalorieCount;
        }

        public static void Run()
        {
            string filepath = "../../../2022/inputs/input_d1.txt";
            List<int> calSums = ReadInput(filepath);

            Console.WriteLine("Day1 solution in C#:");

            //part1
            int maxCalorieCount = FindMaxCalorieCount(calSums);
            Console.WriteLine($"Part1: The max calories an elf is carrying is {maxCalorieCount}");
            //output: The max calories an elf is carrying is 70116.

            //part2 
            int topThreeCalorieCount = FindTopThreeCalorieCount(calSums);
            Console.WriteLine($"Part2: The top 3 elfs that are carrying the most calories, carry a total of {topThreeCalorieCount} calories\n");
            //output: The top 3 elfs that are carrying the most calories, carry a total of 206582 calories
        }

    }
}
