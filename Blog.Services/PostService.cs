using Blog.Models.Converters;
using Blog.Models.Dtos;
using Blog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IPostConverter _postConverter;

        public PostService(IPostRepository postRepository, IPostConverter postConverter)
        {
            _postRepository = postRepository;
            _postConverter = postConverter;
        }

        public int AddPost(string authorId, AddPostDto addPostDto)
        {
            var post = _postConverter.FromAddPostDtoToPost(addPostDto);
            post.AuthorId = authorId;
            post.Created = DateTime.UtcNow;

            return _postRepository.Add(post);
        }

        public IEnumerable<GetPostDto> GetAllPosts()
        {
            return _postRepository.GetAll()
                .Select(p => _postConverter.FromPostToGetPostDto(p));
        }

        public GetPostDto GetPost(int id)
        {
            var post = _postRepository.Get(id);
            return _postConverter.FromPostToGetPostDto(post);
        }
    }
}
