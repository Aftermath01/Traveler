using System;
using Traveler.Contracts;
using Traveler.Entities;

namespace Traveler.Operations
{
    public class RobotMover : IRobotMover
    {
        public void Move(Robot robot, char direction)
        {
            var step = EvaluateMovement(direction);

            _ = robot.Position.Orientation switch
            {
                'N' => robot.Position.Y -= step,
                'S' => robot.Position.Y += step,
                'W' => robot.Position.X -= step,
                'E' => robot.Position.X += step,
                _ => throw new Exception("Not supported move")
            };
        }

        protected int EvaluateMovement(char direction)
        {
            int result = 0;

            if (direction == 'F')
            {
                result = 1;
            }
            else if (direction == 'B')
            {
                result = -1;
            }

            return result;
        }
    }
}
