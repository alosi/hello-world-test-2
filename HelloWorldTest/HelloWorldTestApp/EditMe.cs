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
        /// 
        int Min = 0;
        int number = 0;
        public static int[] RandomArray(int count)
        {
            Random random = new Random();
            int[] Array = new int[count];

            for (int i = 0; i < count; ++i)
            {
                Array[i] = random.Next(0, 1000);
            }

            return Array;
        }

        /// <summary>
        /// Obtain the minumum value of RandomArray
        /// </summary>
        public static int RandomMin(int[] Array)
        {
            int Min = Array[0];
            for (int i = 0; i < 100; ++i)
            {
                if (Array[i] < Min)
                {
                    Min = Array[i];
                }
            }
            return Min;
        }

    }

    class ProgramTest
    {
        static void Main(string[] args)
        {
            int[] Array = EditMe.RandomArray(100);

            for (int i = 0; i < Array.Length; i++)
                Console.WriteLine(Array[i]);

            int Min = EditMe.RandomMin(Array);
            Console.WriteLine();
            Console.WriteLine(Min);
        }
    }
}
