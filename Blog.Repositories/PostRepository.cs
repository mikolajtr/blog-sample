using Blog.DataAccess;
using Blog.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly BlogDbContext _db;

        public PostRepository(BlogDbContext db)
        {
            _db = db;
        }

        public Post Get(int id)
        {
            return _db.Posts.First(p => p.Id == id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _db.Posts;
        }

        public int Add(Post post)
        {
            _db.Posts.Add(post);
            _db.SaveChanges();

            return post.Id;
        }
    }
}
