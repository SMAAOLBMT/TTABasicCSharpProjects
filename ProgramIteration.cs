using System;
using System.Collections.Generic;

namespace Iteration
{
    class ProgramIteration
    {
        static void Main()
        {
            //Console App Assignment Part 1 Starts
            string[] UserInput = new string[5];
            string tempRead = "";
            bool chkBool = true;
            Console.WriteLine("Enter text 5 times to add in array...");
            for (int i=0; i <UserInput.Length; i++)
            {
                tempRead = Console.ReadLine();
                UserInput[i] = tempRead;
            }

            for (int j = 0; j < UserInput.Length; j++)
            {
                Console.WriteLine("Your "+ (j + 1) + " Input is: " + UserInput[j]);
            }

            //Console App Assignment Part 1 Ends

            //Console App Assignment Part 2 Starts

            while (chkBool == true)
            {
                Console.WriteLine("Condition set to TRUE!");
                //following loop will make the chkBool condition false
                for(int k = 0; k < UserInput.Length; k++)
                {
                    chkBool = false;
                }
            }

            //Console App Assignment Part 2 Ends

            //Console App Assignment Part 3 Starts

            int a = 3;
            int b = 5;

            while ( a < b)
            {
                Console.WriteLine("A is less then B number");
                a = a + 1;
            }

            while (a <= b)
            {
                Console.WriteLine("A is less or equal to the B number");
                a = a + 1;
            }

            //Console App Assignment Part 3 Ends

            //Console App Assignment Part 4 Starts
            string[] searchList = {"yellow", "red", "green", "blue", "yellow" };

            Console.WriteLine("Enter your favourite color");
            string tmpStr = Console.ReadLine();
            bool srhFlag = false;

            for (int m=0; m < searchList.Length; m++)
            {
                //Console.WriteLine(searchList[m]);
                if(tmpStr == searchList[m])
                {
                    Console.WriteLine("search index: " + m.ToString());
                    srhFlag = true;
                    //Environment.Exit(0);
                }                                
            }

            if (srhFlag == false)
            {
                Console.WriteLine("Your input did not match");
            }

            //Console App Assignment Part 4 Ends

            //Console App Assignment Part 5 Starts
            string[] searchList2 = { "yellow", "red", "green", "blue", "yellow" };

            Console.WriteLine("Enter your favourite color");
            string tmpStr2 = Console.ReadLine();
            bool srhFlag2 = false;

            for (int m = 0; m < searchList2.Length; m++)
            {
                for (int n = 0; n < searchList2.Length; n++)
                {
                    //Console.WriteLine(searchList[m]);
                    if ((searchList2[m] == searchList2[n]) && ( m != n))
                    { 
                        Console.WriteLine("this is duplicate: " + searchList2[n]);
                        srhFlag2 = true;
                    }
                    
                }
                if (srhFlag2 == false)
                {
                    Console.WriteLine("this is unique: " + searchList2[m]);
                }

                srhFlag2 = false;
            }

            //Console App Assignment Part 5 Ends

        }
    }
}