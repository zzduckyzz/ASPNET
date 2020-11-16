using System;
using System.Collections.Generic;

#nullable disable

namespace Newsspaper.Models
{
    public partial class Post
    {
        public int PostId { get; set; }
        public int NewsId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }

        public virtual News News { get; set; }
    }
}
