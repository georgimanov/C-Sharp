using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Int32 s = Int32.Parse(input);
        Int32 s3 = getBit(s, 3);
        Int32 s2 = getBit(s, 2);
        Int32 s1 = getBit(s, 1);
        Int32 s0 = getBit(s, 0);
        input = Console.ReadLine();
        Int32 n = Int32.Parse(input);
        Int32 counter = 0;
        for (Int32 i = 0; i < n; i++)
        {
            Int32 number = Int32.Parse(Console.ReadLine());
            for (Int32 p = 0; p < 27; p++)
            {
                if (s0 == getBit(number, p) &&
                    s1 == getBit(number, p + 1) &&
                    s2 == getBit(number, p + 2) &&
                    s3 == getBit(number, p + 3))
                {
                    counter++;
                }
            }
        }

        Console.WriteLine(counter);
    }

    public static Int32 getBit(Int32 number, Int32 position)
    {
        Int32 mask = 1 << position;
        Int32 result = mask & number;
        result = result >> position;
    
        return result;
    }
}