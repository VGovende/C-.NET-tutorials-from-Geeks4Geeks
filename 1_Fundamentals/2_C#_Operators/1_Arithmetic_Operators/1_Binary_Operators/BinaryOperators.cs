using System;

namespace BinaryOperatorsArithmethic{

  class BinaryOperators{
    public static void Main(string[] args){
      int result;
      int x = 10, y = 5;

      // Addition
      result = (x + y);
      Console.WriteLine("Addition Operator: " + result);

      // Subtraction
      result = (x - y);
      Console.WriteLine("Subtraction Operator: " + result);

      // Multiplication
      result = (x * y);
      Console.WriteLine("Multiplication Operator: "+ result);

      // Division
      result = (x / y);
      Console.WriteLine("Division Operator: " + result);

      // Modulus
      result = (x % y);
      Console.WriteLine("Modulus Operator: " + result);
    }
  }
}