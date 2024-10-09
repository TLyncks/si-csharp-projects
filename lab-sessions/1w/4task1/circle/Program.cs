using System;

namespace circle
{
  class Program
  {
    static void Main(string[] args)
    {
      double pi = 3.14149;
      
      Console.WriteLine("What is the radius of the circle?");

      string x = Console.ReadLine();
      double r = Convert.ToDouble(x);

      double d = (2 * r);
      double c = (2 * pi * r);
      double a = (pi * r * r);

      Console.WriteLine("The diameter of the cirlce is: " + d);
      Console.WriteLine("The circumference of the circle is: " + c);
      Console.WriteLine("The area of the circle is: " + a);
    }
  }
}