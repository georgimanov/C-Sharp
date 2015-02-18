using System;
class Program
{
    static void Main(string[] args)
    {
        string numbersString = Console.ReadLine();
        numbersString = numbersString.Trim();
        char[] splitOptions = { ' ' };
        string[] myStringArr = numbersString.Split(splitOptions, StringSplitOptions.RemoveEmptyEntries);

        decimal oddSum = 0m;
        decimal oddMin = decimal.MaxValue;
        decimal oddMax = decimal.MinValue;
        decimal evenSum = 0m;
        decimal evenMin = decimal.MaxValue;
        decimal evenMax = decimal.MinValue;

        decimal firstNumber = decimal.Parse(myStringArr[0]);
        oddMax = firstNumber;
        oddMin = firstNumber;

        if (myStringArr.Length > 1)
        {
            decimal secondNumber = decimal.Parse(myStringArr[1]);
            evenMax = secondNumber;
            evenMin = secondNumber;
        }
        if (myStringArr.Length == 0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else if (myStringArr.Length == 1)
        {
            if (myStringArr[0] == "")
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("OddSum={0}, OddMin={0}, OddMax={0}, EvenSum=No, EvenMin=No, EvenMax=No",
                (double)oddMax);
            }
            }
        else
        {
            for (int i = 0; i < myStringArr.Length; i++)
            {
                decimal number = decimal.Parse(myStringArr[i]);
                if (i % 2 == 0)
                {
                    oddSum += number;
                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                }
                else
                {
                    evenSum += number;
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }
            }
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
            (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
        }
    }
}

