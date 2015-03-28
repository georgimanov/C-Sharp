using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace ChromeDino
{
    public class Dino
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string dinoBody { get; set; }
    }

    public class Obstacle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char cactusChar { get; set; }
    }

    internal class ChromeDino
    {
        private static void Main()
        {
            var gameOver = false;
            var level = 5;
            var randomGenerator = new Random();
            char[] arrayCactuses = {'^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';'};
            var obstacles = new Queue<Obstacle>();
            var inJump = false;
            var jumpCounter = 0;

            var watch = new Stopwatch();
            watch.Start();

            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false;

            var startCol = 15;
            var startRow = Console.BufferWidth/5;

            var dino = new Dino();
            dino.X = startCol;
            dino.Y = startRow;
            dino.dinoBody = "/\\";

            while (true)
            {
                inJump = DinoJump(dino, inJump, startRow, ref jumpCounter);

                DisplayDino(dino);

                DisplayWatch(watch);

                MoveObstacles(obstacles);

                if (obstacles.Any())
                {
                    if (obstacles.Peek().X == dino.X && obstacles.Peek().Y == dino.Y)
                    {
                        gameOver = true;
                    }
                }

                if (gameOver)
                {
                    watch.Stop();
                    break;
                }

                Thread.Sleep(100);
                Console.Clear();

                GenerateNewObstacle(randomGenerator, level, obstacles, startRow, arrayCactuses);
            }
        }

        private static bool DinoJump(Dino dino, bool inJump, int startRow, ref int jumpCounter)
        {
            if (Console.KeyAvailable)
            {
                var pressedKey = Console.ReadKey();

                if (pressedKey.Key == ConsoleKey.Spacebar)
                {
                    dino.Y--;
                    inJump = true;
                }
            }

            if (inJump)
            {
                jumpCounter++;

                if (jumpCounter < 3)
                {
                    dino.Y -= jumpCounter;
                }
                else
                {
                    dino.Y += 5 - jumpCounter;
                }
            }

            if (jumpCounter == 6)
            {
                inJump = false;
                jumpCounter = 0;
                dino.Y = startRow;
            }
            return inJump;
        }

        private static void DisplayDino(Dino dino)
        {
            Console.SetCursorPosition(dino.X, dino.Y);
            Console.WriteLine(dino.dinoBody);
        }

        private static void DisplayWatch(Stopwatch watch)
        {
            Console.SetCursorPosition(Console.BufferWidth - 20, 10);
            Console.WriteLine(watch.ElapsedTicks/100000);
        }

        private static void GenerateNewObstacle(Random randomGenerator, int level, Queue<Obstacle> obstacles,
            int startRow,
            char[] obstacleChars)
        {
            if (randomGenerator.Next(0, 100) < level)
            {
                obstacles.Enqueue(new Obstacle
                {
                    X = Console.BufferWidth - 1,
                    Y = startRow,
                    cactusChar = obstacleChars[randomGenerator.Next(0, obstacles.Count)]
                });
            }
        }

        private static void MoveObstacles(Queue<Obstacle> obstacles)
        {
            if (obstacles.Any() && obstacles.Peek().X == 0)
            {
                obstacles.Dequeue();
            }

            foreach (var obstacle in obstacles)
            {
                if (obstacle.X < Console.BufferWidth && obstacle.Y < Console.BufferHeight)
                {
                    Console.SetCursorPosition(obstacle.X, obstacle.Y);

                    Console.Write("{0}", obstacle.cactusChar);

                    obstacle.X--;
                }
            }
        }
    }
}