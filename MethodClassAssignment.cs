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
    public decimal MathOp2(decimal number1, decimal number2)
    {
        decimal newnum = Convert.ToDecimal(number1);
        return newnum * 50;
    }
    public int MathOp3(string number1, string number2)
    {
        int newnum = 50;
        return newnum % Convert.ToInt32(number1);
    }
  }

}
