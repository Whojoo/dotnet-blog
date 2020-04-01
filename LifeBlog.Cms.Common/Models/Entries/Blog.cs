using System.Collections.Generic;
using Contentful.Core.Models;

namespace LifeBlog.Cms.Common.Models.Entries
{
    public class Blog : BaseEntry
    {
        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Introduction { get; set; }

        public Asset KeyVisual { get; set; }

        public IEnumerable<BaseEntry> Content { get; set; }

        public Author Author { get; set; }

        public string Tag { get; set; }
    }
}