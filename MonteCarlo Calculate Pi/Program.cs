using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo_Calculate_Pi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Casino casino = new Casino(random); // use of the single parameter struct.

            Console.Write("Please enter your array size: "); // Prompts the user for input that will define the size of the array "ZooKeeper"

            string AnimalsInTheZoo = Console.ReadLine(); // int variable that defines the size of the array.

            double[] ZooKeeper = new double[int.Parse(AnimalsInTheZoo)];

            int counter = 0; // counts the number of times the while loop has run.

            double RedShadedArea = 0; // count of plots that are greater than the value of 1


            // While loop will run until the counter is equal to the number of items in the array.
            while (int.Parse(AnimalsInTheZoo) > counter)
            {
                double Squirrel = casino.Hypotenuse(random); // Random number created by Hipos In Use Math.

                ZooKeeper.Append(Squirrel); // adds the next number to the array

                if (Squirrel <= 1)
                {
                    // Iterate over the list incrementing for each coordinate which overlaps the unit circle
                    RedShadedArea++;
                }

                counter++;
            }


            /// Using the Length parameter of the array, divide the number 
            /// of coordinates overlapping (RedShadedArea) / number of [total]Array elements
            /// multiply the above value [pieSlice] by 4
            double pieSlice = RedShadedArea / ZooKeeper.Length;


            /// print pieSlice & the absolute value of the difference between my estimate and Math.Pi
            Console.WriteLine($"1/4 of the pie: {pieSlice} || Absolute Value {Math.Abs(Math.PI / 4 - pieSlice)}");
            Console.WriteLine($"Pi Calc: {pieSlice * 4} || Absolute Value from Pi {Math.Abs(Math.PI - (pieSlice * 4))} ");
            /// Run the program passing 10, 100, 1000, and 10000


            Console.ReadLine();
        }




    }

    /// <summary>
    /// Assignment was to create a struct to handle a Monte Carlo Simulation
    /// </summary>
    public struct Casino
    {
        public double X { get; set; }
        public double Y { get; set; }


        /// <summary>
        /// Constructor accepts two double inputs (X,Y)
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public Casino(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        /// <summary>
        /// Constructor accepts a single Random input
        /// </summary>
        /// <param name="random"></param>
        public Casino(Random random)
        {
            X = random.NextDouble();
            Y = random.NextDouble();
        }

        /// <summary>
        /// Method returns a double from the Random input.
        /// </summary>
        /// <param name="random"></param>
        /// <returns></returns>
        public double Hypotenuse(Random random)
        {

            X = random.NextDouble(); // uses Random to create value Y
            Y = random.NextDouble(); // uses Random to create value Y

            double HiposInUse = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            return HiposInUse;
        }

        /// <summary>
        /// Two parameter method that takes two double inputs and returns a double.
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        public double Hypotenuse(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
            double HiposInUse = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            // Takes user input for X & Y
            return HiposInUse;
        }


    }
}
