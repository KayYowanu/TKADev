using System.Collections.Generic;
using System.Threading.Tasks;
using TKA.Server.Entities;

namespace TKA.Server.Contracts
{
    public interface IPostService
    {
        Task<int> CreatePost(TKAPosts tkaposts);
        Task<int> DeletePost(int Id);
        Task<int> CountPost(string search);
        Task<int> UpdatePost(TKAPosts tkaposts);
        Task<TKAPosts> GetPostById(int Id);
        Task<List<TKAPosts>> ListAllPosts(int skip, int take, string orderBy, string direction, string search);

        /*COMMENT IMPLEMENTATION*/
        Task<int> CreateComment(TKAComments tkacomments, TKAPosts tkaposts);
        Task<int> DeleteComment(int Id);
        Task<int> CountComment(string search);
        Task<int> UpdateComment(TKAComments tkacomments);
        Task<TKAComments> GetCommentById(int Id);
        Task<List<TKAComments>> ListAllComments();
        Task<List<TKAComments>> ListAllComments(int Id);

        /*REPLIES IMPLEMENTATION*/
        Task<int> CreateReply(TKAReplies tkareplies, TKAComments tkacomments);
        Task<int> DeleteReply(int Id);
        Task<int> CountReply(string search);
        Task<int> UpdateReply(TKAReplies tkareplies);
        Task<List<TKAReplies>> ListAllReplies(int Id);
    }
}
