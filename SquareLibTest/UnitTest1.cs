using GeometricShapeLib;
using System.Net.Http.Headers;
using System.Net.WebSockets;

namespace SquareLibTest
{
    public class Tests
    {
        public static double Delta = 0.0001;

        [Test]
        public void TestTriangleSquare()
        {
            var t1 = new Triangle(3, 4, 5);
            var t2 = new Triangle(27, 28, 29);
            var t4 = new Triangle(10, 20, 15);
            var t8 = new Triangle(16, 37, 40);
            Assert.That(t1.GetArea(), Is.EqualTo(6).Within(Delta));
            Assert.That(t2.GetArea(), Is.EqualTo(338.6148).Within(Delta));
            Assert.That(t4.GetArea(), Is.EqualTo(72.6184).Within(Delta));
            Assert.That(t8.GetArea(), Is.EqualTo(295.934).Within(Delta));
        }

        [Test]
        public void TestIsRectangular()
        {
            var t1 = new Triangle(3, 4, 5);
            var t2 = new Triangle(6, 10, 8);
            var t3 = new Triangle(5, 12, 13);
            var t4 = new Triangle(7, 24, 25);
            var t5 = new Triangle(9, 40, 41);
            var t6 = new Triangle(61, 60, 11);
            Assert.IsTrue(t1.IsRectangular());
            Assert.IsTrue(t2.IsRectangular());
            Assert.IsTrue(t3.IsRectangular());
            Assert.IsTrue(t4.IsRectangular());
            Assert.IsTrue(t5.IsRectangular());
            Assert.IsTrue(t6.IsRectangular());
        }

        [Test]
        public void TestInitTriangle()
        {
            try 
            {
                new Triangle(0, 10, 10);
                Assert.Fail();
            }
            catch { }
            try
            {
                new Triangle(25, 50, 25);
                Assert.Fail();
            }
            catch { }
            try
            {
                new Triangle(-1, 12, 1);
                Assert.Fail();
            }
            catch { }
            try
            {
                new Triangle(10, -1, 12);
                Assert.Fail();
            }
            catch { }
            try
            {
                new Triangle(12, 10, -1);
                Assert.Fail();
            }
            catch { }
            try
            {
                new Triangle(10, 10, 20);
                Assert.Fail();
            }
            catch { }
            try
            {
                new Triangle(35, 15, 15);
                Assert.Fail();
            }
            catch { }
        }
        [Test]
        public void TestInitCircle()
        {
            try
            {
                new Circle(0);
                Assert.Fail();
            }
            catch { }
            try
            {
                new Circle(-1);
                Assert.Fail();
            }
            catch { }
            try
            {
                new Circle(-0.00001);
                Assert.Fail();
            }
            catch { }
        }

        [Test]
        public void TestCircleSquere()
        {
            var c1 = new Circle(10);
            var c2 = new Circle(15.8);
            var c3 = new Circle(127);
            var c4 = new Circle(874.875);
            var c5 = new Circle(112345.54321);
            Assert.That(c1.GetArea(), Is.EqualTo(314.159265).Within(Delta));
            Assert.That(c2.GetArea(), Is.EqualTo(784.26719).Within(Delta));
            Assert.That(c3.GetArea(), Is.EqualTo(50670.74791).Within(Delta));
            Assert.That(c4.GetArea(), Is.EqualTo(2404594.701099).Within(Delta));
            Assert.That(c5.GetArea(), Is.EqualTo(39651677899.38629).Within(Delta));
        }
    }
}