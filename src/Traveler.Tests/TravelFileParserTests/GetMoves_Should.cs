using System.Collections.Generic;
using Shouldly;
using Xunit;

namespace Traveler.Tests.TravelFileParserTests
{
    public class GetMoves_Should
    {
        private readonly TravelFileParserStub _travelFileParserStub;

        public GetMoves_Should()
        {
            _travelFileParserStub = new TravelFileParserStub();
        }

        [Fact]
        public void Return0Moves_When_ThereAreNoLines()
        {
            List<string> lines = new List<string>()
            {
                "",
                ""
            };

            var expectedMoves = _travelFileParserStub.GetMoves(lines, 0);
            expectedMoves.Count.ShouldBe(0);
        }

        [Fact]
        public void Return14Moves_When_ThereAre3Lines()
        {
            List<string> lines = new List<string>()
            {
                "POS=0,0,E",
                "FFFBLRFFF",
                "FFBLR"
            };

            var expectedMoves = _travelFileParserStub.GetMoves(lines, 0);
            expectedMoves.Count.ShouldBe(14);
        }

        [Fact]
        public void Return14Moves_When_ThereAre4LinesAndComment()
        {
            List<string> lines = new List<string>()
            {
                "// first line",
                "POS=0,0,E",
                "FFFBLRFFF",
                "FFBLR"
            };

            var expectedMoves = _travelFileParserStub.GetMoves(lines, 1);
            expectedMoves.Count.ShouldBe(14);
        }

        [Fact]
        public void Return9Moves_When_ThereAre4LinesAndComment()
        {
            List<string> lines = new List<string>()
            {
                "// first line",
                "POS=0,0,E",
                "FFFBLRFFF"
            };

            var expectedMoves = _travelFileParserStub.GetMoves(lines, 1);
            expectedMoves.Count.ShouldBe(9);
        }
    }
}
