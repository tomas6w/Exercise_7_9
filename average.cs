using System;

public class Average //This program calculates the average of a set of marks, until the user types “end”.
{
	public static void Main()
	{
		double accumulatedMark = 0, markDouble, counter = 0, average;
		string mark; 

		Console.Write("Insert a mark: ");
		mark = Console.ReadLine();

		while (mark != "end")
		{  
			markDouble = Convert.ToDouble(mark);
			counter++;
			accumulatedMark += markDouble;
			Console.Write("Insert a mark: ");
			mark = Console.ReadLine();
		}

		if (counter != 0)
		{
                        Console.WriteLine();

			average = accumulatedMark / counter;
			Console.WriteLine("The average is {0}.", average);
		}
	}
}
