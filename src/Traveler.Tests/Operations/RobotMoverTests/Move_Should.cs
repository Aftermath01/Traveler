using Shouldly;
using Traveler.Entities;
using Xunit;

namespace Traveler.Tests.Operations.RobotMoverTests
{
    public class Move_Should
    {
        [Fact]
        public void MoveXForward_When_ForwardAndOrientationE()
        {
            var robotMoverStub = new RobotMoverStub();

            var robot = new Robot()
            {
                Position = new RobotPosition()
                {
                    X = 1,
                    Y = 2,
                    Orientation = 'E'
                }
            };

            robotMoverStub.Move(robot, 'F');

            robot.Position.X.ShouldBe(2);
        }

        [Fact]
        public void MoveYForward_When_ForwardAndOrientationS()
        {
            var robotMoverStub = new RobotMoverStub();

            var robot = new Robot()
            {
                Position = new RobotPosition()
                {
                    X = 1,
                    Y = 2,
                    Orientation = 'S'
                }
            };

            robotMoverStub.Move(robot, 'F');

            robot.Position.Y.ShouldBe(3);
        }
    }
}
