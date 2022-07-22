using System;
using Entities.Concrete;
using Entities.Concrete.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Contexts
{
    public class KusysContext : DbContext
    {
        public KusysContext(DbContextOptions<KusysContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseMatch> CourseMatches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new StudentEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CourseEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CourseMatchEntityTypeConfiguration());

            modelBuilder.HasSequence<int>("student_hilo")
            .StartsAt(100).IncrementsBy(1);

            modelBuilder.HasSequence<int>("course_hilo")
            .StartsAt(100).IncrementsBy(1);

            modelBuilder.HasSequence<int>("courseMatch_hilo")
            .StartsAt(100).IncrementsBy(1);
        }
    }
}
