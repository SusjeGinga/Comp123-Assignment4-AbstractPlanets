using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Hoang Giang, Le
 * Date: July 28th 2017
 * Description: This is the TerrestrialPlanet class
 * Version: 0.3 - create variables and methods for TerrestrialPlanet class
 */

namespace AbstractPlanets
{
    /// <summary>
    /// This is the TerrestrialPlanet class
    /// </summary>
    public class TerrestrialPlanet : Planet, IHasMoons
    {
        // PRIVATE INSTANCE VARIABLES
        private bool _oxygen;
        // CONSTRUCTOR
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            :base(name, diameter, mass)
        {
            this._oxygen = oxygen;
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
        /// This method that will return true if the oxygen instance variable is set to true
        /// </summary>
        /// <returns>bool</returns>
        public bool Habitable()
        {
            if (this._oxygen == true)
            {
                return true;
            }
            return false;
        }
    }
}