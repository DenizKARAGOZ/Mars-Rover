using System;

namespace marsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Position firstPosition = new Position();
            firstPosition.x = 1;
            firstPosition.y = 2;
            RoboticRover firstRoboticRover = new RoboticRover(firstPosition, Directions.N);
            firstRoboticRover.Start("LMLMLMLMM");

            Position secondPosition = new Position();
            secondPosition.x = 3;
            secondPosition.y = 3;
            RoboticRover secondRoboticRover = new RoboticRover(secondPosition, Directions.E);
            secondRoboticRover.Start("MMRMMRMRRM");

            string result = "First Result : " + firstRoboticRover.GetResult() + " ///////////// " + "Second Result : " + secondRoboticRover.GetResult();

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}