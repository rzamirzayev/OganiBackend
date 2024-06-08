using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OganiTemplate.Models.Entities;

namespace OganiTemplate.Models.Contexts.Configurations
{
    class ContactPostEntityTypeConfiguration : IEntityTypeConfiguration<ContactPost>
    {
        public void Configure(EntityTypeBuilder<ContactPost> builder)
        {
            builder.Property(m=>m.Id).HasColumnType("int").UseIdentityColumn(1,1);
            builder.Property(m => m.FullName).HasColumnType("nvarchar").HasMaxLength(150).IsRequired();
            builder.Property(m => m.Email).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(m => m.Message).HasColumnType("nvarchar").HasMaxLength(500).IsRequired();
            builder.Property(m => m.CreatedAt).HasColumnType("datetime").IsRequired();
            builder.Property(m => m.AnsweredBy).HasColumnType("int").IsRequired(false);
            builder.Property(m => m.AnsweredAt).HasColumnType("datetime").IsRequired(false);
            builder.Property(m => m.AnsweredMessage).HasColumnType("nvarchar").IsRequired(false);
            builder.HasKey(m => m.Id);
            builder.ToTable("ContactPosts");

        }
    }
}
