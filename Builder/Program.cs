using System;

namespace Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RobotBuilder oldStyleRobot = new OldRobotBuilder();

            var robotEngineer = new RobotEngineer(oldStyleRobot);

            robotEngineer.MakeRobot();

            var robot = robotEngineer.GetRobot();

            Console.WriteLine(robot.Head);
            Console.WriteLine(robot.Torso);
            Console.WriteLine(robot.Arms);
            Console.WriteLine(robot.Legs);
        }
    }
}
