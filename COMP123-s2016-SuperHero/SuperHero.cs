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
     * <summary>
     * This is the SuperHero class. It is derived from Hero class 
     * </summary>
     * 
     * @class SuperHero 
     * @extends Hero 
     */
    class SuperHero : Hero
    {
        
        //PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++
        private string[] _superPowers;

        //PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
          * <summary>
          * This is a public property for _superPowers field
          * </summary>
          * 
          * @property {string[]} SuperPowers
          */

        public string[] SuperPowers
        {
            get
            {
                return _superPowers;
            }
            set
            {
                this._superPowers = value;
            }
        }
        //CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This is the constructor for the SuperHero class that takes a string param
         * </summary>
         * 
         * @constructor SuperHero
         * @extends Hero
         * @param {string} name
         */
        public SuperHero(string name)
            : base(name)
        {

        }

        //PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method randomly generates three random superpowers from the list of 6 powers.
         * </summary>
         * 
         * @method _generateRandomPowers()
         * @return {void}
         */

        private void _generateRandomPowers()
        {
            Random power = new Random();

            string[] _superPowers = new string[] { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control" };
            int n = _superPowers.Length;
            for (int i = 0; i < n; i++)
            {
                int r = i + (int)(power.NextDouble() * (n - i));
                string t = _superPowers[r];
                _superPowers[r] = _superPowers[i];
                _superPowers[i] = t;
            }

            Console.WriteLine("1. " + _superPowers[0]);
            Console.WriteLine("2. " + _superPowers[1]);
            Console.WriteLine("3. " + _superPowers[2]);
        }

        //PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method displays the Super Hero's powers 
         * </summary>
         * 
         * @method ShowPowers
         * @return {void}
         */
        public void ShowPowers()
        {
            Console.WriteLine("+++++++++++++++++++++++++++");
            Console.WriteLine("Super Hero Powers");
            Console.WriteLine("+++++++++++++++++++++++++++");
            Console.WriteLine("");
            _generateRandomPowers();
            Console.WriteLine("");
            Console.WriteLine("FIGHT!");

        }
    }
}
