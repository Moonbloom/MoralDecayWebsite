using System;

namespace Web.Models.Post
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Active { get; set; }
        public String Header { get; set; }
        public String Text { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}