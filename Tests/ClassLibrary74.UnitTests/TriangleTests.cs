namespace ClassLibrary74.UnitTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(1, 5, 100)]
        public void Test_CreateTriangle_WhenTriangleCanNotExists(int a, int b, int c)
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Triangle(a, b, c);
            });
        }

        [Theory]
        [InlineData(1, 1, 1, 3)]
        [InlineData(3, 4, 5, 12)]
        [InlineData(9, 9, 9, 27)]
        public void Test_CalcPerimeter(int a, int b, int c, int perimeter)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);
            // Act & Assert
            Assert.Equal(perimeter, (int)triangle.CalcPerimeter());
        }

        [Theory]
        [InlineData(0, 1, 1, 3)]
        [InlineData(1, 0, 1, 3)]
        [InlineData(1, 1, 0, 3)]
        public void Test_CalcPerimeter_WhenOneOrMoreSidesIsInvalid(int a, int b, int c, int perimeter)
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Triangle(a, b, c);
                Assert.Equal(perimeter, (int)triangle.CalcPerimeter());
            });
        }

        [Theory]
        [InlineData(2, 2, 2, 1)]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5, 5, 5, 10)]
        public void Test_CalcArea(int a, int b, int c, int area)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);
            // Act & Assert
            Assert.Equal(area, (int)triangle.CalcArea());
        }

        [Theory]
        [InlineData(0, 1, 1, 3)]
        [InlineData(1, 0, 1, 3)]
        [InlineData(1, 1, 0, 3)]
        public void Test_CalcArea_WhenOneOrMoreSidesIsInvalid(int a, int b, int c, int area)
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Triangle(a, b, c);
                Assert.Equal(area, (int)triangle.CalcArea());
            });
        }
    }
}
