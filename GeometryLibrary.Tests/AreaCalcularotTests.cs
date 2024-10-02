using Xunit;

namespace GeometryLibrary.Tests
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void Circle_CalculateArea_ShouldReturnCorrectArea()
        {
            // Arrange
            Circle circle = new Circle(5);

            // Act
            double area = AreaCalculator.CalculateArea(circle);

            // Assert
            Assert.Equal(Math.PI * 25, area);
        }

        [Fact]
        public void Triangle_CalculateArea_ShouldReturnCorrectArea()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // Act
            double area = AreaCalculator.CalculateArea(triangle);

            // Assert
            Assert.Equal(6, area);
        }

        [Fact]
        public void Triangle_IsRightTriangle_ShouldReturnTrueForRightTriangle()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.True(isRightTriangle);
        }

        [Fact]
        public void Triangle_IsRightTriangle_ShouldReturnFalseForNonRightTriangle()
        {
            // Arrange
            Triangle triangle = new Triangle(2, 3, 4);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.False(isRightTriangle);
        }
    }
}

