using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Hoang Giang, Le
 * Date: July 28th 2017
 * Description: Assignment 4
 * Version: 0.4 - Finish question 7
 */

namespace AbstractPlanets
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("NANCY", 160, 40, "Ice");
            Console.WriteLine(giantPlanet.ToString());
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("GINGA", 170, 68, true);
            Console.WriteLine(terrestrialPlanet.ToString());
            WaitForAnyKey();


        }
        static void WaitForAnyKey()
        {
            Console.Write("Press any key");
            Console.ReadLine();
        }
    }
}
