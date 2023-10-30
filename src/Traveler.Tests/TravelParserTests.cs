using Shouldly;
using Xunit;

namespace Traveler.Tests
{
    public class TravelParserTests
    {
        [Fact]
        public void Should_Run_Single_Scenario_With_Expected_Outcome()
        {
            // Given
            var input = "POS=0,0,E\r\nFFFRFFF";

            // When
            var result = TravelParser.Run(input);

            // Then
            result.Length.ShouldBe(1);

            result[0].Position.X.ShouldBe(3);
            result[0].Position.Y.ShouldBe(3);
            result[0].Position.Orientation.ShouldBe('S');
        }

        [Fact]
        public void Should_Run_Multiple_Scenarios_With_Expected_Outcome()
        {
            // Given
            var input = "POS=0,0,E\r\nFFFRFFF\r\nPOS=6,4,W\r\nBLFLFFFFFRFRFLFL\r\nBLBLBRBL\r\nPOS=1,1,N";

            // When
            var result = TravelParser.Run(input);

            // Then
            result.Length.ShouldBe(3);

            result[0].Position.X.ShouldBe(3);
            result[0].Position.Y.ShouldBe(3);
            result[0].Position.Orientation.ShouldBe('S');

            result[1].Position.X.ShouldBe(11);
            result[1].Position.Y.ShouldBe(9);
            result[1].Position.Orientation.ShouldBe('W');

            result[2].Position.X.ShouldBe(1);
            result[2].Position.Y.ShouldBe(1);
            result[2].Position.Orientation.ShouldBe('N');
        }

        [Fact]
        public void Should_Not_Require_Operations()
        {
            // Given
            var input = "POS=1,1,N";

            // When
            var result = TravelParser.Run(input);

            // Then
            result.Length.ShouldBe(1);

            result[0].Position.X.ShouldBe(1);
            result[0].Position.Y.ShouldBe(1);
            result[0].Position.Orientation.ShouldBe('N');
        }

        [Fact]
        public void Should_Support_Single_Line_Feed_As_Separator()
        {
            // Given
            var input = "POS=0,0,E\nFFFRFFF";

            // When
            var result = TravelParser.Run(input);

            // Then
            result.Length.ShouldBe(1);

            result[0].Position.X.ShouldBe(3);
            result[0].Position.Y.ShouldBe(3);
            result[0].Position.Orientation.ShouldBe('S');
        }

        [Fact]
        public void Should_Support_Comments()
        {
            // Given
            var input = "//Hello World\r\nPOS=0,0,E\r\nFFFRFFF";

            // When
            var result = TravelParser.Run(input);

            // Then
            result.Length.ShouldBe(1);

            result[0].Position.X.ShouldBe(3);
            result[0].Position.Y.ShouldBe(3);
            result[0].Position.Orientation.ShouldBe('S');
        }
    }
}
