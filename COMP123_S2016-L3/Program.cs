using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 *  Author: Janelle Heron
 *  Date Created: May 17 2016
 *  Description: Advanced Methods Demo for Lesson 2
 *  Version: 0.0.5 - Added ReadUntilEnd, incomplete...
 *  
 */

namespace COMP123_S2016_L3
{

 /**
 * Main driver class
 * 
 * @class Program
 */

    public class Program
    {
        /**
         *  Main method for our driver class
         *  
         *  @constructor Main
         *  @param {string[]} args
         */
        static void Main(string[] args)
        {
            int x = 50;

            int y = 40;

            int result = 0;

            result = addXandY(x, y);
            Console.WriteLine(result);
            Console.WriteLine();
            addYtoX(ref x, ref y);
            Console.WriteLine(x);

            Console.WriteLine();

            Console.WriteLine();
        }
        
        /**
         *  Simple method to add two values
         *  
         *  @methid addXandY
         *  @param {int} firstNum
         *  @param {int} secondNum
         */

        public static int addXandY(int firstNum, int secondNum)
        {
            int result = 0;
            result = firstNum + secondNum;
            return result;
        }

        /**
         * Simple method to demonstrate pass by reference with ref keyword
         * 
         * @method addYtoX
         * @param {ref int} X
         * @param {ref int} Y
         */

        public static int addYtoX(ref int X, ref int Y)
        {
            X += Y;

            return X;
        }

        public static string[] ReadUntilEnd()
        {
            string[] inputs = new string[100]; 

            int inputCounter = 0;

       
            do
            {
                Console.WriteLine("Enter a value --('end' to stop)");
                inputs[inputCounter] = Console.ReadLine();

                if (inputs[inputCounter] == "end")
                {
                    inputCounter = -1;
                }
                else
                {
                    inputCounter++;
                }
            } while (true);

            return inputs;
        }
    }
}
