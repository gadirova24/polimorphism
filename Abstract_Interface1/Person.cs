using System;
namespace Abstract_Interface1
{
    internal class Person
    {
        public readonly string Test;
        public const string A = "asjdakshd";
        public int Id { get; init; } = 1;
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person()
        {

            //Test = "blah blah blah";
        }
        public Person(int id)
        {
            Id = id;
        }
        public override string ToString()
        {
            return $"{Id} {Name} {Surname}";
        }
    }
}

