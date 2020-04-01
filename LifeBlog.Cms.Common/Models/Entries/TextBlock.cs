using Contentful.Core.Models;

namespace LifeBlog.Cms.Common.Models.Entries
{
    public class TextBlock : BaseEntry
    {
        public Document Text { get; set; }
    }
}