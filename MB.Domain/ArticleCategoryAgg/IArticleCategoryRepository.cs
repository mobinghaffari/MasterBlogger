using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Framework.Infrastructure;
using MB.Domain.CommentAgg;

namespace MB.Domain.ArticleCategoryAgg
{
    public interface IArticleCategoryRepository: IRepository<long, ArticleCategory>
    {
    }
}
