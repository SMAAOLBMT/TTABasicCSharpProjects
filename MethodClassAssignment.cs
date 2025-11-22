using System;

namespace MethodClassAssignment
{
    public class MethodClassAssignment
    {
        public void MathOp(int number1, int number2)
        {
            int total = number1 + 50;
            Console.WriteLine("new value for number1 is: " + total.ToString() + " AND old value of number2 was: " + number2.ToString());
        }
        /*public int MathOp(decimal number)
        {
            int newnum = Convert.ToInt32(number);
            return newnum * 20;
        }
        public int MathOp(string number)
        {
            int newnum = Convert.ToInt32(number);
            return newnum % 7;
        }*/
    }
}