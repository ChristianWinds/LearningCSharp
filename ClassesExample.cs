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
		public void Multiply(int num)
		{
			Number = num * Number;
		}

		public void Add()
		{
			Number = Number + 100;
		}

		// Instance Constructor.
		public CustomClass()
		{
			Number = 0;
		}
		
		public void Subtract()
		{
			Number = Number - 100;
		}

		public void Divide(int num)
		{
			Number = num / Number;
		}
		public int Show()
		{
			return Number;
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
			custClass.Multiply(4);
			Console.WriteLine($"The original result multiplied by 4 is {custClass.Number}.");

			custClass.Add();
			Console.WriteLine($"The original result multiplied by 4 and increased by 100 is {custClass.Number}.");

			custClass.Divide(2000);
			Console.WriteLine($"2,000 divided by the original number multiplied by 4, then increased by 100 is {custClass.Number}.");

			custClass.Subtract();
			Console.WriteLine($"After the division, the division result reduced by 100 is {custClass.Number}.");

			int finalResult = custClass.Show();
			Console.WriteLine($"The final result after all operations is {finalResult}.");
		}
	}
}
// The example displays the following output:
//      The result is 108.
