using Blog.Models.Dtos;
using Blog.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Models.Converters
{
    public class PostConverter : IPostConverter
    {
        public Post FromAddPostDtoToPost(AddPostDto addPostDto)
        {
            return new Post
            {
                Title = addPostDto.Title,
                Text = addPostDto.Text
            };
        }

        public GetPostDto FromPostToGetPostDto(Post post)
        {
            return new GetPostDto
            {
                Id = post.Id,
                Title = post.Title,
                Text = post.Text,
                Created = post.Created,
                AuthorId = post.AuthorId,
                AuthorName = post.Author.UserName
            };
        }
    }
}
