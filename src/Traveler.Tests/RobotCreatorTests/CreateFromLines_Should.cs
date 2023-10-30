using System.Collections.Generic;
using Shouldly;
using Traveler.Contracts;
using Traveler.Entities;
using Xunit;

namespace Traveler.Tests.RobotCreatorTests
{
    public class CreateFromLines_Should
    {
        [Fact]
        public void Return_ACorrectRobotWith00EAndNoMoves()
        {
            var expecterRobot = new Robot()
            {
                Position = new RobotPosition()
                {
                    X = 0,
                    Y = 0,
                    Orientation = 'E'
                },
                Moves = new List<char>()
            };

            IRobotCreator creator = new RobotCreator();

            var robot = creator.CreateFromLines("POS=0,0,E", new List<char>());

            robot.Position.X.ShouldBe(expecterRobot.Position.X);
            robot.Position.Y.ShouldBe(expecterRobot.Position.Y);
            robot.Position.Orientation.ShouldBe(expecterRobot.Position.Orientation);
            robot.Moves.ShouldBe(expecterRobot.Moves);
        }

        [Fact]
        public void Return_ACorrectRobotWith38WAndNoMoves()
        {
            var expecterRobot = new Robot()
            {
                Position = new RobotPosition()
                {
                    X = 3,
                    Y = 8,
                    Orientation = 'W'
                },
                Moves = new List<char>()
            };

            IRobotCreator creator = new RobotCreator();

            var robot = creator.CreateFromLines("POS=3,8,W", new List<char>());

            robot.Position.X.ShouldBe(expecterRobot.Position.X);
            robot.Position.Y.ShouldBe(expecterRobot.Position.Y);
            robot.Position.Orientation.ShouldBe(expecterRobot.Position.Orientation);
            robot.Moves.ShouldBe(expecterRobot.Moves);
        }

        [Fact]
        public void Return_ACorrectRobotWith38WAndMoves()
        {
            var expecterRobot = new Robot()
            {
                Position = new RobotPosition()
                {
                    X = 3,
                    Y = 8,
                    Orientation = 'W'
                },
                Moves = new List<char>() { 'F', 'B' }
            };

            IRobotCreator creator = new RobotCreator();

            var robot = creator.CreateFromLines("POS=3,8,W", new List<char>() { 'F', 'B' });

            robot.Position.X.ShouldBe(expecterRobot.Position.X);
            robot.Position.Y.ShouldBe(expecterRobot.Position.Y);
            robot.Position.Orientation.ShouldBe(expecterRobot.Position.Orientation);
            robot.Moves.ShouldBe(expecterRobot.Moves);
        }
    }
}
