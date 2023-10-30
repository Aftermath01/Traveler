using Shouldly;
using Traveler.Entities;
using Xunit;

namespace Traveler.Tests.Operations.RobotRotatorTests
{
    public class RotateLeft_Should
    {
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

            robotRotatorStub.RotateLeft(robot);

            robot.Position.Orientation.ShouldBe('N');
        }
    }
}
