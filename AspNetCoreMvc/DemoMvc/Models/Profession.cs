using System;
namespace DemoMvc.Models
{
	public class Profession
	{
		static int count = 0;
		public Profession(string name)
		{
			Id = ++count;
			Name = name;
		}

		public int Id { get; set; }

		public string Name { get; set; }
	}
}

