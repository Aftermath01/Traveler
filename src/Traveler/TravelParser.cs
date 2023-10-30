using System.Collections.Generic;
using Traveler.Contracts;
using Traveler.Entities;
using Traveler.Operations;

namespace Traveler
{
    public static class TravelParser
    {
        public static Robot[] Run(string input)
        {
            ITravelFileParser travelFileParser = new TravelFileParser();
            IRobotMover robotMover = new RobotMover();
            IRobotRotator robotRotator = new RobotRotator();

            List<Robot> robots = travelFileParser.ParseMoves(input);

            foreach (Robot robot in robots)
            {
                foreach (char moveOrRotate in robot.Moves)
                {
                    robotMover.Move(robot, moveOrRotate);
                    robotRotator.Rotate(robot, moveOrRotate);
                }
            }

            return robots.ToArray();
        }
    }
}
