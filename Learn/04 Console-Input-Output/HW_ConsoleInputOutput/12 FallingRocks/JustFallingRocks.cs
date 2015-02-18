/*
Problem 12.	** Falling Rocks
Implement the "Falling Rocks" game in the text console. A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys). A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
Implement collision detection and scoring system.
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

class JustFallingRocks
{
    class Rock
    {
        public int x;
        public int y;
        public char rockChar;
    }
    
    static void Main(string[] args)
    {
        bool gameOver = false;
        int level = 15;
        char[] arrayRocks = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';'};

        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.CursorVisible = false;

        int dwarfX = Console.BufferWidth / 2;
        int dwarfY = Console.BufferHeight - 3;

        Random randomGenerator = new Random();
        var rocks = new List<Rock>();

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        
        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                    if ((dwarfX) > 0)
                    {
                        dwarfX--;
                    }
                if (pressedKey.Key == ConsoleKey.RightArrow)
                    if ((dwarfX + 3) < (Console.BufferWidth))
                    {
                        dwarfX++;
                    }
             }
            Console.SetCursorPosition(dwarfX, dwarfY);
            Console.Write("(0)");

            foreach (var rock in rocks)
            {
                if (rock.y < Console.BufferHeight)
                {
                    Console.SetCursorPosition(rock.x, rock.y);
                    
                    Console.Write("{0}", rock.rockChar); 
                    rock.y++;
                    if (rock.y == dwarfY && (rock.x == dwarfX || rock.x == (dwarfX) || rock.x == (dwarfX + 1) || rock.x == (dwarfX + 2)))
                    {
                        gameOver = true;
                    }
                }
            }
            
            Thread.Sleep(150);

            if (randomGenerator.Next(0, 100) < level)
            {
                rocks.Add(new Rock{x = randomGenerator.Next(0, Console.BufferWidth), y = 0, rockChar = arrayRocks[randomGenerator.Next(0,11)]});
            }

            Console.Clear();
           level++;
            if (gameOver)
            {
                break;
            }
        }

        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        
        Console.Clear();
        Console.WriteLine("Game Over");
        Console.WriteLine("Your score is {0:00}", ts.Seconds * level);
    }
}