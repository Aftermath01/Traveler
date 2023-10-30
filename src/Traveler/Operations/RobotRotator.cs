using System;
using System.Collections.Generic;
using Traveler.Contracts;
using Traveler.Entities;

namespace Traveler.Operations
{
    public class RobotRotator : IRobotRotator
    {
        public readonly Dictionary<char, Action<Robot>> _rotators;

        public RobotRotator()
        {
            _rotators = new Dictionary<char, Action<Robot>>
            {
                { 'L', (Robot robot) => RotateLeft(robot) },
                { 'R', (Robot robot) => RotateRight(robot) }
            };
        }

        public void Rotate(Robot robot, char direction)
        {
            if (_rotators.ContainsKey(direction))
            {
                _rotators[direction].Invoke(robot);
            }
        }

        protected void RotateLeft(Robot robot)
        {
            _ = robot.Position.Orientation switch
            {
                'N' => robot.Position.Orientation = 'W',
                'S' => robot.Position.Orientation = 'E',
                'W' => robot.Position.Orientation = 'S',
                'E' => robot.Position.Orientation = 'N',
                _ => throw new Exception("Not supported rotation")
            };
        }

        protected void RotateRight(Robot robot)
        {
            _ = robot.Position.Orientation switch
            {
                'N' => robot.Position.Orientation = 'E',
                'S' => robot.Position.Orientation = 'W',
                'W' => robot.Position.Orientation = 'N',
                'E' => robot.Position.Orientation = 'S',
                _ => throw new Exception("Not supported rotation")
            };
        }
    }
}
