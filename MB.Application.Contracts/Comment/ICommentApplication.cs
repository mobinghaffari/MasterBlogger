using System.Collections.Generic;

namespace MB.Application.Contracts.Comment
{
    public interface ICommentApplication
    {
        void Add(AddComment command);
        List<CommentViewModel> GetList();
    }
}
