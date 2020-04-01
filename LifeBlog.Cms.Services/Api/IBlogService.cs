using System.Collections.Generic;
using System.Threading.Tasks;
using LifeBlog.Cms.Common.Models.Entries;

namespace LifeBlog.Cms.Services.Api
{
    public interface IBlogService
    {
        Task<IEnumerable<Blog>> GetBlogs();
    }
}