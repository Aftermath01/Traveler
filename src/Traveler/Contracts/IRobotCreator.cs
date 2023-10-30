using System.Collections.Generic;
using Traveler.Entities;

namespace Traveler.Contracts
{
    public interface IRobotCreator
    {
        Robot CreateFromLines(string locationLine, List<char> robotMoves);
    }
}
