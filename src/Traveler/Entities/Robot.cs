using System;
using System.Collections.Generic;

namespace Traveler.Entities
{
    public class Robot
    {
        public RobotPosition Position { get; set; }

        public List<char> Moves { get; set; }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Robot);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Position, Moves);
        }
    }
}
