using Shouldly;
using Xunit;

namespace Traveler.Tests.TravelFileParserTests
{
    public class ParseMoves_Should
    {
        [Fact]
        public void ReturnCorrectRobbotWithMoves()
        {
            var travelFileParserStub = new TravelFileParserStub();

            var input = "POS=0,0,E\nFFFRFFF";

            var robots = travelFileParserStub.ParseMoves(input);

            // Then
            robots.Count.ShouldBe(1);

            robots[0].Position.X.ShouldBe(0);
            robots[0].Position.Y.ShouldBe(0);
            robots[0].Position.Orientation.ShouldBe('E');

            robots[0].Moves.Count.ShouldBe(7);
        }
    }
}
