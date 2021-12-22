using System.Collections.Generic;
using MB.Application.Contracts.Article;
using MB.Domain.ArticleAgg;

namespace MB.Application
{
   public class ArticleApplication:IArticleApplication
   {
       private readonly IArticleRepository _articleRepository;

       public ArticleApplication(IArticleRepository articleRepository)
       {
           _articleRepository = articleRepository;
       }
       public List<ArticleViewModel> GetList()
       {
           return _articleRepository.GetList();
       }
    }
}
