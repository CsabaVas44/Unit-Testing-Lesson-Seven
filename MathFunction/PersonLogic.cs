using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCucc
{
    public class PersonLogic
    {
        List<Person> people;

        public PersonLogic()
        {
            people = new List<Person>()
            {
                new Person("Béla",43),
                new Person("Héza",25),
                new Person("Kati",20),
                new Person("Irén",66),
                new Person("Feri",55),
            };
        }

        public IEnumerable<Person> YoungerThan45()
        {
            return people.Where(t => t.Age <= 45);
        }
    }
}
