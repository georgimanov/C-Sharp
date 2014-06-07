/*
Problem 16.	** Bit Exchange (Advanced)
Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. The first and the second sequence of bits may not overlap. Examples:
n	        p	q	k	binary representation of n	            binary result	                        result
1140867093	3	24	3	01000100 00000000 01000000 00010101	    01000010 00000000 01000000 00100101	    1107312677
4294901775	24	3	3	11111111 11111111 00000000 00001111	    11111001 11111111 00000000 00111111	    4194238527
2369124121	2	22	10	10001101 00110101 11110111 00011001	    01110001 10110101 11111000 11010001	    1907751121
987654321	2	8	11	-	                                    -	                                    overlapping
123456789	26	0	7	-	                                    -	                                    out of range
33333333333	-1	0	33	-	                                    -	                                    out of range
*/

using System;
class BitExchangeAdvanced
{
    static void Main(string[] args)
    {
        long number = 1140867093;
        
        int p = 3;
        int q = 24;
        int k = 3;

        long bitA;
        long bitB;
        long bitC;
        
        if ((p + k) > 32 || (q + k) > 32 || k > 32 || k < 0 || p < 0 || q < 0)
        {
            Console.WriteLine("out of range");
        }
        else if( Math.Abs(p-q) <= k )
        {
            Console.WriteLine("overlapping");
        }
        else
        {
            //exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} 

            string numberAsStringBefore = Convert.ToString(number, 2);
            Console.Write("{0}", number.ToString().PadRight(20));
            Console.WriteLine("{0}", numberAsStringBefore.PadLeft(32, '0'));

            for (int i = 0; i < k; i++)
            {

                bitA = GetBit(number, (p + i));
                bitB = GetBit(number, (q + i));
                bitC = bitA;
                bitA = bitB;
                bitB = bitC;
                number = SetBit(number, (p + i), bitA);
                number = SetBit(number, (q + i), bitB);

            }

            Console.Write("{0}", number.ToString().PadRight(20));
            string numberAsStringAfter = Convert.ToString(number, 2);
            Console.WriteLine(numberAsStringAfter.PadLeft(32, '0'));
        }
    }

       
    public static long SetBit(long number, int position, long bitValue)
    {
        if (bitValue == 0)
        {
            int mask = ~(1 << position);
            long result = number & mask;
            return result;
        }
        else if (bitValue == 1)
        {
            long mask = 1 << position;
            long result = number | mask;
            return result;
        }
        else
        {
            return 0;
        }
    }

    public static long GetBit(long number, int position)
    {
        long nRightP = number >> position;
        long bit = nRightP & 1;

        return bit;
    }
}