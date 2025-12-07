// Main Program File
using System;
using OperatorOverloadAssignment; // Imported the namespace where the employee class is defined

namespace OperatorOverloadAssignment
{
    class OverloadProgram
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.ID = 30;
            emp1.FirstName = "Ali";
            emp1.LastName = "Smi";

            Employee emp2 = new Employee();
            emp2.ID = 30;
            emp2.FirstName = "Ali";
            emp2.LastName = "Smi";

            if(emp1 == emp2)
            {
                Console.WriteLine("matched");
            }
            else
            {
                Console.WriteLine("failed");
            }

        }
    }
}