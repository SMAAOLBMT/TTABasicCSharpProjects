using System;

namespace MethodClassAssignment
{
    class MethodClassAssignmentProgram
    {
        static void Main(string[] args)
        {
            MethodClassAssignment math1 = new MethodClassAssignment();

            math1.MathOp(7, 9);

            Console.WriteLine("After math decimal operation function called. " + math1.MathOp2(7, 9));

            Console.WriteLine("After math operation on string conversion function called. " + math1.MathOp3("7", "9"));
            
        }
    }

}
