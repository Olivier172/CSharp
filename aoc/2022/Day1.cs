using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace aoc._2022
{
    class Day1
    {
        public List<int> ReadInput(string filepath)
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

        public int findMaxCalorieCount(List<int> calSums) 
        { 
            int maxCalorieCount = calSums.Max();
            return maxCalorieCount;
        }

        public int findTopThreeCalorieCount(List<int> calSums)
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

        public Day1()
        {
            string filepath = "../../../2022/inputs/input_d1.txt";
            List<int> calSums = ReadInput(filepath);

            //part1
            int maxCalorieCount = findMaxCalorieCount(calSums);
            Console.WriteLine("The max calories an elf is carrying is " + maxCalorieCount);
            //output: The max calories an elf is carrying is 70116.

            //part2 
            int topThreeCalorieCount = findTopThreeCalorieCount(calSums);
            Console.WriteLine("The top 3 elfs that are carrying the most calories, carry a total of " + topThreeCalorieCount + " calories");
            //output: The top 3 elfs that are carrying the most calories, carry a total of 206582 calories
        }

    }
}
