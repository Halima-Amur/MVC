using System;
using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Data
{
	public class ApplicationDbContext : DbContext 
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<ToDo>().Property(w => w.isFinished)
				.HasDefaultValue(false);
        }

        public DbSet<ToDo> ToDos { get; set; }
	}
}

