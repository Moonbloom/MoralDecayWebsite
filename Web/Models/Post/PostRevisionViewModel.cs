using System;

namespace Web.Models.Post
{
    public class PostRevisionViewModel
    {
        public int Id { get; set; }
        public String Header { get; set; }
        public String Text { get; set; }
        public DateTime ModifiedOn { get; set; }

        public int PostId { get; set; }
    }
}