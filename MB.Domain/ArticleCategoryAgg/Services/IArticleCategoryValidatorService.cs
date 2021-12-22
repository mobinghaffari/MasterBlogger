namespace MB.Domain.ArticleCategoryAgg.Services
{
    public interface IArticleCategoryValidatorService
    {
        void CheckThatThisRecordAlreadyExists(string title);
    }
}
