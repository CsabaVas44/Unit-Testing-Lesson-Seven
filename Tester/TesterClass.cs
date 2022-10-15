using MathFunction;
using NUnit.Framework;

namespace Tester
{
    [TestFixture]
    public class TesterClass
    {
        MathFunctions mf;

        [SetUp]
        public void Init()
        {
            mf = new MathFunctions();
        }

        [Test]
        public void AreaTest()
        {
            //ACT
            var result = mf.Area(5, 10);
            //ASSERT
            Assert.That(result, Is.EqualTo(50));
        }

        [Test]
        public void AreaTestNegative()
        {
            //ACT
            var result = mf.Area(5, -5);
            //ASSERT
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CirleAreaTest()
        {
            var result = mf.CircleArea(10);

            Assert.That(result, Is.EqualTo(100 * Math.PI));
        }
        [Test]
        public void MaxTest()
        {

            int result = mf.Max(20, 10);
            Assert.That(result, Is.EqualTo(20));
        }
    }

    /*
     Assert --> 1 db kimenet vizsgálata

        Assert.that(result,IsEqualto(42)
        Assert.That(result,IsNull)
        Assert.That(is.lessthan())
        isSameAs
        throws.nothing
        throws.[given exception]

    GYŰJTEMÉNYEK VIZSGÁLATA

        Tipikusan pl a Logic tesztje
            kapunk egy eredménylistát, egyezik-e az elvárt listával
        Gyűjtemények esetén az Nunit
            Minden elemen elvárja az Equals() és a GetHashCode() felülírását
            Ha egyezik minden azonos indexen a cucc, akkor a két gyűjtemény egyenlő

            Assert.AreaEqual(object a, object b) használható erre
        End.
     
     */


}