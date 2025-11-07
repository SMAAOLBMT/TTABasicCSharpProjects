using System;
using System.Runtime.CompilerServices;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight.");
            string getWat = Console.ReadLine();
            //float pacWat = Convert.ToSingle(getWat);
            float pacWat = 0;
            bool floatCheck = false;

            pacWat = checkInput(getWat, pacWat, floatCheck);

            checkWeight(pacWat);

            //Console.WriteLine(pacWat.ToString());

            Console.WriteLine("Please ender the package width");
            float pacWdth = float.Parse(Console.ReadLine());

            Console.WriteLine("Please ender the package height");
            float pachite = float.Parse(Console.ReadLine());

            Console.WriteLine("Please ender the package length");
            float pacLen = float.Parse(Console.ReadLine());

            checkDimension(pacWdth, pachite, pacLen);

            float shipTotal = ( (pacWdth * pachite * pacLen) * pacWat) / 100;

            Console.WriteLine("Your estimated total for shipping this package is: $" + shipTotal.ToString() + " Thank you!");

        }

        static void checkDimension(float wdth, float hth, float len)
        {
            if ((wdth + hth +len) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express..");
                Environment.Exit(1);
            }
            else
            {
                //Console.WriteLine("Package dimension is ok to proceed...");
            }
        }

        static void checkWeight(float pwat)
        {
            if (pwat > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Environment.Exit(1);
            }
            else
            {
                //Console.WriteLine("Package weight is valid to proceed...");
            }
        }

        static float checkInput(string getInput, float getFloat, bool getBool)
        {
            while (getBool != true)
            {
                if (!float.TryParse(getInput, out getFloat))
                {
                    Console.WriteLine("Pleae enter the valid numeric weight numbers...");
                    getInput = Console.ReadLine();
                    getBool = false;
                    continue;
                }
                else
                {
                    getFloat = float.Parse(getInput);
                    getBool = true;
                }

            }

            return getFloat;

        }

    }

}