using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Library
{
    internal class Person : IComparable
    {
        public Person(string name)
        {
            this.Name = name;
            this.Age = -1;
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            if (Age == -1) {
                return Name;
            }
            return Name + ", " + Age;
        }
        public int CompareTo(object obj)
        {
            var other = (Person) obj;
            return string.Compare(Name, other.Name, StringComparison.Ordinal);
        }
    }
}