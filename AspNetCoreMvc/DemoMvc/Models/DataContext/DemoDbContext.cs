using System;
using DemoMvc.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace DemoMvc.Models.DataContext
{
	public class DemoDbContext : DbContext
	{
		public DemoDbContext(DbContextOptions options)
			:base(options)
		{

		}

		public DbSet<Profession> Professions { get; set; }

		public DbSet<Person> People { get; set; }

    }
}


