using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OganiTemplate.Models.Entities;

namespace OganiTemplate.Models.Contexts.Configurations
{
    class SubscribePostEntityTypeConfiguration : IEntityTypeConfiguration<SubscribePost>
    {
        public void Configure(EntityTypeBuilder<SubscribePost> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int").UseIdentityColumn(1, 1);
            builder.Property(m => m.Subscribe).HasColumnType("nvarchar").HasMaxLength(150).IsRequired();
            builder.HasKey(m => m.Id);
            builder.ToTable("SubscribePosts");
        }
    }
}
