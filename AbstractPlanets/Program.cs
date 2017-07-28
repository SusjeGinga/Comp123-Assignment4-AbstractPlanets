using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name:        Hoang Giang, Le
 * ID:          300922977
 * Date:        July 28th 2017
 * Description: Assignment 4
 * Version:     2.0 - Final Version (more detail comments)
 */

namespace AbstractPlanets
{
    /// <summary>
    /// This is the Driver class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Create and display the Giant Planet 
            GiantPlanet giantPlanet = new GiantPlanet("NANCY", 5000, 407, "Ice");
            Console.WriteLine(giantPlanet.ToString());
            //Create and display the Terrestrial Planet 
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("GINGA", 6000, 687, true);
            Console.WriteLine(terrestrialPlanet.ToString());
            //Wait for user input
            WaitForAnyKey();
        }

        // Method to wait for any input
        static void WaitForAnyKey()
        {
            Console.Write("Press any key");
            Console.ReadLine();
        }
    }
}
