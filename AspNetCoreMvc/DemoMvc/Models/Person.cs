using System;
namespace DemoMvc.Models
{
	public class Person
	{
        static private int count = 0;

        public Person()
        {
            this.Id = ++count;
        }

		public int Id { get; }

		public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public int ProfessionId { get; set; }

        public Profession Profession { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname} - {Age}";
        }
    }
}

