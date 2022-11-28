using System;
namespace DemoMvc.Models
{
	public class Person
	{
        static private int _count = 1;

        public Person(string name, string surname)
        {
            this.Id = _count;
            _count++;
            this.Name = name;
            this.Surname = surname;
        }

		public int Id { get; }

		public string Name { get; set; }

        public string Surname { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}

