using Contentful.Core.Models;

namespace LifeBlog.Cms.Common.Models.Entries
{
    public class Author : BaseEntry
    {
        public string AuthorName { get; set; }

        public string Description { get; set; }

        public Asset ProfilePicture { get; set; }
    }
}