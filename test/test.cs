using System;
using System.ComponentModel.Design;

namespace CSharpTesties
{
    class Prog_dtypes
    {
        static void Main(string[] args)
        {
            /*
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
            byte b = 2;
            Console.WriteLine("An unsigned byte with value b=" + b);
            sbyte sb = -3;
            Console.WriteLine("A signed byte with value sb=" + sb);
            
            //shorts 2 byte
            ushort us = 300;
            Console.WriteLine("An unsigned short with value us=" + us);
            short s = -300;
            Console.WriteLine("A signed short with value s=" + s);

            //ints 4 byte 
            uint ui = 200000;
            Console.WriteLine("An unsigned integer with value ui=" + ui);
            int i = -200000;
            Console.WriteLine("A signed integer with value i=" + i);

            //long 8 bytes
            ulong ul = 999999999999;
            Console.WriteLine("An unsigned long with value ul=" + ul);
            long l = -999999999999;
            Console.WriteLine("A signed long with value l=" + l);

            //float 4 byte
            float f = 3.4F;
            Console.WriteLine("A float with value f=" + f);
            //double 8 byte
            double d = 10e40D;
            Console.WriteLine("A double with value d=" + d);

            //decimal 16 byte
            decimal de = 12.3456789M;
            Console.WriteLine("A decimal with value de=" + de);
            
            //char 2byte (unicode)
            char c = 'f';
            Console.WriteLine("Unicode character with value c=" + c);

            //string
            Console.WriteLine("Type a string");
            string str = Console.ReadLine();
            Console.WriteLine("The string you entered str=" + str + " with length " + str.Length);



            //byte is unsigned 8 bit value 0-255
            byte LOOPS = 6;
            //a for loop works as expected:
            for (int itr = 0; itr < LOOPS; itr++)
            {
                if(itr%2 == 0)
                {
                    Console.WriteLine("itr is even (value: itr=" + itr + ")");
                }
                else
                {
                    Console.WriteLine("itr is uneven (value: tr=" + itr + ")");
                }
                
            }
            

        }
    }
}
