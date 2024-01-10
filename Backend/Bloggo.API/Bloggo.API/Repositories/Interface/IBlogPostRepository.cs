using Bloggo.API.Models.Domain;

namespace Bloggo.API.Repositories.Interface
{
    public interface IBlogPostRepository
    {
        Task<BlogPost> CreateAsync(BlogPost blogPost);


        Task<IEnumerable<BlogPost>> GetAllAsync();
    }
}
