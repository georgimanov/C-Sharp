using System;

class DecreasingSeq
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split(' ');
            var seq = new long[line.Length - 1];
            for (int j = 0; j < line.Length - 1; j++)
            {
                seq[j] = Math.Abs(long.Parse(line[j]) - long.Parse(line[j + 1]));
            }

            //Console.WriteLine(string.Join(" ", seq));
            bool flag = true;

            for (int k = 1; k < seq.Length; k++)
            {
                if (!(Math.Abs(seq[k - 1] - seq[k]) == 1 || (Math.Abs(seq[k - 1] - seq[k]) == 0)))
                {
                    flag = false;
                    break;
                }


                if (!(seq[k - 1] >= seq[k]))
                {
                    flag = false;
                    break;
                }
            }
            Console.WriteLine(flag);
        }
    }
}

