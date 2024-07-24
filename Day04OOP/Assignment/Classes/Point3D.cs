using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{

    public class Point3D : IComparable<Point3D>, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D() { }

        public Point3D(int x) : this(x, 0, 0) { }
        public Point3D(int x, int y) : this(x, y, 0) { }
        public Point3D(int x, int y, int z)
        {
            this.X = x;

            this.Y = y;

            this.Z = z;
        }
        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Point3D points = (Point3D)obj;
            return (X == points.X) && (Y == points.Y) && (Z == points.Z);
        }

        public int CompareTo(Point3D? other)
        {
            if (X != other.X)
                return X.CompareTo(other.X);
            if (Y != other.Y)
                return Y.CompareTo(other.Y);
            return Z.CompareTo(other.Z);
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        public static bool operator ==(Point3D left, Point3D right)
        {
            return Equals(left, right);
        }
        //require !=
        public static bool operator !=(Point3D left, Point3D right)
        {
            return !Equals(left, right);
        }
    }
}
