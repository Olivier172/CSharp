using System;
using System.Collections.Generic; //for dictionaries

namespace CSharpTesties
{
    class Program 
    {
        static void ReadInputAndAnalyze()
        {
            Console.WriteLine("Please specify a string");
            string input = Console.ReadLine();
            Dictionary<char, int> LetterCounter = new Dictionary<char, int>(); 
            foreach(char letter in input)
            {
                if(LetterCounter.ContainsKey(letter))
                {
                    LetterCounter[letter]++; //increment amount of appearences of this letter
                }
                else
                {
                    LetterCounter[letter] = 1; //first encounter of this letter
                }
            }
            Console.WriteLine("Entered sting has length " + input.Length);
            Console.WriteLine("LetterCounter results:");
            foreach(char letter in LetterCounter.Keys)
            {
                string msg;
                if (LetterCounter[letter] == 1)
                {
                    msg = letter + " appears once";
                }
                else
                {
                    msg = letter + " appears " + LetterCounter[letter] + " times";
                } 
                
                Console.WriteLine(msg);
            }
            Console.Write("\n");
        }

        static void Main(string[] args)
        {
            Program.ReadInputAndAnalyze();
            DataTypeTest obj = new DataTypeTest();
            obj.printAttrs();
            obj.DoALoop();


        }
    }

    /// <summary>
    /// Class <c>ProgDtypes</c> contains some code to test out different datatypes in c#
    /// </summary> 
    class DataTypeTest
    {
        public byte b;
        public sbyte sb;
        public ushort us;
        public short s;
        uint ui;
        int i;
        ulong ul;
        long l;
        float f;
        double d;
        decimal de;
        char c;
        string str;
        
        /// <summary>
        /// The constructor for this class which initializes all attributes
        /// </summary>
        public DataTypeTest()
        {
            b = 2; //byte 0-255
            sb = -3; //signed byte
            us = 300; //unsigned short
            s = -300; //signed short
            ui = 200000; //unsigned int
            i = -200000; //signed int 
            ul = 999999999999; //unsigned long
            l = -999999999999; //signed long
            f = 3.4F; //float
            d = 10e40D; //double
            de = 12.3456789M; //decimal
            c = 'f'; // unicode char
            str = "this is a test string with a lot of chars";
        }

        /// <summary>
        /// Function to print out the values of all the attributes of this object
        /// </summary>
        public void printAttrs()
        {
            /*
             * In C# we have multiple types (primitive and non primitive)
             *  Simple types:
             *      unsigned: byte, ushort, uint, ulong
             *      signed: sbyte, short, int, long
             *      unicode: char
             *      ieee floating point: float, double
             *      high precision decimal: decimal
             *      boolean: bool
             *  Reference types:
             *      class types: unicode strings = "string"
             */

            //bytes 1 byte
            Console.WriteLine("An unsigned byte with value b=" + b);
            Console.WriteLine("A signed byte with value sb=" + sb);
            
            //shorts 2 byte
            Console.WriteLine("An unsigned short with value us=" + us);
            Console.WriteLine("A signed short with value s=" + s);

            //ints 4 byte 
            Console.WriteLine("An unsigned integer with value ui=" + ui);
            Console.WriteLine("A signed integer with value i=" + i);

            //long 8 bytes
            Console.WriteLine("An unsigned long with value ul=" + ul);
            Console.WriteLine("A signed long with value l=" + l);

            //float 4 byte
            Console.WriteLine("A float with value f=" + f);
            //double 8 byte
            Console.WriteLine("A double with value d=" + d);

            //decimal 16 byte
            Console.WriteLine("A decimal with value de=" + de);
            
            //char 2byte (unicode)
            Console.WriteLine("Unicode character with value c=" + c);

            //string
            Console.WriteLine("The string you entered str=" + str + " with length " + str.Length);      
        }

        ///<summary>
        ///A function that tests out a for loop
        public void DoALoop()
        {
            //byte is unsigned 8 bit value 0-255
            byte LOOPS = 6;
            //a for loop works as expected:
            Console.WriteLine("for loop:");
            for (int itr = 0; itr < LOOPS; itr++)
            {
                if (itr % 2 == 0)
                {
                    Console.WriteLine("itr is even (value: itr=" + itr + ")");
                }
                else
                {
                    Console.WriteLine("itr is uneven (value: tr=" + itr + ")");
                }

            }
            Console.Write("\n");

            //while loop counter 
            byte counter = 0;
            //creating and initializing a dictionary like this:
            Dictionary<byte,string> NumberToString = new Dictionary<byte, string>()
            {
                {0, "zero"},
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {4, "four"},
                {5, "five"}
            };

            Console.WriteLine("while loop:");
            while(counter<LOOPS)
            {
                Console.WriteLine("counter is {0}", NumberToString[counter]);
                switch (counter) 
                {
                    case 0:
                    {
                            Console.WriteLine("special case");
                            break;
                    }
                    case 3:
                    {
                            Console.WriteLine("other special case");
                            break;
                    }
                }
                counter++;
            }
            Console.Write("\n");

        }


    }
}
