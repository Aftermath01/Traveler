using System;

namespace Traveler.Entities
{
    public class RobotPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Orientation { get; set; }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as RobotPosition);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Orientation);
        }
    }
}
