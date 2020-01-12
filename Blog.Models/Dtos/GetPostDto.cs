using System;

namespace Blog.Models.Dtos
{
    public class GetPostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}
