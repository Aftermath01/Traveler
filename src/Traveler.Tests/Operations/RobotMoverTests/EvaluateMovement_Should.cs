using Shouldly;
using Xunit;

namespace Traveler.Tests.Operations.RobotMoverTests
{
    public class EvaluateMovement_Should
    {
        [Fact]
        public void Return1_When_Forward()
        {
            var robotMoverStub = new RobotMoverStub();

            int step = robotMoverStub.EvaluateMovement('F');

            step.ShouldBe(1);
        }

        [Fact]
        public void ReturnMinus1_When_Forward()
        {
            var robotMoverStub = new RobotMoverStub();

            int step = robotMoverStub.EvaluateMovement('B');

            step.ShouldBe(-1);
        }
    }
}
