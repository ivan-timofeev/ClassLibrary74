namespace ClassLibrary74.UnitTests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(1, 6)]
        [InlineData(2, 12)]
        [InlineData(10, 62)]
        public void Test_CalcPerimeter(int radius, int perimeter)
        {
            // Arrange
            var circle = new Circle(radius);
            // Act & Assert
            Assert.Equal(perimeter, (int)circle.CalcPerimeter());
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(-1, 1)]
        [InlineData(-100, 1)]
        public void Test_CalcPerimeter_WhenRadiusIsInvalid(int radius, int perimeter)
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() =>
            {
                var circle = new Circle(radius);
                Assert.Equal(perimeter, (int)circle.CalcPerimeter());
            });
        }

        [Theory]
        [InlineData(1, 3)]
        [InlineData(2, 12)]
        [InlineData(10, 314)]
        public void Test_CalcArea(int radius, int area)
        {
            // Arrange
            var circle = new Circle(radius);
            // Act & Assert
            Assert.Equal(area, (int)circle.CalcArea());
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(-1, 1)]
        [InlineData(-100, 1)]
        public void Test_CalcArea_WhenRadiusIsInvalid(int radius, int area)
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() =>
            {
                var circle = new Circle(radius);
                Assert.Equal(area, (int)circle.CalcArea());
            });
        }
    }
}
