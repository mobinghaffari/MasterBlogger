using MB.Domain.ArticleAgg;

namespace MB.Infrastructure.EFCore.Repository
{
   public class ArticleRepository:IArticleRepository
   {
       private readonly MasterBloggerContext _context;

       public ArticleRepository(MasterBloggerContext context)
       {
           _context = context;
       }
   }
}
