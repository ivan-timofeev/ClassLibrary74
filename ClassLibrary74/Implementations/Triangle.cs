using ClassLibrary74.Interfaces;

namespace ClassLibrary74
{
    /// <summary>
    /// Represents an immutable Triangle class
    /// </summary>
    public class Triangle : ITriangle
    {
        /// <summary>
        /// The first side of the triangle
        /// </summary>
        public double SideA { get; }
        /// <summary>
        /// The second side of the triangle
        /// </summary>
        public double SideB { get; }
        /// <summary>
        /// The third side of the triangle
        /// </summary>
        public double SideC { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class
        /// </summary>
        /// <param name="sideA">The first side of the triangle. Must be positive</param>
        /// <param name="sideB">Second side of triangle. Must be positive</param>
        /// <param name="sideC">Third side of triangle. Must be positive</param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0)
                throw new ArgumentException("SideA must be a positive number");
            if (sideB <= 0)
                throw new ArgumentException("SideB must be a positive number");
            if (sideC <= 0)
                throw new ArgumentException("SideC must be a positive number");

            if (sideA + sideB <= sideC
                || sideA + sideC <= sideB
                || sideB + sideC <= sideA)
                throw new ArgumentException("Triangle with such sides cannot exist");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Calculates the perimeter
        /// </summary>
        public double CalcPerimeter()
        {
            return SideA + SideB + SideC;
        }

        /// <summary>
        /// Calculates the Area
        /// </summary>
        public double CalcArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        /// <summary>
        /// Checks whether the triangle is rectangular
        /// </summary>
        public bool IsRectangleTriangle()
        {
            bool predicate1 = Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2);
            bool predicate2 = Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2);
            bool predicate3 = Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2);

            return predicate1 || predicate2 || predicate3;
        }
    }
}
