using System.Collections.Generic;
using Traveler.Entities;

namespace Traveler.Contracts
{
    public interface ITravelFileParser
    {
        List<Robot> ParseMoves(string fileContent);
    }
}
