using System.Collections.Generic;
using System.Threading.Tasks;
using Contentful.Core;
using Contentful.Core.Search;
using LifeBlog.Cms.Common.Models.Entries;
using LifeBlog.Cms.Services.Api;

namespace LifeBlog.Cms.Services.Contentful
{
    public class BlogService : IBlogService
    {
        private readonly IContentfulClient _client;

        public BlogService(IContentfulClient client)
        {
            _client = client;
            _client.ContentTypeResolver = new BlogContentTypeResolver();
        }

        public async Task<IEnumerable<Blog>> GetBlogs()
        {
            var query = QueryBuilder<Blog>.New
                .ContentTypeIs("blog")
                .Include(10);

            return await _client.GetEntries<Blog>(query);
        }
    }
}