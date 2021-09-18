using System;
using System.Collections.Generic;

namespace Supercode.Blazor.BreadcrumbNavigation.Services
{
    public class BreadcrumbBuilder
    {
        public string? Title { get; set; }
        public Action? Action { get; set; }
        public string? Url { get; set; }
        public IEnumerable<KeyValuePair<string, object>>? Attributes { get; set; }


        public string? LeftIcon { get; set; }
        public Action? LeftAction { get; set; }
        public IEnumerable<KeyValuePair<string, object>>? LeftAttributes { get; set; }

        public string? RightIcon { get; set; }
        public Action? RightAction { get; set; }
        public IEnumerable<KeyValuePair<string, object>>? RightAttributes { get; set; }

    }
}
