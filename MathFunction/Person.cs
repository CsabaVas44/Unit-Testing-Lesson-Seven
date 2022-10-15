using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCucc
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object? obj)
        {
            Person b = obj as Person;
            if (b == null)
            {
                return false;
            }
            else
            {
                return this.Name == b.Name && this.Age == b.Age;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Name, this.Age);
        }
    }
}
