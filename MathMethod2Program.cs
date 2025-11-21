using System;

namespace MainMethodAssignment
{
    class MathMethod2Program
    {
        static void Main(string[] args)
        {
            MathMethod2 math1 = new MathMethod2();
            Console.WriteLine(math1.MathOp(7));
            Console.WriteLine(math1.MathOp(7.3m));
            Console.WriteLine(math1.MathOp("7"));
        }
    }
}