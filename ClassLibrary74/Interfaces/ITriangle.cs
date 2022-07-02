namespace ClassLibrary74.Interfaces
{
    /// <summary>
    /// Provides a triangle interface
    /// </summary>
    public interface ITriangle : IFigure
    {
        /// <summary>
        /// Checks whether the triangle is rectangular
        /// </summary>
        public bool IsRectangleTriangle();
    }
}
