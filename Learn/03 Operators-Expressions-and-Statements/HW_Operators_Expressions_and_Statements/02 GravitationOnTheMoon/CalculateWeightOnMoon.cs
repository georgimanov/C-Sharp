// Problem 2.	Gravitation on the Moon
// The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth. Examples:
//weight   |weight on the Moon
//86	   |14.62
//74.6	   |12.682
//53.7	   |9.129



using System;
    class CalculateWeightOnMoon
    {
        static void Main(string[] args)
        {
            float inputNumber = float.Parse(Console.ReadLine()); //read number from console input
            float weightOnMoon = inputNumber * 17 / 100; //calculate weight on the moon by the given number
            Console.WriteLine("The weight of a man on the moon, who weighs {0} on the Earth is {1:0.00}", 
                inputNumber, weightOnMoon); //print result
        }
    }