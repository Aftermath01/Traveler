using Traveler.Entities;
using Traveler.Operations;

namespace Traveler.Tests.Operations.RobotRotatorTests
{
    public class RobotRotatorStub : RobotRotator
    {
        public new void RotateLeft(Robot robot)
        {
            base.RotateLeft(robot);
        }

        public new void RotateRight(Robot robot)
        {
            base.RotateRight(robot);
        }
    }
}
