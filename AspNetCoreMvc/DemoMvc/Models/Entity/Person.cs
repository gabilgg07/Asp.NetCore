using System;
using System.ComponentModel.DataAnnotations;
using DemoMvc.AppCode.Attributes.Validations;

namespace DemoMvc.Models.Entity
{
	public class Person
	{
  //      static private int count = 0;

  //      public Person()
  //      {
  //          this.Id = ++count;
  //      }

		public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }


        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Surname { get; set; }

        [GratherThan18]
        public int Age { get; set; }


        [RequiredForeignKey]
        public int ProfessionId { get; set; }

        public Profession Profession { get; set; }

        //public override string ToString()
        //{
        //    return $"{Name} {Surname} - {Age}";
        //}
    }
}

