using System;
using System.Collections.Generic;
using System.Text;

namespace Object
{
    class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Person person = (Person)obj;
            return (this.Name == person.Name);
        }
    }
}
