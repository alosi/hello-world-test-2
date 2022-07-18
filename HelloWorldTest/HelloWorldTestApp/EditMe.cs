using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTestApp
{
    /// <summary>
    /// TODO: Implement class properties in order to satisfy requirements
    /// </summary>
    class EditMe
    {
        /// <summary>
        /// Generate an array of random integer with 100 elements
        /// </summary>
        public IEnumerable<int> RandomArray
        {
            get
            {
                return Array.Empty<int>(); //TODO: Edit this in order to create an array of random integers
            }
        }

        /// <summary>
        /// Obtain the minumum value of RandomArray
        /// </summary>
        public int RandomMin
        {
            get
            {
                return int.MinValue; //TODO: Edit this in order to return RandomArray minimum value
            }
        }
    }
}
