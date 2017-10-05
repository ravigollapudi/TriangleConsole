using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleConsole
{
    public enum TriangleType
    {
        Equilateral = 3, // all sides are the same length
        Isosceles = 2, // two sides are the same length and one differs
        Scalene = 1, // no two sides are the same length
        NotATriangle = 4 // inputs can't produce a triangle
    }

    /// <summary>
    /// This method accepts three inputs and determine the Triangletype  
    /// </summary>
    public static class TriangleHelper
    {
        public static TriangleType GetTriangleType(double lengthA, double lengthB, double lengthC)
        {
            // If any of the lengths are zero, return Not a triangle
            if (lengthA <= 0 || lengthB <= 0 || lengthC <= 0)
                return TriangleType.NotATriangle;

            if (lengthA == lengthB && lengthA == lengthC)
            {
                // all three sides are equal.
                return TriangleType.Equilateral;
            }
            else if (lengthA == lengthB || lengthB == lengthC || lengthA == lengthC)
            {
                // Isoceles - 2 sides
                return TriangleType.Isosceles;
            }
            else
            {
                return TriangleType.Scalene;
            }
        }
    }
}
