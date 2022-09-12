using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HelloWorldTestApp
{
    /// <summary>
    /// TODO: Implement interface in order to satisfy requirements
    /// </summary>
    interface IAbsolute
    {
        void GetAbsMin();
    }

    /// <summary>
    /// Gets the absoloute value of the minimum value between a and b
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    /// 
    class Value : IAbsolute
    {
        public void GetAbsMin()
        {
            throw new NotImplementedException();
        }

        public void GetAbsMin(int a, int b)  //TODO: implement the method in the derived class
        {
            Console.WriteLine(Math.Min(a, b));
        }



        /// <summary>
        /// Gets the name of the class that implements the interface
        /// </summary>
        /// 
        private string name;
        public string ClassName
        {
            get { return name; }
            set { name = value; }
        } //TODO: implement the property in the derived class
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int a = random.Next(0, 100);
            int b = random.Next(0, 100);

            Value myvalue = new Value();
            Value myInterface = new Value();
            myInterface.ClassName = "Absoloute value of the minimum value between a and b: \n";
            Console.WriteLine(myInterface.ClassName);
            myvalue.GetAbsMin(a, b);

            Console.WriteLine("\nValue of a:" + a + " and b:" + b);
        }
    }
}
