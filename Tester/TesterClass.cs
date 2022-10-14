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

            //lehet egysorban is kivételkezeléses tesztet csinálni
            Assert.That(() => mf.CircleArea(10), Throws.TypeOf<ArgumentException>());
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