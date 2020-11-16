using System;
using System.Collections.Generic;

#nullable disable

namespace Newsspaper.Models
{
    public partial class News
    {
        public News()
        {
            Posts = new HashSet<Post>();
        }

        public int NewsId { get; set; }
        public string Sections { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
