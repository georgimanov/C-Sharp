using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int freezePosition = int.Parse(Console.ReadLine());
            int shiftRight = int.Parse(Console.ReadLine());

            //get frozen bit
            long frozenBit = GetBit(number, freezePosition);

            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(33,'0'));
            
            long rollNumber = number;
            //for bits in between
            if (freezePosition > 0 && freezePosition < 18)
            {
                rollNumber = ExchangeBits(freezePosition, shiftRight, frozenBit, rollNumber);
            }
            else if ( freezePosition == 0)
            {
                for (int i = 0; i < shiftRight; i++)
                {
                    long bitA = GetBit(rollNumber, 1);
                    rollNumber = rollNumber >> 1;
                    rollNumber = SetBit(rollNumber, freezePosition, frozenBit);
                    rollNumber = SetBit(rollNumber, 18, bitA);
                }
            }
            else if (freezePosition == 18)
            {
                for (int i = 0; i < shiftRight; i++)
                {
                    long bitA = GetBit(rollNumber, 0);
                    rollNumber = rollNumber >> 1;
                    rollNumber = SetBit(rollNumber, freezePosition, frozenBit);
                    rollNumber = SetBit(rollNumber, 17, bitA);
                }
            }

            //Console.WriteLine(Convert.ToString(rollNumber, 2).PadLeft(33,'0'));
            Console.WriteLine(rollNumber);
        }

        private static long ExchangeBits(int freezePosition, int shiftRight, long frozenBit, long rollNumber)
        {
            for (int i = 0; i < shiftRight; i++)
            {
                long bitA = GetBit(rollNumber, 0);
                long beforeFrozenBit = GetBit(rollNumber, freezePosition + 1);
                rollNumber = rollNumber >> 1;
                rollNumber = SetBit(rollNumber, freezePosition, frozenBit);
                rollNumber = SetBit(rollNumber, freezePosition - 1, beforeFrozenBit);
                rollNumber = SetBit(rollNumber, 18, bitA);
            }
            return rollNumber;
        }


        public static long SetBit(long number, int position, long bitValue)
        {
            if (bitValue == 0)
            {
                long mask = ~((long)1 << position);
                long result = number & mask;
                return result;
            }
            else if (bitValue == 1)
            {
                long mask = (long)1 << position;
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
}
