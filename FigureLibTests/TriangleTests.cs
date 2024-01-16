using FigureLib;

namespace FigureLibTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void ShouldReturnSquare()
        {
            var triangle = new Triangle(5, 8.5, 5);

            double expectedSquare = 11.194132112406034;
            double actualSquare = triangle.GetSquare();

            Assert.AreEqual(expectedSquare, actualSquare);
        }

        [TestMethod]
        public void ShouldReturnSquareForRightAngled()
        {
            var triangle = new Triangle(3, 4, 5);

            double expectedSquare = 6;
            double actualSquare = triangle.GetSquare();

            Assert.AreEqual(triangle.IsRightAngled, true);
            Assert.AreEqual(expectedSquare, actualSquare);
        }

        [TestMethod]
        public void ShouldReturnSquareForNotRightAngled()
        {
            var triangle = new Triangle(5, 8, 5);

            double expectedSquare = 12;
            double actualSquare = triangle.GetSquare();

            Assert.AreEqual(triangle.IsRightAngled, false);
            Assert.AreEqual(expectedSquare, actualSquare);
        }

        [TestMethod]
        public void ShouldThrowException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, -8, 5));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, 0, 5));

            var triangle = new Triangle(5, 8, 5);
            Assert.ThrowsException<ArgumentException>(() => triangle.Ñatheter1 = -8);
            Assert.ThrowsException<ArgumentException>(() => triangle.Hypotenuse = 0);

        }
    }
}