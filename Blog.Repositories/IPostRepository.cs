using Blog.Models.Entities;
using System.Collections.Generic;

namespace Blog.Repositories
{
    public interface IPostRepository
    {
        Post Get(int id);
        IEnumerable<Post> GetAll();
        int Add(Post post);
    }
}
