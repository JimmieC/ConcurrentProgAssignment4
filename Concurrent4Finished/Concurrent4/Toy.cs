using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrent4
{
    /// <summary>
    /// Class for Toy, used by Toy factory and buffer and santa classes
    /// </summary>
    class Toy
    {
        /// <summary>
        /// Variables, the properties for toys
        /// </summary>
        private string name;
        private double weight;
        private double volume;

        /// <summary>
        /// Constructor for Toy, initialize variables to paramters
        /// </summary>
        /// <param name="name">name of a toy</param>
        /// <param name="weight">the weight of a toy</param>
        /// <param name="volume">the volume of a toy</param>
        public Toy(string name, double weight, double volume)
        {
            this.name = name;
            this.weight = weight;
            this.volume = volume;
        }

        /// <summary>
        /// Property for Name
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Property for Weight
        /// </summary>
        public double Weight
        {
            get { return weight; }
        }

        /// <summary>
        /// Property for Volume
        /// </summary>
        public double Volume
        {
            get { return volume; }
        }


    }
}
