using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Concrete.EntityTypeConfigurations
{
    public class StudentEntityTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");
            builder.HasKey(m => m.StudentId);


            builder.Property(m => m.StudentId)
                    .HasColumnType("int")
                    .IsRequired()
                    .UseHiLo("student_hilo");

            builder.Property(m => m.FirstName)
                    .HasColumnType("varchar(50)");

            builder.Property(m => m.LastName)
                    .HasColumnType("varchar(50)");

            builder.Property(m => m.BirthDate)
                    .HasColumnType("datetime2(7)");
                    

        }
    }
}
