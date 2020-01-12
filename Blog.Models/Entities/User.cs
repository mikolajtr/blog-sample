using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Blog.Models.Entities
{
    public class User : IdentityUser
    {
        public ICollection<Post> Posts { get; set; }
    }
}
