using Blog.Models.Dtos;
using System.Collections.Generic;

namespace Blog.Services
{
    public interface IPostService
    {
        int AddPost(string authorId, AddPostDto addPostDto);
        GetPostDto GetPost(int id);
        IEnumerable<GetPostDto> GetAllPosts();
    }
}
