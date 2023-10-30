using Traveler.Entities;

namespace Traveler.Contracts
{
    public interface IRobotMover
    {
        void Move(Robot robot, char direction);
    }
}
