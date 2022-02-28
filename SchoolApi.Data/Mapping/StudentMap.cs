using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolApi.Domain.Entities;

namespace SchoolApi.Data.Mapping
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder
                .OwnsOne(x => x.Email)
                .Property(x => x.Value)
                .HasColumnName("Email")
                .HasColumnType("varchar(150)");

        }
    }
}