using System;

namespace MethodClassAssignment
{
    class MethodClassAssignmentProgram
    {
        static void Main(string[] args)
        {
            MethodClassAssignment math1 = new MethodClassAssignment();
            /*Console.WriteLine(math1.MathOp(7));
            Console.WriteLine(math1.MathOp(7.3m));
            Console.WriteLine(math1.MathOp("7"));*/

            math1.MathOp(7, 9);
            
        }
    }
}