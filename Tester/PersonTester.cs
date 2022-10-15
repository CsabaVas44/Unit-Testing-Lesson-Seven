using MathCucc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    [TestFixture]
    public class PersonTester
    {
        [Test]
        public void YoungerTest()
        {
            //ARRANGE

            PersonLogic logic = new PersonLogic();
            //new Person("Béla", 43),
            //new Person("Héza", 25),
            //new Person("Kati", 20),
            var expected = new List<Person>()
            {
                new Person("Béla", 43),
                new Person("Héza", 25),
                new Person("Kati", 20),
            };

            //ACT
            var actual = logic.YoungerThan45();

            //ASSERT
            Assert.AreEqual(expected, actual);

        }
    }
}
