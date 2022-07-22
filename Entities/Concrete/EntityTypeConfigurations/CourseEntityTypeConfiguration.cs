using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Concrete.EntityTypeConfigurations
{
    public class CourseEntityTypeConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course");
            builder.HasKey(m => m.CourseId);


            builder.Property(m => m.CourseId)
                    .HasColumnType("int")
                    .IsRequired()
                    .UseHiLo("course_hilo");

            builder.Property(m => m.CourseName)
                    .HasColumnType("varchar(50)");

        }
    }
}
