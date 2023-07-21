using System.IO;

namespace aoc._2022
{
    class Day2
    {

        ////////////
        // PART 1 //
        ////////////
        public static int EvalWinLoseDrawScore(int opponentMove, int urMove)
        {
            //score lookup table (LUT) win = 6, draw = 3, lose = 0
            // row index is opponentMove
            // col index is urMove
            int[,] score = new int[,]
            {
                { 3, 6, 0},
                { 0, 3 ,6},
                { 6, 0, 3},
            };

            return score[opponentMove, urMove];
        }

        public static int ConvertMoveToIndex(string move)
        {
            if(move == "A" || move == "X")
            {
                return 0;
            }
            else if(move == "B" || move == "Y")
            {
                return 1;
            }
            else if(move == "C" || move == "Z")
            {
                return 2;
            }
            else
            {
                return -3;
            }
        }
        
        public static int CalcResultPartOne(string filepath)
        {
            StreamReader sr = new StreamReader(filepath);
            string line;
            int totalScore = 0;

            while ((line = sr.ReadLine()) != null)
            {
                int urMove, opponentMove;
                int currentScore = 0;

                string[] moves = line.Split(" ");
                opponentMove = ConvertMoveToIndex(moves[0]);
                urMove = ConvertMoveToIndex(moves[1]);
                //Console.WriteLine($"urMove = {urMove} and OpponentMove = {opponentMove}");

                currentScore += (urMove + 1); //points based on move
                currentScore += EvalWinLoseDrawScore(opponentMove, urMove); //points based on win lose draw

                totalScore += currentScore;
            }
            return totalScore;
        }

        ////////////
        // PART 2 //
        ////////////
        public static int EvalResultScore(string result)
        {
            if(result == "X")
            {
                return 0; //lose
            }
            else if(result == "Y")
            {
                return 3; //draw
            }
            else if(result == "Z")
            {
                return 6; //win
            }
            else
            {
                return 0;
            }
        }

        public static int EvalMoveScore(string opponentMove, string result)
        {
            if (opponentMove == "A") //rock
            {
                if(result == "X") //lose
                {
                    return 3; //scissors
                }
                else if(result == "Y") //draw 
                {
                    return 1; //rock
                }
                else //win
                {
                    return 2; //paper
                }
            }
            else if (opponentMove == "B") //paper
            {
                if (result == "X") //lose
                {
                    return 1; //rock
                }
                else if (result == "Y") //draw 
                {
                    return 2; //paper
                }
                else //win
                {
                    return 3; //scissors
                }
            }
            else //scissors, opponentMove == "scissors"
            {
                if (result == "X") //lose
                {
                    return 2; //paper
                }
                else if (result == "Y") //draw 
                {
                    return 3; //scissors
                }
                else //win
                {
                    return 1; //rock
                }
            }
        }
        
        public static int CalcResultPartTwo(string filepath)
        {
            StreamReader sr = new StreamReader(filepath);
            string line;
            int totalScore = 0;

            while ((line = sr.ReadLine()) != null)
            {
                string opponentMove, result;
                int resultScore, moveScore;
                int currentScore = 0;

                string[] moves = line.Split(" ");
                opponentMove = moves[0];
                result = moves[1];
                resultScore = EvalResultScore(result);
                moveScore = EvalMoveScore(opponentMove, result);

                currentScore += resultScore; //points based on round result
                currentScore += moveScore; //points based on move

                totalScore += currentScore;
            }
            return totalScore;
        }

        public static void Run() 
        {
            string filepath = "../../../2022/inputs/input_d2.txt";

            Console.WriteLine("Day2 solution in C#:");

            //part1
            int score = CalcResultPartOne(filepath);
            Console.WriteLine($"Part1: The total score is {score}");
            //output: Part1: The total score is 12276

            //part2
            score = CalcResultPartTwo(filepath);
            Console.WriteLine($"Part2: The total score is {score}\n");
            //output: Part2: The total score is 9975

        }
    }
}
