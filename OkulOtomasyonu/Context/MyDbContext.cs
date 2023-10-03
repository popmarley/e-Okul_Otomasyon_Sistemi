using Microsoft.EntityFrameworkCore;
using OkulOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonu.Context
{
	public class MyDbContext:DbContext
	{
		public DbSet<CourseEnrollment> CourseEnrollments { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Exam> Exams { get; set; }
		public DbSet<ExamResult> ExamResults { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<UserType> UserTypes { get; set; }
		public DbSet<Parent> Parents { get; set; }
		public DbSet<Manager> Managers { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Room> Rooms { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=OZGUVEN;Initial Catalog=TechCareerEgitimOtomasyon;Integrated Security=True");
		}
	}
}
