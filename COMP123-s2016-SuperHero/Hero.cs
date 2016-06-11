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
    * This class defines a Hero
    *
    * @class Hero
    * @field _name {string}
    * @field _strength {int}
    * @field _speed {int}
    * @field _health {int}
    */

    class Hero
    {

        // Create Private Instance Variables

        private string _name;
        private int _strength;
        private int _speed;
        private int _health;
        

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This is a public property for our private _name field
         * </summary>
         * 
         * @property {string} Name
         */
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        /**
       * <summary>
       * This is a property for our _strength field
       * </summary>
       *
       * @property {int} Strength
       */

        public int Strength
        {
            get
            {
                return _strength;
            }
            set
            {
                this._strength = value;
            }
        }

        /**
        * <summary>
        * This is a property for our _speed field
        * </summary>
        *
        * @property {int} Speed
        */

        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                this._speed = value;
            }
        }

        /**
        * <summary>
        * This is a property for our _health field
        * </summary>
        *
        * @property {int} Health
        */

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                this._health = value;
            }
        }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This is the constructor for the Hero class that takes a string param
         * </summary>
         * 
         * @constructor Hero
         * @param {string} name
         */
        public Hero(string name)
        {
            this.Name = name;
            // Defines the hero's abilities
            _generateAbilities();

        }

        //PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This method generates random ability values for strength, speed and health variables.
         * </summary>
         * 
         * @method _generateAbilities()
         * @return {void}
         */
        private void _generateAbilities()
        {
            Random ability = new Random();
            _health = ability.Next(1, 101);
            _strength = ability.Next(1, 101);
            _speed = ability.Next(1, 101);
        }

        /**
         * <summary>
         * This method determines whether there is a hit or not based on a 20% chance. 
         * </summary>
         * 
         * @method _ghitAttempt()
         * @return {bool}
         */
        private bool _hitAttempt()
        {
            Random attempt = new Random();
            int chance = attempt.Next(1,101);
            if (chance < 21)
                return true;
            else
                return false;
        }
        /**
         * <summary>
         * This method outputs the damage caused
         * </summary>
         * 
         * @method _hitDamage()
         * @return {int}
         */
        private int _hitDamage()
        {
            Random hitdamage = new Random();
            int damage;
            damage = _strength * hitdamage.Next(1, 6);
            return (damage);
        }

        //PUBLIC METHODS+++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method calls the hitAttempt method and if that turns true it it calls the hitDamage method.
         * Otherwise user is informed of a miss.
         * </summary>
         * 
         * @method Fight
         * @return {void}
         */

        public void Fight()
        {
            bool hit = _hitAttempt();
            if (hit == true)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Hit damage was:");
                Console.WriteLine(_hitDamage());
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You missed!  :/ ");
            }

        }
        /**
         * <summary>
         * This method shows the Hero's name and random abilities. 
         * </summary>
         * 
         * @method Show
         * @return {void}
         */
        public void Show()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("         " + this.Name);
            Console.WriteLine("***************************");
            Console.WriteLine("");
            _generateAbilities();
            Console.WriteLine("Hero Strength:           " + _strength);
            Console.WriteLine("Hero Speed               " + _speed);
            Console.WriteLine("Hero Health:             " + _health);
        }
    }
}