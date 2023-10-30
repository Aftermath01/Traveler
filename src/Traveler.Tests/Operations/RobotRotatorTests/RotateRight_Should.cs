using Shouldly;
using Traveler.Entities;
using Xunit;

namespace Traveler.Tests.Operations.RobotRotatorTests
{
    public class RotateRight_Should
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

            robotRotatorStub.RotateRight(robot);

            robot.Position.Orientation.ShouldBe('S');
        }
    }
}
