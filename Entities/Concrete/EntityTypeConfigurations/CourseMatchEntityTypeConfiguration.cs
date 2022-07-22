using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Concrete.EntityTypeConfigurations
{
    public class CourseMatchEntityTypeConfiguration : IEntityTypeConfiguration<CourseMatch>
    {
        public void Configure(EntityTypeBuilder<CourseMatch> builder)
        {
            builder.ToTable("CourseMatch");
            builder.HasKey(m => m.CourseMatchId);


            builder.Property(m => m.CourseMatchId)
                    .HasColumnType("int")
                    .IsRequired()
                    .UseHiLo("courseMatch_hilo");

            builder.Property(m => m.StudentId)
                    .HasColumnType("int");

            builder.Property(m => m.CourseId)
                    .HasColumnType("int");
        }
    }
}
