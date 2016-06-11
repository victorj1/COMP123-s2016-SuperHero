using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Author: Victor Jdanovitch
 * Student #: 300869472
 * Date Modified: June 10th, 2016
 * Program Description: Assignment #2: Building and Implementing the SuperHero Class using VS Studio
 * Revision: A
 */

namespace COMP123_Hero_Class_Assignment1
{
    /**
     * This class is the "Driver" class for the program
     * 
     * @class Program
     */
    class Program
    {
        /**
         * the main method for the driver class Program
         * 
         * @method Main
         * @param {string[]} args
         */
        static void Main(string[] args)
        {
            // create a new instance of SuperHero class
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            SuperHero victor = new SuperHero("Victor            ");
            victor.Show();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            victor.ShowPowers();
            Console.WriteLine("");
            victor.Fight();
        }
    }
}
