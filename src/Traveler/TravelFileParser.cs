using System.Collections.Generic;
using System.Linq;
using Traveler.Contracts;
using Traveler.Entities;

namespace Traveler
{
    public class TravelFileParser : ITravelFileParser
    {
        private readonly IRobotCreator _robotCreator;

        public TravelFileParser()
        {
            _robotCreator = new RobotCreator();
        }

        public List<Robot> ParseMoves(string fileContent)
        {
            List<Robot> result = new List<Robot>();

            List<string> lines = fileContent.Split(new char[] { '\n', '\r' }, System.StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].StartsWith(Constants.PosString))
                {
                    var currentLine = lines[i];

                    List<char> robotMoves = GetMoves(lines, i);

                    var Robot = _robotCreator.CreateFromLines(currentLine, robotMoves);
                    result.Add(Robot);
                }
            }

            return result;
        }

        protected List<char> GetMoves(List<string> lines, int index)
        {
            var result = new List<char>();

            if (index < lines.Count - 1)
            {
                int movesLineIndex = index + 1;

                string movesLine = string.IsNullOrEmpty(lines[movesLineIndex]) ? string.Empty : lines[movesLineIndex];

                if (movesLine.StartsWith("//") || movesLine.StartsWith(Constants.PosString))
                {
                    return result;
                }

                result.AddRange(movesLine.ToCharArray().ToList());

                if (movesLineIndex + 1 <= lines.Count - 1)
                {
                    result.AddRange(GetMoves(lines, movesLineIndex));
                }
            }

            return result;
        }
    }
}
