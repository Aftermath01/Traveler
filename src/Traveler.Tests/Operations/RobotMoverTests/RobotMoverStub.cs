using Traveler.Operations;

namespace Traveler.Tests.Operations.RobotMoverTests
{
    public class RobotMoverStub : RobotMover
    {
        public new int EvaluateMovement(char direction)
        {
            return base.EvaluateMovement(direction);
        }
    }
}
