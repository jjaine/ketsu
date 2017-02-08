﻿namespace Ketsu.Utils
{
    [System.Serializable]
    public class IntVector2
    {
        public static readonly IntVector2 Zero = new IntVector2(0, 0);
        public static readonly IntVector2 Left = new IntVector2(-1, 0);
        public static readonly IntVector2 Right = new IntVector2(1, 0);
        public static readonly IntVector2 Forward = new IntVector2(0, 1);
        public static readonly IntVector2 Back = new IntVector2(0, -1);

        public readonly int X;
        public readonly int Y;

        public IntVector2(int x, int y)
        {
            X = x;
            Y = y;
        }

        public IntVector2 Add(IntVector2 vector)
        {
            return new IntVector2(X + vector.X, Y + vector.Y);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            IntVector2 other = (IntVector2)obj;

            return (X == other.X && Y == other.Y);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            unchecked
            {
                hash = hash * 23 + X.GetHashCode();
                hash = hash * 23 + Y.GetHashCode();
            }
            return hash;
        }

        public override string ToString()
        {
            return "{" + X + ", " + Y + "}";
        }
    }
}