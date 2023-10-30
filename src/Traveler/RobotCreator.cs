using System.Collections.Generic;
using Traveler.Contracts;
using Traveler.Entities;

namespace Traveler
{
    public class RobotCreator : IRobotCreator
    {
        public Robot CreateFromLines(string locationLine, List<char> robotMoves)
        {
            var robotInfo = locationLine.Replace(Constants.PosString, string.Empty).Trim();

            var robotInfoSplit = robotInfo.Split(',');

            var robot = new Robot()
            {
                Position = new RobotPosition()
                {
                    X = int.Parse(robotInfoSplit[0]),
                    Y = int.Parse(robotInfoSplit[1]),
                    Orientation = char.Parse(robotInfoSplit[2])
                },
                Moves = robotMoves
            };

            return robot;
        }
    }
}
