using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Hoang Giang, Le
 * Date: July 28th 2017
 * Description: This is the Abstract Planet class
 * Version: 0.2 - Add some comments
 */

namespace AbstractPlanets
{
    /// <summary>
    /// This is the Abstract Planet class
    /// </summary>
    public abstract class Planet
    {
        // PRIVATE INSTANCE VARIABLES
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // PUBLIC PROPERTIES
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                _moonCount = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                _orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return _ringCount;
            }
            set
            {
                _ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                _rotationPeriod = value;
            }
        }

        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for the Planet class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
        public override string ToString()
        {
            return string.Format("The planet {0} has {1}m diameter and {2}kg mass.", this.Name, this.Diameter, this.Mass);
        }
    }
}