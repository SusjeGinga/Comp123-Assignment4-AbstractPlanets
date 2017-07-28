using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Hoang Giang, Le
 * Date: July 28th 2017
 * Description: This is the Giant Planet class that extends the Planet class
 * Version: 0.2 - create variables and methods for Giant Planet class
 */

namespace AbstractPlanets
{
    /// <summary>
    /// This is the Giant Planet class
    /// </summary>
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // PRIVATE INSTANCE VARIABLES
        private string _type;

        // CONSTRUCTOR
        /// <summary>
        /// This is the main constructor for the Giant Planet class.
        /// It takes five parameters - name (string), diameter (double), mass(double), type (string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {
            this._type = type;
        }
        // PUBLIC METHODS

        /// <summary>
        /// This method that will return true if the MoonCount property is greater than zero
        /// </summary>
        /// <returns>bool</returns>
        public bool HasMoons()
        {
            if (this.MoonCount > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// This method that will return true if the RingCount property is greater than zero
        /// </summary>
        /// <returns>bool</returns>
        public bool HasRings()
        {
            if (this.RingCount > 0)
            {
                return true;
            }
            return false;
        }
    }
}