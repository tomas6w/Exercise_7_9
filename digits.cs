using System;
/*
 This program calculates how many numbers of 1, 2, 3 or more digits are entered
 by the user until he/she types “end”.
*/
class digits
{
    static void Main()
    {
        int oneDigit = 0, twoDigits = 0, threeDigits = 0, aboveThreeDigits = 0;

        Console.Write("Insert a number: ");
        string numberString = Console.ReadLine(); // read the number as string to check the word "end"

        while (numberString != "end")
        {
            // if the number isn't an 'end' then we pass it to int to work with it
            int number = Convert.ToInt32(numberString); 
            if (number != 0)
            {
                if (number / 10 == 0)
                    oneDigit++;

                else if (number / 100 == 0)
                    twoDigits++;

                else if (number / 1000 == 0)
                    threeDigits++;

                else
                    aboveThreeDigits++;
            }
            Console.Write("Insert a number: ");
            numberString = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("One digit: {0}, Two digits: {1}, Three digits: {2}, More than three digits: {3}",
            oneDigit, twoDigits, threeDigits, aboveThreeDigits);
    }
}

