using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTestApp
{
    /// <summary>
    /// TODO: Implement interface in order to satisfy requirements
    /// </summary>
    interface IImplementMe
    {
        /// <summary>
        /// Gets the absoloute value of the minimum value between a and b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int GetAbsMin(int a, int b); //TODO: implement the method in the derived class


        /// <summary>
        /// Gets the name of the class that implements the interface
        /// </summary>
        string ClassName { get; } //TODO: implement the property in the derived class
    }
}
