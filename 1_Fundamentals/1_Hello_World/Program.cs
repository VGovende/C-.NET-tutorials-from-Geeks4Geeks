// System is a namespace which contains the commonly used types. It is specified with a using System directive.
using System;

// Here namespace is the keyword which is used to define the namespace. "HelloWorldApp" is the user-defined name given to namespace
namespace HelloWorldApp{

  // Here class is the keyword which is used for the declaration of classes. "HelloWorld" is the user-defined name of the class. 
  class HelloWorld{
    // Here static keyword tells us that this method is accessible without instantiating the class. void keyword tells that this method will not return anything. Main() method is the entry point of our application. In our program, Main() method specifies its behavior with the statement Console.WriteLine(“Hello World!”);
    static void Main(string[] args){

      //  Here WriteLine() is a method of the Console class defined in the System namespace
      System.Console.WriteLine("Hello World");
      
      // This is for the VS.NET Users. This makes the program wait for a key press and prevents the screen from running and closing quickly.
      System.Console.ReadKey();
    }
  }
}