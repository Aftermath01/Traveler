using Traveler.Entities;

namespace Traveler.Contracts
{
    public interface IRobotRotator
    {
        void Rotate(Robot robot, char direction);
    }
}
