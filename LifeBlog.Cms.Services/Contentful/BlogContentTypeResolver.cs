using System;
using System.Collections.Generic;
using Contentful.Core.Configuration;
using LifeBlog.Cms.Common.Models.Entries;

namespace LifeBlog.Cms.Services.Contentful
{
    public class BlogContentTypeResolver : IContentTypeResolver
    {
        public Dictionary<string, Type> _types = new Dictionary<string, Type>()
        {
            { "textBlock", typeof(TextBlock) },
            { "widget", typeof(Widget) },
        };

        public Type Resolve(string contentTypeId)
        {
            return _types.TryGetValue(contentTypeId, out var type) ? type : null;
        }
    }
}