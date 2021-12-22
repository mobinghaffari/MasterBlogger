using MB.Domain.ArticleCategoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Infrastructure.EFCore.Mapping
{
    public class ArticleCategoryMapping: IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder.ToTable("ArticleCategories");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title);
            builder.Property(x => x.CreationDate);
            builder.Property(x => x.IsDeleted);
            builder.HasMany(x => x.Articles)
                .WithOne(x => x.ArticleCategory)
                .HasForeignKey(x => x.ArticleCategoryId);
        }
    }

    
}
