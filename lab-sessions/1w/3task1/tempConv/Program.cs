using System; // ensures availability of resources

namespace tempConv // ensures common area of memory
{
  class TempConv
  { 
    static void Main(string[ ] args) // where execution starts
    {
      double fahrTemp, celTemp;
      string input; // string is a ‘class’ type
      Console.WriteLine("Enter a temperature in degrees F >");
      input = Console.ReadLine();
      fahrTemp = double.Parse( input ); // converts string to double
      celTemp = (fahrTemp - 32.0) * 5.0/9.0; // conversion
      Console.WriteLine("The temperature in degrees C is " + celTemp);

    } // brackets define blocks of code and are indented
  }
}
