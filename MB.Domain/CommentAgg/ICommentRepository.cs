using System.Collections.Generic;
using MB.Application.Contracts.Comment;

namespace MB.Domain.CommentAgg
{
    public interface ICommentRepository
    {
        void CreateAndSave(Comment entity);
        List<CommentViewModel> GetList();
        Comment Get(long id);
        void Save();
    }
}
