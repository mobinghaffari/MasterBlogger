using System;
using MB.Domain.ArticleCategoryAgg.Exceptions;

namespace MB.Domain.ArticleCategoryAgg.Services
{
    public class ArticleCategoryValidatorService : IArticleCategoryValidatorService
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticleCategoryValidatorService(IArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;
        }
        public void CheckThatThisRecordAlreadyExists(string title)
        {
            if (_articleCategoryRepository.Exists(title))
                throw new DuplicatedRecordException("This record already exists in database");
        }
    }
}