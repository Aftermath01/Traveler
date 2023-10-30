using Shouldly;
using Traveler.Entities;
using Xunit;

namespace Traveler.Tests.Operations.RobotRotatorTests
{
    public class Rotate_Should
    {
        [Fact]
        public void CorrectDirection_When_RotateRight()
        {
            var robotRotatorStub = new RobotRotatorStub();

            var robot = new Robot()
            {
                Position = new RobotPosition()
                {
                    X = 1,
                    Y = 2,
                    Orientation = 'E'
                }
            };

            robotRotatorStub.Rotate(robot, 'R');

            robot.Position.Orientation.ShouldBe('S');
        }

        [Fact]
        public void CorrectDirection_When_RotateLeft()
        {
            var robotRotatorStub = new RobotRotatorStub();

            var robot = new Robot()
            {
                Position = new RobotPosition()
                {
                    X = 1,
                    Y = 2,
                    Orientation = 'E'
                }
            };

            robotRotatorStub.Rotate(robot, 'L');

            robot.Position.Orientation.ShouldBe('N');
        }
    }
}
