using Contentful.Core.Models;

namespace LifeBlog.Cms.Common.Models.Entries
{
    public abstract class BaseEntry
    {
        public SystemProperties Sys { get; set; }

        public string Name { get; set; }
    }
}