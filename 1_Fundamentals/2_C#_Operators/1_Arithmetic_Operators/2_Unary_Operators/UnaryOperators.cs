using System;

namespace UnaryOperatorsArithmethic{
  class UnaryOperators{
    static void Main(string[] args){
      
      int a = 10;
      int res;

      // post-increment example:
      // res is assigned 10 only,
      // a is not updated yet
      res = a++;
      // a is now 11
      System.Console.WriteLine("a is {0} and res is {1}", a, res);

      // post-decrement example:
      // res is assigned 11 only, a is not updated yet
      res = a--;
      // a is now 10
      System.Console.WriteLine("a is {0} and res is {1}", a, res);

      // pre-increment example:
      // res is assigned 11 now since a
      // is updated here itself
      res = ++a;
      // a and res have the same value 11
      System.Console.WriteLine("a is {0} and res is {1}", a, res);

      // pre-decrement example:
      // res is assigned 10 only since
      // a is updated here itself
      res = --a;
      // a and res have the same value 10
      System.Console.WriteLine("a is {0} and res is {1}", a, res);
    }
  }
}