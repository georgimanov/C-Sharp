/*
Problem 11.	* Number as Words
Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. Examples:
numbers	number as words
0	Zero
9	Nine
10	Ten
12	Twelve
19	Nineteen
25	Twenty five
98	Ninety eight
273	Two hundred and seventy three
400	Four hundred
501	Five hundred and oneS
617	Six hundred and seventeen
711	Seven hundred and eleven
999	Nine hundred and ninety nine
*/

using System;
class PrintNumberAsWords
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int hundreds = 0;
        int tens = 0;
        int ones  = 0;
        
        hundreds = number / 100;
        hundreds = hundreds % 10;

        tens = number / 10;
        tens = tens % 10;

        ones = number % 10;

        switch (hundreds)
        {
            case 1: Console.Write("One hundred"); break;
            case 2: Console.Write("Two hundred"); break;
            case 3: Console.Write("Three hundred"); break;
            case 4: Console.Write("Four hundred"); break;
            case 5: Console.Write("Five hundred"); break;
            case 6: Console.Write("Six hundred"); break;
            case 7: Console.Write("Seven hundred"); break;
            case 8: Console.Write("Eight hundred"); break;
            case 9: Console.Write("Nine hundred"); break;

            default:
                break;
        }

        if (number > 99 && (tens != 0 || ones != 0) )
        {
            Console.Write(" and ");
        }

        if (hundreds != 0)
        {
            switch (tens)
            {
                case 1: switch (ones)
                    {
                        case 0: Console.Write("ten"); break;
                        case 1: Console.Write("eleven"); break;
                        case 2: Console.Write("twelve"); break;
                        case 3: Console.Write("thirteen"); break;
                        case 4: Console.Write("fourteen"); break;
                        case 5: Console.Write("fifhteen"); break;
                        case 6: Console.Write("sixteen"); break;
                        case 7: Console.Write("seventeen"); break;
                        case 8: Console.Write("eighteen"); break;
                        case 9: Console.Write("nineteen"); break;

                        default:
                            break;
                    }
                    ; break;
                case 2: Console.Write("twenty "); break;
                case 3: Console.Write("thirty "); break;
                case 4: Console.Write("fourty "); break;
                case 5: Console.Write("fifty "); break;
                case 6: Console.Write("sixty "); break;
                case 7: Console.Write("seventy "); break;
                case 8: Console.Write("eighty "); break;
                case 9: Console.Write("ninety "); break;

                default:
                    break;
            }
        }
        else
        {
            switch (tens)
            {
                case 1: switch (ones)
                    {
                        case 0: Console.Write("Ten"); break;
                        case 1: Console.Write("Eleven"); break;
                        case 2: Console.Write("Twelve"); break;
                        case 3: Console.Write("Thirteen"); break;
                        case 4: Console.Write("Fourteen"); break;
                        case 5: Console.Write("Fifhteen"); break;
                        case 6: Console.Write("Sixteen"); break;
                        case 7: Console.Write("Seventeen"); break;
                        case 8: Console.Write("Eighteen"); break;
                        case 9: Console.Write("Nineteen"); break;

                        default:
                            break;
                    }
                    ; break;
                case 2: Console.Write("Twenty "); break;
                case 3: Console.Write("Thirty "); break;
                case 4: Console.Write("Fourty "); break;
                case 5: Console.Write("Fifty "); break;
                case 6: Console.Write("Sixty "); break;
                case 7: Console.Write("Seventy "); break;
                case 8: Console.Write("Eighty "); break;
                case 9: Console.Write("Ninety "); break;

                default:
                    break;
            }
        }

        if (hundreds != 0 || tens != 0)
        {
            if (tens != 1)
            {
                switch (ones)
                {
                    case 1: Console.Write("one"); break;
                    case 2: Console.Write("two"); break;
                    case 3: Console.Write("three"); break;
                    case 4: Console.Write("four"); break;
                    case 5: Console.Write("five"); break;
                    case 6: Console.Write("six"); break;
                    case 7: Console.Write("seven"); break;
                    case 8: Console.Write("eight"); break;
                    case 9: Console.Write("nine"); break;

                    default:
                        break;
                }
            }
        }
        else
        {
            if (tens != 1)
            {
                switch (ones)
                {
                    case 0:
                        if (tens == 0 && hundreds == 0)
                            Console.Write("Zero");
                        break;
                    case 1: Console.Write("One"); break;
                    case 2: Console.Write("Two"); break;
                    case 3: Console.Write("Three"); break;
                    case 4: Console.Write("Four"); break;
                    case 5: Console.Write("Five"); break;
                    case 6: Console.Write("Six"); break;
                    case 7: Console.Write("Seven"); break;
                    case 8: Console.Write("Eight"); break;
                    case 9: Console.Write("Nine"); break;

                    default:
                        break;
                }
            }
        }
        Console.WriteLine();

    }
}