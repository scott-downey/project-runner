using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectRunner.Common.Entities;

namespace ProjectRunner.Infra.Data.Mapping
{
    public class ProjectMapper : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("Varchar(100)");
            builder.Property(prop => prop.Path)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("Path")
               .HasColumnType("Varchar(255)");
            builder.Property(prop => prop.ExecutableId)
                .HasConversion(prop => prop, prop => prop)
                .IsRequired()
                .HasColumnName("ExecutableId")
                .HasColumnType("Int(10)");
            builder.Property(prop => prop.ExecutableArguments)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired(false)
                .HasColumnName("ExecutableArguments")
                .HasColumnType("Varchar(255)");
            builder.Property(prop => prop.ProcessId)
                .IsRequired(false)
                .HasColumnName("ProcessId")
                .HasColumnType("INTEGER");
            builder.HasOne(p => p.Executable)
                .WithMany(e => e.Projects)
                .IsRequired()
                .HasForeignKey(p => p.ExecutableId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Navigation(p => p.Executable);
        }
    }
}
