using System.Collections.Generic;

namespace Traveler.Tests.TravelFileParserTests
{
    public class TravelFileParserStub : TravelFileParser
    {
        public new List<char> GetMoves(List<string> lines, int index)
        {
            return base.GetMoves(lines, index);
        }
    }
}
