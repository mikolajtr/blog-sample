using Blog.Models.Dtos;
using Blog.Models.Entities;

namespace Blog.Models.Converters
{
    public interface IPostConverter
    {
        Post FromAddPostDtoToPost(AddPostDto addPostDto);
        GetPostDto FromPostToGetPostDto(Post post);
    }
}
