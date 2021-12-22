using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace MB.Application.Contracts.ArticleCategory
{
    public interface IArticleCategoryApplication
    {
        List<ArticleCategoryViewModel> List();
        void Create(CreateArticleCategory command);
        void Rename(RenameArticleCategory command);
        RenameArticleCategory Get(long id);
        void Remove(long id);
        void Activate(long id);
    }
}
