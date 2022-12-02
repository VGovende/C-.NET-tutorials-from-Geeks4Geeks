using System;

namespace LogicalOperators{
  class LogicalOperators{
    static void Main(string[] args){
      bool a = true , b = false , result;

      //And Operator
      result = a && b;
      //
      System.Console.WriteLine("And Operator: "+result);

      //Or Operator
      result = a || b;
      //
      System.Console.WriteLine("Or Operator: "+result);

      //Not Operator
      result = !a;
      System.Console.WriteLine("Not Operator: "+result);

    }
  }
}