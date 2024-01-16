using FigureLib;

namespace FigureLibTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void ShouldReturnSquare()
        {
            var circle = new Circle(3);

            double expectedSquare = 28.274333882308138;
            double actualSquare = circle.GetSquare();

            Assert.AreEqual(expectedSquare, actualSquare);
        }

        [TestMethod]
        public void ShouldReturnSquare2()
        {
            var circle = new Circle(4.4);

            double expectedSquare = 60.821233773498406;
            double actualSquare = circle.GetSquare();

            Assert.AreEqual(expectedSquare, actualSquare);
        }

        [TestMethod]
        public void ShouldThrowException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-5));

            Assert.ThrowsException<ArgumentException>(() => new Circle(0));

            var circle = new Circle(5);
            Assert.ThrowsException<ArgumentException>(() => circle.Radius = -5);
            Assert.ThrowsException<ArgumentException>(() => circle.Radius = 0);
        }
    }
}