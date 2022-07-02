using ClassLibrary74.Interfaces;

namespace ClassLibrary74
{
    /// <summary>
    /// Represents an immutable Circle class
    /// </summary>
    public class Circle : ICircle
    {
        /// <summary>
        /// Circle radius
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be a positive number");

            Radius = radius;
        }

        /// <summary>
        /// Calculates the perimeter
        /// </summary>
        public double CalcPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        /// <summary>
        /// Calculates the Area
        /// </summary>
        public double CalcArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
