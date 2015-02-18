using System;
class PrimeNumbers
{
    static void Main(string[] args)
    {

        long n = 100;
        // long n = 10000001;

        bool[] isPrimePosition = new bool[n];         //by default they're all false
        
        for (int i = 2; i < n; i++)
        {
            //set all numbers to true
            isPrimePosition[i] = true;
        }

        //weed out the non primes by finding mutiples 
        for (int i = 2; i < n; i++)
        {
            if (isPrimePosition[i]) //is true
            {
                for (long j = 2; (j * i) < n; j++)
                {
                    isPrimePosition[j * i] = false;
                }
            }
        }


        // Printing takes time
        for (int i = 2; i < n; i++)
        {
            if (isPrimePosition[i])
            {
                Console.WriteLine(i);
            }
        }
    }
}