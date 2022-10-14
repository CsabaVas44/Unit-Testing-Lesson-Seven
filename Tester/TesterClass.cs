using MathFunction;
using NUnit.Framework;

namespace Tester
{
    [TestFixture]
    public class TesterClass
    {
        [Test]
        public void AreaTest()
        {
            //ARRANGE
            MathFunctions mf = new MathFunctions();
            //ACT
            var result = mf.Area(5, 10);
            //ASSERT
            Assert.That(result, Is.EqualTo(50));
        }

        [Test]
        public void AreaTestNegative()
        {
            //ARRANGE
            MathFunctions mf = new MathFunctions();
            //ACT
            var result = mf.Area(5, -5);
            //ASSERT
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CirleAreaTest()
        {
            MathFunctions mf = new MathFunctions();

            var result = mf.CircleArea(10);

            Assert.That(result, Is.EqualTo(100 * Math.PI));
        }
        [Test]
        public void MaxTest()
        {
            MathFunctions mf = new MathFunctions();

            int result = mf.Max(20, 10);
            Assert.That(result, Is.EqualTo(20));
        }
    }
}