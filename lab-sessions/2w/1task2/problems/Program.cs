/*
This program contains several compile time and run time errors.
See if you can correct them.
*/
using System;
namespace Problems
{
  class Problems
  {
    static void Main(string[] args)
    {
      double result1; // Result of a division expression
      int result2, input1, answer, divisor; // Some integer variables
      string input; // String variable used for input

      // Divide a floating point number by another
      result1 = 7.0 / 22.0;
      Console.WriteLine("The 7 divided by 22 is " + result1);
      
      Console.WriteLine("Input a number: " );
      input = Console.ReadLine();
      input1 = int.Parse( input );

      // Add two to an input number then double the sum and print to screen
      result2 = (input1 + 2) * 2;
      Console.WriteLine( "Two plus " + input1 + ", the sum doubled is " + result2 );
      
      // Five plus five equals ?
      answer = 5 + 5;
      Console.WriteLine("Five plus five equals " + answer);

      // Division
      Console.WriteLine( "Enter a number 0 to 9: " );
      input = Console.ReadLine();
      divisor = int.Parse( input );

      if (divisor != 0)
      {
        Console.WriteLine("1 / " + divisor + " in decimal is " + 1.0 / divisor);
      }
      else
      { 
        Console.WriteLine("Invalid Input!");
      }
      

      
    }
  }
}
