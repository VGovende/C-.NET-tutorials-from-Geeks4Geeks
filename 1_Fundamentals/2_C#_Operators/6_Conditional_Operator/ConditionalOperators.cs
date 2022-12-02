using System;

namespace ConditionalOperators{
  class ConditionalOperators
  {
    static void Main(string[] args)
    {
      int x = 5, y = 10, result;

      //To find which value is Greater using Conditional Operator
      result = x > y ? x : y;
      System.Console.WriteLine("Result: " + result);
    
      //To find which value is Less using Conditional Operator
      result = x < y ? x : y;
      System.Console.WriteLine("Result: " + result); 
    }
  }
}