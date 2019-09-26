using System;

namespace ProgrammingGuide
{
	// Class definition.
	public class CustomClass
	{
		// Class members.
		//
		// Property.
		public int Number { get; set; }

		// Method.
		public int Multiply(int num)
		{
			return num * Number;
		}

		public int Add(int num)
		{
			return num + 100;
		}

		// Instance Constructor.
		public CustomClass()
		{
			Number = 0;
		}
	}

	// Another class definition that contains Main, the program entry point.
	class Program
	{

		static void Main(string[] args)
		{
			// Create an object of type CustomClass.
			CustomClass custClass = new CustomClass();

			// Set the value of the public property.
			custClass.Number = 27;
			Console.WriteLine($"The original number is {custClass.Number}.");

			// Call the public method.
			int result = custClass.Multiply(4);
			Console.WriteLine($"The original result multiplied by 4 is {result}.");

			result = custClass.Add(result);
			Console.WriteLine($"The original result multiplied by 4 and increased by 100 is {result}.");
		}
	}
}
// The example displays the following output:
//      The result is 108.
